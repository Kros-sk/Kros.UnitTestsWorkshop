namespace Kros.UnitTestsWorkshop.EShop;

public class Catalog
{
    private List<Product> _products;

    public Catalog()
    {
        _products = new List<Product>();
    }

    public void AddProduct(string productName, decimal price)
    {
        var existingItem = _products.FirstOrDefault(item => item.Name == productName);
        if (existingItem is null)
        {
            _products.Add(new Product(productName, price));
        }
    }

    public Product? GetProduct(string productName)
    {
        return _products.FirstOrDefault(item => item.Name == productName);
    }

    public class Product
    {
        public string Name { get; }
        public decimal Price { get; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}