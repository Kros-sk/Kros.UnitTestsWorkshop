using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Json;
using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;
using WireMock.Server;

namespace Kros.UnitTestsWorkshop.Tests.EShop
{
    public class ProductsIntegrationTests : IClassFixture<AppFactory>
    {
        //private readonly AppFactory _factory;
        //private readonly WireMockServer _wireMockServer;

        //public ProductsIntegrationTests(AppFactory factory)
        //{
        //    _factory = factory;
        //    _wireMockServer = factory.Services.GetRequiredService<WireMockServer>();
        //}

        //[Fact]
        //public async Task CreateNewProduct()
        //{
        //    Product product = new()
        //    {
        //        Name = "Test product",
        //        Price = 10
        //    };

        //    _wireMockServer
        //        .Given(Request.Create().WithPath("/latest").UsingGet())
        //        .RespondWith(Response.Create().WithBodyAsJson(new CurrencyApiResponse
        //        {
        //            Data = new Dictionary<string, decimal>
        //            {
        //                { "USD", 1.2m },
        //                { "GBP", 0.8m },
        //                { "CZK", 25m },
        //                { "PLN", 4.5m }
        //            }
        //        }));

        //    var client = _factory.CreateClient();
        //    var response = await client.PostAsJsonAsync("/products", product);

        //    response.EnsureSuccessStatusCode();
        //    var result = await response.Content.ReadFromJsonAsync<Product>();

        //    result!.PriceCzk.Should().Be(250);
        //    result.PriceGbp.Should().Be(8);
        //    result.PricePln.Should().Be(45);
        //    result.PriceUsd.Should().Be(12);
        //}

        //[Theory]
        //[InlineData("EUR", "USD", 1.2)]
        //[InlineData("EUR", "GBP", 0.8)]
        //[InlineData("EUR", "CZK", 25)]
        //[InlineData("EUR", "PLN", 4.5)]
        //public async Task RecalculatePrice(string baseCurrency, string targetCurrency, decimal exchangeRate)
        //{
        //    // configure WireMockServer
        //    // ..

        //    var client = _factory.CreateClient();
        //    var response = await client.GetAsync($"/recalculate/{baseCurrency}/{targetCurrency}?price=100");

        //    response.EnsureSuccessStatusCode();
        //    var result = await response.Content.ReadFromJsonAsync<decimal>();

        //    result.Should().Be(exchangeRate * 100);
        //}
    }
}
