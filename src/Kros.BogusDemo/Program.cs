using Bogus;
using Kros.UnitTestsWorkshop.EShop;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

JsonSerializerOptions jsonOptions = new()
{
    WriteIndented = true,
    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
};

const string locale = "sk";

#region Faker

var clientFaker = new Faker<Client>(locale)
    .StrictMode(true)
    .RuleFor(client => client.TitleBeforeName, faker => faker.Name.Prefix().OrNull(faker, 0.7f))
    .RuleFor(client => client.FirstName, faker => faker.Person.FirstName)
    .RuleFor(client => client.LastName, faker => faker.Person.LastName)
    .RuleFor(client => client.Email, (faker, client) => faker.Person.Email)
    .RuleFor(client => client.Address, faker => faker.Address.FullAddress())
    ;

var orderItemFaker = new Faker<OrderItem>(locale)
    .StrictMode(true)
    .RuleFor(oi => oi.Product, f => f.Commerce.Product())
    .RuleFor(oi => oi.Amount, f => f.Random.Int(1, 20))
    .RuleFor(oi => oi.UnitPrice, f => f.Random.Int(1, 150))
    .RuleFor(oi => oi.Discount, f => f.Random.Int(1, 15).OrDefault(f, 0.9f, 0))
    .RuleFor(oi => oi.VatRate, f => f.PickRandom(new[] { 0, 10, 19, 20 }))
    .RuleFor(oi => oi.TotalPrice, (f, oi) => oi.Amount * oi.UnitPrice * (1 - oi.Discount / 100))
    .RuleFor(oi => oi.TotalPriceWithVat, (f, oi) => oi.Amount * oi.UnitPrice * (1 - oi.Discount / 100) * (1 + oi.VatRate / 100))
    ;

var orderFaker = new Faker<Order>(locale)
    .StrictMode(true)
    .RuleFor(o => o.Number, f => f.Random.AlphaNumeric(10))
    .RuleFor(o => o.Client, f => clientFaker.Generate())
    .RuleFor(o => o.OrderDate, f => f.Date.Past())
    .RuleFor(o => o.EstimatedDeliveryDate, (f, o) => f.Date.Between(o.OrderDate!.Value, o.OrderDate!.Value.AddDays(14)))
    .RuleFor(o => o.PaymentMethod, f => f.PickRandom(new[] { "Cash", "Card", "Bank transfer" }))
    .RuleFor(o => o.Items, f => orderItemFaker.Generate(f.Random.Int(1, 5)))
    .RuleFor(o => o.TotalPrice, (f, o) => o.Items.Sum(oi => oi.TotalPrice))
    .RuleFor(o => o.Discount, f => f.Random.Int(0, 10))
    .RuleFor(o => o.VatBase, (f, o) => o.Items.Sum(oi => oi.TotalPrice))
    .RuleFor(o => o.VatAmount, (f, o) => o.Items.Sum(oi => oi.TotalPriceWithVat) - o.Items.Sum(oi => oi.TotalPrice))
    .RuleFor(o => o.TotalPriceWithVat, (f, o) => o.Items.Sum(oi => oi.TotalPriceWithVat))
    ;

orderFaker.Generate(1)
    .ForEach(item => Console.WriteLine(JsonSerializer.Serialize(item, jsonOptions)));

#endregion Faker
