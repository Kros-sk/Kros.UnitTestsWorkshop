using FluentAssertions;
using Kros.UnitTestsWorkshop.EShop;
using TechTalk.SpecFlow;

namespace Eshop
{
    [Binding]
    public class EshopShoppingSteps
    {
        private Cart _cart;

        public EshopShoppingSteps(Cart cart)
        {
            _cart = cart;
        }

        [Given(@"the following products in the cart")]
        public void GivenTheFollowingProducts(Table givenProducts)
        {
            AddItems(givenProducts);
        }
        
        [Then(@"the cart should contain (.*) products")]
        public void ThenCartShouldContainItems(int expectedItemsCount)
        {
            _cart.GetProductsCount().Should().Be(expectedItemsCount);
        }
        
        [Then(@"the total price should be (.*)")]
        public void Thenthetotalpriceshouldbe(decimal expectedTotalPrice)
        {
            _cart.GetTotal().Should().Be(expectedTotalPrice);
        }
        
        [When(@"I add products to the cart")]
        public void WhenIAddProductsToCart(Table givenProducts)
        {
            AddItems(givenProducts);
        }
                
        [When(@"I remove the product ""(.*)"" from the cart")]
        public void WhenIremovetheproductfromthecart(string productName)
        {
            _cart.RemoveItem(productName);
        }

        private void AddItems(Table givenProducts)
        {
            foreach (var row in givenProducts.Rows)
            {
                _cart.AddItem(row["name"], decimal.Parse(row["price"]), int.Parse(row["quantity"]));
            }
        }

    }
}