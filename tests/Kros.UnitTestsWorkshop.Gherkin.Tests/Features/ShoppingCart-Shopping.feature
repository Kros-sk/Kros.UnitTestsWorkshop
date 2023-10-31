Feature: Shopping Cart - purchasing process
    As a customer
    I need to be able to add items to my shopping cart

Background:
    Given the following products in the cart
        | name  | price | quantity |
        | apple |  0.50 |        1 |
        | banana|  0.75 |        3 |
        | carrot|  1.00 |        3 |

Scenario: Check products count and total price
    Then the cart should contain 3 products
    And the total price should be 5.75

Scenario: Add items to cart should be possible
    When I add products to the cart
        | name   | price | quantity |
        | orange | 0.79  | 1        |
    Then the cart should contain 4 products
    And the total price should be 6.54

Scenario: Remove item from cart should be possible
    When I remove the product "apple" from the cart
    Then the cart should contain 2 products
    And the total price should be 5.25
    