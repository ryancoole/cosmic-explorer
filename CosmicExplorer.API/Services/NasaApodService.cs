using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CosmicExplorer.API.Models;
using Microsoft.Extensions.Configuration;

public class NasaApodService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;

    public NasaApodService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _apiKey = configuration["NasaApi:ApiKey"];
    }

    public async Task<NasaApodResponseDto> GetApodAsync()
    {
        var url = $"https://api.nasa.gov/planetary/apod?api_key={_apiKey}";
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();

        // Deserialize JSON into the DTO
        var apodData = JsonSerializer.Deserialize<NasaApodResponseDto>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return apodData;
    }
}