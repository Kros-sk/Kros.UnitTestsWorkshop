namespace Kros.UnitTestsWorkshop.EShop;

public class OrderRepository : IOrderRepository
{
    public IEnumerable<Order> GetOrders(DateTime fromDate, DateTime toDate)
    {
        var sampleOrders = GenerateSampleOrders();
        return sampleOrders.Where(o => o.OrderDate.HasValue && o.OrderDate >= fromDate && o.OrderDate <= toDate);
    }

    private static IEnumerable<Order> GenerateSampleOrders()
    {
        List<Order> orders = new()
        {
            new() {
                Number = "ORD-1001",
                Client = new Client
                {
                    FirstName = "Martin",
                    LastName = "Novak",
                    Email = "martin.novak@email.com",
                    Address = "Námestie Slobody 1, Bratislava"
                },
                OrderDate = DateTime.Now.AddDays(-45),
                EstimatedDeliveryDate = DateTime.Now.AddDays(-30),
                PaymentMethod = "Credit Card",
                Items = new List<OrderItem>
            {
                new() {
                    Product = "Notebook Lenovo",
                    Amount = 1,
                    UnitPrice = 900,
                    Discount = 0,
                    VatRate = 20,
                    TotalPrice = 900,
                    TotalPriceWithVat = 1080
                },
                new() {
                    Product = "USB Mouse",
                    Amount = 2,
                    UnitPrice = 15,
                    Discount = 5,
                    VatRate = 20,
                    TotalPrice = 25,
                    TotalPriceWithVat = 30
                }
            },
                Discount = 20,
                TotalPrice = 925,
                VatBase = 185,
                VatAmount = 185,
                TotalPriceWithVat = 1110
            },
            new() {
                Number = "ORD-1002",
                Client = new Client
                {
                    FirstName = "Eva",
                    LastName = "Horakova",
                    Email = "eva.horakova@email.com",
                    Address = "Hlavná 24, Košice"
                },
                OrderDate = DateTime.Now.AddDays(-15),
                EstimatedDeliveryDate = DateTime.Now.AddDays(5),
                PaymentMethod = "Bank Transfer",
                Items = new List<OrderItem>
            {
                new() {
                    Product = "Samsung Smartphone",
                    Amount = 1,
                    UnitPrice = 800,
                    Discount = 50,
                    VatRate = 20,
                    TotalPrice = 750,
                    TotalPriceWithVat = 900
                }
            },
                Discount = 0,
                TotalPrice = 750,
                VatBase = 150,
                VatAmount = 150,
                TotalPriceWithVat = 900
            },
            new() {
                Number = "ORD-1003",
                Client = new Client
                {
                    FirstName = "Peter",
                    LastName = "Varga",
                    Email = "peter.varga@email.com",
                    Address = "Lesna 3, Trencin"
                },
                OrderDate = DateTime.Now.AddDays(-10),
                EstimatedDeliveryDate = DateTime.Now.AddDays(10),
                PaymentMethod = "Credit Card",
                Items = new List<OrderItem>
            {
                new() {
                    Product = "Apple iPad",
                    Amount = 1,
                    UnitPrice = 600,
                    Discount = 0,
                    VatRate = 20,
                    TotalPrice = 600,
                    TotalPriceWithVat = 720
                }
            },
                Discount = 0,
                TotalPrice = 600,
                VatBase = 120,
                VatAmount = 120,
                TotalPriceWithVat = 720
            },
            new() {
                Number = "ORD-1004",
                Client = new Client
                {
                    FirstName = "Jana",
                    LastName = "Kovacova",
                    Email = "jana.kovacova@email.com",
                    Address = "Krajna 45, Nitra"
                },
                OrderDate = DateTime.Now.AddDays(-20),
                EstimatedDeliveryDate = DateTime.Now.AddDays(0),
                PaymentMethod = "Credit Card",
                Items = new List<OrderItem>
            {
                new() {
                    Product = "Sony Camera",
                    Amount = 1,
                    UnitPrice = 500,
                    Discount = 25,
                    VatRate = 20,
                    TotalPrice = 475,
                    TotalPriceWithVat = 570
                }
            },
                Discount = 0,
                TotalPrice = 475,
                VatBase = 95,
                VatAmount = 95,
                TotalPriceWithVat = 570
            },
            new() {
                Number = "ORD-1005",
                Client = new Client
                {
                    FirstName = "Stefan",
                    LastName = "Rusnak",
                    Email = "stefan.rusnak@email.com",
                    Address = "Horska 11, Banska Bystrica"
                },
                OrderDate = DateTime.Now.AddDays(-7),
                EstimatedDeliveryDate = DateTime.Now.AddDays(7),
                PaymentMethod = "Bank Transfer",
                Items = new List<OrderItem>
            {
                new() {
                    Product = "Bose Headphones",
                    Amount = 1,
                    UnitPrice = 250,
                    Discount = 10,
                    VatRate = 20,
                    TotalPrice = 240,
                    TotalPriceWithVat = 288
                },
                new() {
                    Product = "Charging Cable",
                    Amount = 2,
                    UnitPrice = 10,
                    Discount = 0,
                    VatRate = 20,
                    TotalPrice = 20,
                    TotalPriceWithVat = 24
                }
            },
                Discount = 5,
                TotalPrice = 255,
                VatBase = 51,
                VatAmount = 51,
                TotalPriceWithVat = 306
            }
        };

        return orders;
    }
}
