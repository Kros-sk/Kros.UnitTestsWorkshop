namespace Kros.EShop.API;

public interface IProductService
{
    Task<Product> CreateAsync(Product product);
}
