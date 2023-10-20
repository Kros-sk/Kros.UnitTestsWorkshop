using QuestPDF.Infrastructure;

namespace Kros.UnitTestsWorkshop.EShop;

public class OrderPdfGenerator
{
    public IDocument Generate(Order order)
    {
        var report = new OrderReport(new OrderReportModel
        {
            Client = order.Client!,
            Order = order
        });

        return report;
    }
}
