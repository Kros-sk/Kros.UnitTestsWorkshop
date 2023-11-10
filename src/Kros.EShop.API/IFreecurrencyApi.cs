using Refit;

public interface IFreecurrencyApi
{
    [Get("/latest?&base_currency={baseCurrency}&currencies=GBP,PLN,CZK,USD")]
    Task<CurrencyApiResponse> GetRatesAsync(string baseCurrency);
}
