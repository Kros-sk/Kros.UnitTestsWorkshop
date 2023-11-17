using System;
using TechTalk.SpecFlow;

namespace Eshop
{
    [Binding]
    public class EshopSearchingSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public EshopSearchingSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"the following products")]
        public void GivenTheFollowingProducts(Table givenProducts)
        {
            // _scenarioContext.Pending();
        }

        [When(@"I search for ""(.*)""")]
        public void WhenIsearchfor(string args1)
        {
            // _scenarioContext.Pending();
        }

        [Then(@"I should see ""(.*)"" in the search results")]
        public void ThenIshouldseeinthesearchresults(string args1)
        {
            // _scenarioContext.Pending();
        }
        
        [Then(@"this product should cost ""(.*)""")]
        public void Thenthisproductshouldcost(decimal args1)
        {
            // _scenarioContext.Pending();
        }

    }
}