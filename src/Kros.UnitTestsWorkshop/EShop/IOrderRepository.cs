namespace Kros.UnitTestsWorkshop.EShop;

public interface IOrderRepository
{
    IEnumerable<Order> GetOrders(DateTime fromDate, DateTime toDate);
}