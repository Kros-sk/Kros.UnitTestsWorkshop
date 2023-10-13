namespace Kros.UnitTestsWorkshop.EShop;

public static class LegacyCalculator
{
    public static void CalculateOrder(Order order)
    {
        decimal totalPrice = 0;
        decimal totalVat = 0;

        foreach (var item in order.Items)
        {
            item.TotalPrice = item.UnitPrice * item.Amount - item.Discount;
            item.TotalPriceWithVat = item.TotalPrice + (item.VatRate / 100) * item.TotalPrice;

            totalPrice += item.TotalPrice;
            totalVat += (item.VatRate / 100) * item.TotalPrice;
        }

        order.TotalPrice = totalPrice - order.Discount;
        order.VatAmount = totalVat;
        order.TotalPriceWithVat = order.TotalPrice + order.VatAmount;
    }
}