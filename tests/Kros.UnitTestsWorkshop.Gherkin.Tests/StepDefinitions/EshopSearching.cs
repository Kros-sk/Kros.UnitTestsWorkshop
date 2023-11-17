using Kros.UnitTestsWorkshop.EShop;

namespace Eshop
{
    [Binding]
    public class EshopSearchingSteps
    {
        private Catalog _catalog;
        private Catalog.Product? _searchedProduct;

        public EshopSearchingSteps(Catalog catalog)
        {
            _catalog = catalog;
        }

        [Given(@"the following products")]
        public void GivenTheFollowingProducts(Table givenProducts)
        {
            AddProducts(givenProducts);
        }

        [When(@"I search for ""(.*)""")]
        public void WhenISearchFor(string productName)
        {
            _searchedProduct = _catalog.GetProduct(productName);
        }

        [Then(@"I should see ""(.*)"" in the search results")]
        public void ThenIShouldGetIt(string productName)
        {
            _searchedProduct!.Name.Should().Be(productName);
        }

        [Then(@"this product should cost ""(.*)""")]
        public void ThenProductShouldCost(decimal price)
        {
            _searchedProduct!.Price.Should().Be(price);
        }

        private void AddProducts(Table givenProducts)
        {
            foreach (var row in givenProducts.Rows)
            {
                _catalog.AddProduct(row["name"], decimal.Parse(row["price"]));
            }
        }

    }
}