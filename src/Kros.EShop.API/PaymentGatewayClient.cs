namespace Kros.EShop.API;

public class PaymentGatewayClient
{
    private readonly HttpClient _httpClient;

    public PaymentGatewayClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<PaymentResult> ProcessPayment(PaymentDetails paymentDetails)
    {
        HttpResponseMessage response;

        try
        {
            response = await _httpClient.PostAsJsonAsync("/api/payments", paymentDetails);
        }
        catch (HttpRequestException ex)
        {
            return new PaymentResult { Success = false, ErrorMessage = ex.Message };
        }

        if (!response.IsSuccessStatusCode)
        {
            var error = await response.Content.ReadAsStringAsync();
            return new PaymentResult { Success = false, ErrorMessage = error };
        }

        var result = await response.Content.ReadFromJsonAsync<PaymentResult>();
        return result;
    }

    public class PaymentDetails
    {
        public string CardNumber { get; set; }
        public decimal Amount { get; set; }
    }

    public class PaymentResult
    {
        public bool Success { get; set; }
        public string TransactionId { get; set; }
        public string ErrorMessage { get; set; }
    }
}