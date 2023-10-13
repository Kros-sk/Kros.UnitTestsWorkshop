namespace Kros.UnitTestsWorkshop.EShop;

public class OrderItem
{
    public string? Product { get; set; }

    public decimal Amount { get; set; }

    public decimal UnitPrice { get; set; }

    public decimal Discount { get; set; }

    public decimal VatRate { get; set; }

    public decimal TotalPrice { get; set; }

    public decimal TotalPriceWithVat { get; set; }
}