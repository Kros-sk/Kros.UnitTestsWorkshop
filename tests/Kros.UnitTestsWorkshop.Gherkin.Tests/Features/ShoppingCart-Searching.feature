Feature: Shopping Cart - product searching 
    As a user
    I want to be able to search for products in the shopping cart

Background:
    Given the following products
        | name  | price | quantity |
        | apple |  0.50 |        1 |
        | banana|  0.75 |        3 |
        | carrot|  1.00 |        3 |

Scenario: Search for a product
    When I search for "banana"
    Then I should see "banana" in the search results
    And this product should cost "0.75"