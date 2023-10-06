// namespace Kros.Mutation;

// public class Cart
// {
//     private List<Item> _items;
//     private decimal _totalPrice;

//     public Cart()
//     {
//         _items = new List<Item>();
//     }

//     public void AddItem(string product, decimal price, int quantity = 1)
//     {
//         var existingItem = _items.FirstOrDefault(item => item.Product == product);
//         if (existingItem != null)
//         {
//             existingItem.Quantity += quantity;
//         }
//         else
//         {
//             _items.Add(new Item(product, price, quantity));
//         }

//         _totalPrice += price * quantity;
//     }

//     public void RemoveItem(string product)
//     {
//         _items.RemoveAll(item => item.Product == product);
//     }

//     public decimal GetTotal() => _totalPrice;

//     private class Item
//     {
//         public string Product { get; }
//         public decimal Price { get; }
//         public int Quantity { get; set; }

//         public Item(string product, decimal price, int quantity)
//         {
//             Product = product;
//             Price = price;
//             Quantity = quantity;
//         }
//     }
// }