namespace Kros.UnitTestsWorkshop.EShop;

public class OrderCalculator : IOrderCalculator
{
    public Order RecalculateOrder(Order order)
    {
        LegacyCalculator.CalculateOrder(order);

        return order;
    }
}
