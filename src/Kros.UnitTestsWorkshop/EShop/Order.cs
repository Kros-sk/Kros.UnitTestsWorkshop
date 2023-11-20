namespace Kros.UnitTestsWorkshop.EShop;

public class Order
{
    public string Number { get; set; } = string.Empty;

    public Client? Client { get; set; }

    public DateOnly? OrderDate { get; set; }

    public DateOnly? EstimatedDeliveryDate { get; set; }

    public string? PaymentMethod { get; set; }

    public List<OrderItem> Items { get; set; } = new List<OrderItem>();

    public decimal Discount { get; set; }

    public decimal TotalPrice { get; set; }

    public decimal VatBase { get; set; }

    public decimal VatAmount { get; set; }

    public decimal TotalPriceWithVat { get; set; }
}