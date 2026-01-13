
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp;

public class HttpClientRequest
{
    private readonly HttpClient _httpClient;
    // It was recommended in the latest articles to use httpClient as an interface

    public HttpClientRequest()
    {
        // Build configuration
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        // Set up dependency injection
        var services = new ServiceCollection();

        services.AddHttpClient("LocationApi", client =>
        {
            client.BaseAddress = new Uri("http://api.openweathermap.org/geo/1.0/direct?q=London&limit=5&appid={API key}");

            // Add appId parameter to all client requests
            var appId = configuration["AppSettings:appId"];
            client.params.Add("appid", appId);
        });

        var serviceProvider = services.BuildServiceProvider();

        // Get the HttpClient factory and create a named client "WeatherApi"
        var httpClientFactory = serviceProvider.GetRequiredService<IHttpClientFactory>();
        _httpClient = httpClientFactory.CreateClient("LocationApi");
    }

    public HttpClient GetHttpClient()
    {
        return _httpClient;
    }
}
