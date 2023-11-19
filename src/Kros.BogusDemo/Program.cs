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

var clientFaker = new Faker<Client>();

clientFaker.Generate(5)
    .ForEach(item => Console.WriteLine(JsonSerializer.Serialize(item, jsonOptions)));
