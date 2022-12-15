using Microsoft.Extensions.Configuration;
using ServiceContracts;
using System.Net.Http;

namespace Services;

public class FinnhubService : IFinnhubService
{
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public FinnhubService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _configuration = configuration;
    }

    public Task<Dictionary<string, object>?> GetCompanyProfile(string stockSymbol)
    {
        HttpClient client = new HttpClient();

        throw new NotImplementedException();
    }

    public Task<Dictionary<string, object>?> GetStockPriceQuote(string stockSymbol)
    {
        throw new NotImplementedException();
    }

    public async Task<string> GetStockQuote(string stockSymbol)
    {
        var apiKey = _configuration["FinnhubApiKey"];
        var url = $"https://finnhub.io/api/v1/quote?symbol={stockSymbol}&token={apiKey}";
        var response = await _httpClient.GetAsync(url);
        var content = await response.Content.ReadAsStringAsync();
        return content;
    }
}