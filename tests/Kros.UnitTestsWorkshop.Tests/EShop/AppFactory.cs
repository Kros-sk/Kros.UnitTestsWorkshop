using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WireMock.Server;

namespace Kros.UnitTestsWorkshop.Tests.EShop;

public class AppFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        var wireMockServer = WireMockServer.Start();
        builder.ConfigureAppConfiguration((context, config) =>
        {
            config.AddInMemoryCollection(new KeyValuePair<string, string>[]
            {
                new("FreecurrencyApi:ApiKey", "test"),
                new("FreecurrencyApi:BaseUrl", wireMockServer.Urls[0])
            });
        }).ConfigureServices(collection => collection.AddSingleton(wireMockServer));
    }
}
