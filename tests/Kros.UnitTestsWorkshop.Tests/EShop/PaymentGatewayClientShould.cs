//using Kros.EShop.API;
//using WireMock.RequestBuilders;
//using WireMock.ResponseBuilders;
//using static Kros.EShop.API.PaymentGatewayClient;

//namespace Kros.UnitTestsWorkshop.Tests.EShop;

//public class PaymentGatewayClientShould
//{
//    [Fact]
//    public async Task ProcessPayment_ReturnSuccess()
//    {
//        using var wireMockServer = WireMock.Server.WireMockServer.Start();
//        wireMockServer
//            .Given(Request.Create().WithPath("/api/payments").UsingPost())
//            .RespondWith(Response.Create()
//                .WithStatusCode(200)
//                .WithBodyAsJson(new PaymentResult { Success = true, TransactionId = "123456" }));

//        using var client = wireMockServer.CreateClient();
//        var paymentGatewayClient = new PaymentGatewayClient(client);

//        var paymentDetails = new PaymentDetails
//        {
//            CardNumber = "1234-5678-9012-3456",
//            Amount = 100
//        };

//        var result = await paymentGatewayClient.ProcessPayment(paymentDetails);

//        result.Should().NotBeNull();
//        result.Success.Should().BeTrue();
//        result.TransactionId.Should().Be("123456");
//    }

//    [Fact]
//    public async Task ProcessPayment_ReturnErrorOnInvalidPaymentDetails()
//    {
//        using var wireMockServer = WireMock.Server.WireMockServer.Start();

//        // 👇 Nakonfiguruj WireMockServer tak, aby vrátil chybový stav 400
//        // a správu "Invalid payment details" pri volaní na /api/payments
//        // 💁‍ tip: na response použi WithBody("Invalid payment details") metódu

//        using var client = wireMockServer.CreateClient();
//        var paymentGatewayClient = new PaymentGatewayClient(client);

//        var paymentDetails = new PaymentDetails
//        {
//            CardNumber = "0000-0000-0000-0000",
//            Amount = 100
//        };

//        var result = await paymentGatewayClient.ProcessPayment(paymentDetails);

//        result.Success.Should().BeFalse();
//        result.ErrorMessage.Should().Contain("Invalid payment details");
//    }
//}
