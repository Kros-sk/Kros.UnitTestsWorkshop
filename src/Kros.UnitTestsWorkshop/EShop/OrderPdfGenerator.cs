using QuestPDF.Fluent;

namespace Kros.UnitTestsWorkshop.EShop;

public class OrderPdfGenerator
{
    public byte[] Generate(Order order)
    {
        var report = new OrderReport(new OrderReportModel
        {
            Client = order.Client!,
            Order = order
        });

        return report.GeneratePdf();
    }
}
