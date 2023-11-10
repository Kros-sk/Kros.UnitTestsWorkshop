using Microsoft.Extensions.Options;
using System.Web;

public class ApiKeyHandler : DelegatingHandler
{
    private readonly string _apiKey;

    public ApiKeyHandler(IOptions<FreecurrencyApiConfig> options)
    {
        _apiKey = options.Value.ApiKey;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var uriBuilder = new UriBuilder(request.RequestUri!);
        var query = HttpUtility.ParseQueryString(uriBuilder.Query);
        query["apikey"] = _apiKey;
        uriBuilder.Query = query.ToString();

        request.RequestUri = uriBuilder.Uri;

        return await base.SendAsync(request, cancellationToken);
    }
}
