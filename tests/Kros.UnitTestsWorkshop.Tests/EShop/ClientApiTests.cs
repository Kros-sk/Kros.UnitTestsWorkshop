using AutoBogus;
using Kros.UnitTestsWorkshop.EShop;
using System.Net;
using System.Net.Http.Json;

namespace Kros.UnitTestsWorkshop.Tests.EShop
{
    public class ClientApiTests : IClassFixture<AppFactory>
    {
        private readonly AppFactory _factory;

        public ClientApiTests(AppFactory factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task SaveAndLoadClient()
        {
            //HttpClient httpClient = _factory.CreateClient();

            //Client inputClient = null; // Create client data.

            //HttpResponseMessage result = await httpClient.PostAsJsonAsync("/api/clients", inputClient);
            //result.StatusCode.Should().Be(HttpStatusCode.Created);

            //Guid clientId = await result.Content.ReadFromJsonAsync<Guid>();
            //Client loadedClient = (await httpClient.GetFromJsonAsync<Client>($"/api/clients/{clientId}"))!;

            //loadedClient.Should().BeEquivalentTo(inputClient, options => options.Excluding(client => client.Id));
        }
    }
}
