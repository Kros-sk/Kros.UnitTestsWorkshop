
namespace Kros.EShop.API;

public class ProductService : IProductService
{
    private readonly HttpClient _httpClient;

    public ProductService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Product> CreateAsync(Product product)
    {
        var response = await _httpClient.GetFromJsonAsync<CurrencyApiResponse>("latest?&base_currency=EUR&currencies=GBP,PLN,CZK,USD");

        product.PriceUsd = product.Price * response!.Data["USD"];
        product.PriceGbp = product.Price * response.Data["GBP"];
        product.PriceCzk = product.Price * response.Data["CZK"];
        product.PricePln = product.Price * response.Data["PLN"];

        // TODO: Save product to database

        return product;
    }
}
