using Kros.EShop.API;
using WireMock.RequestBuilders;
using WireMock.ResponseBuilders;

namespace Kros.UnitTestsWorkshop.Tests.EShop
{
    public class ProductServiceShould
    {
        [Fact]
        public async Task CreateNewProduct()
        {
            using var wireMockServer = WireMock.Server.WireMockServer.Start();
            // var ulr = wireMockServer.Url 👈 keď potrebujete url na ktorú sa má poslať request
            using var client = wireMockServer.CreateClient();

            wireMockServer
                .Given(Request.Create().WithPath("/latest").UsingGet())
                .RespondWith(Response.Create().WithBodyAsJson(new CurrencyApiResponse
                {
                    Data = new Dictionary<string, decimal>
                    {
                        { "USD", 1.2m },
                        { "GBP", 0.8m },
                        { "CZK", 25m },
                        { "PLN", 4.5m }
                    }
                }));

            var productService = new ProductService(client);

            Product product = new()
            {
                Name = "Test product",
                Price = 10
            };

            var result = await productService.CreateAsync(product);

            result!.PriceCzk.Should().Be(250);
            result.PriceGbp.Should().Be(8);
            result.PricePln.Should().Be(45);
            result.PriceUsd.Should().Be(12);
        }
    }
}
