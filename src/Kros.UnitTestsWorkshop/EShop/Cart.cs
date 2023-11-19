namespace Kros.UnitTestsWorkshop.EShop;

public class Cart
{
    private List<Product> _products;
    private decimal _totalPrice;

    public Cart()
    {
        _products = new List<Product>();
    }

    public void AddItem(string product, decimal price, int quantity = 1)
    {
        var existingItem = _products.FirstOrDefault(item => item.Name == product);
        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            _products.Add(new Product(product, price, quantity));
        }

        _totalPrice += price * quantity;
    }

    public void RemoveItem(string product)
    {
        _products.RemoveAll(item => item.Name == product);
    }

    public int GetProductsCount() => _products.Count();

    public decimal GetTotal() => _totalPrice;

    private class Product
    {
        public string Name { get; }
        public decimal Price { get; }
        public int Quantity { get; set; }

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}