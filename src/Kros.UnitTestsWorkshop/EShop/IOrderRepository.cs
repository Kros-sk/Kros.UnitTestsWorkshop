namespace Kros.UnitTestsWorkshop.EShop;

public interface IOrderRepository
{
    IEnumerable<Order> GetOrders(DateOnly fromDate, DateOnly toDate);
}