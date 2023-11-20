# Bonus examples

Add scenarious for:
- Setting quantity of product to 0 should remove product from shopping cart
- Quantity of a book should be changeable


## LivingDoc

Install:
`dotnet tool install --global SpecFlow.Plus.LivingDoc.CLI`

Generate html:
`livingdoc test-assembly tests/Kros.UnitTestsWorkshop.Gherkin.Tests/bin/Debug/net7.0/Kros.UnitTestsWorkshop.Gherkin.Tests.dll -t tests/Kros.UnitTestsWorkshop.Gherkin.Tests/bin/Debug/net7.0/TestExecution.json`
