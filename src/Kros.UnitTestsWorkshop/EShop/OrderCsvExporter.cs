using System.Globalization;
using CsvHelper;

namespace Kros.UnitTestsWorkshop.EShop;

public class OrderCsvExporter
{
    public async Task<Stream> ExportOrders(IOrderRepository repository, DateOnly fromDate, DateOnly toDate)
    {
        var orders = repository.GetOrders(fromDate, toDate);

        var memoryStream = new MemoryStream();
        var streamWriter = new StreamWriter(memoryStream);
        var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

        csvWriter.WriteRecords(orders);

        await streamWriter.FlushAsync();
        memoryStream.Position = 0;

        return memoryStream;
    }
}
