namespace Kros.Mutation.Tests;

public class CartShould
{
    [Theory]
    [InlineData("apple", 1, 1, 1)]
    [InlineData("apple", 2, 1, 2)]
    // [InlineData("apple", 4, 6, 2)] // 👈 odkomentuj
    public void AddItemsToCart(string product, decimal price, int quantity, decimal expectedTotal)
    {
        var cart = new Cart();

        cart.AddItem(product, price, quantity);
        cart.GetTotal().Should().Be(expectedTotal);
    }

    // 👇 Odkomentuj
    //[Fact]
    //public void UpdateProduct()
    //{
    //    var cart = new Cart();

    //    cart.AddItem("banana", 5, 3);
    //    cart.AddItem("banana", 2, 2);

    //    cart.GetItem("banana")!.Quantity
    //        .Should().Be(5);
    //    cart.GetTotal().Should().Be(19);
    //}

    [Theory]
    [InlineData("apple")]
    [InlineData("banana")]
    [InlineData("orange")]
    public void RemoveItemsFromCart(string product)
    {
        var cart = new Cart();

        //cart.AddItem(product, 5, 6); 👈 odkomentuj
        cart.RemoveItem(product);

        cart.GetItem(product)
            .Should().BeNull();
    }

    [Theory]
    [MemberData(nameof(GetTestData))]
    public void CalculateTotalCorrectly(IEnumerable<Item> items, decimal expectedTotal)
    {
        var cart = new Cart();

        foreach (var item in items)
        {
            cart.AddItem(item.Product, item.Price, item.Quantity);
        }

        cart.GetTotal().Should().Be(expectedTotal);
    }

    public static IEnumerable<object[]> GetTestData()
    {
        yield return new object[] { new List<Item>(){
            new("apple", 1, 1),
            new("banana", 2, 1),
            new("orange", 5, 1)
        }, 8 };

        //yield return new object[] { new List<Item>(){
        //    new("banana", 2, 2),
        //    new("orange", 5, 2)
        //}, 14 }; // 👈 odkomentuj
    }

    public record Item(string Product, decimal Price, int Quantity);
}
