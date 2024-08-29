using CosmicExplorer.UI.Models;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace CosmicExplorer.UI.Services
{
    public class NasaApodService
    {
        private readonly HttpClient _httpClient;

        public NasaApodService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("CosmicExplorerAPI");
        }

        public async Task<NasaApodResponseDto> GetApodAsync()
        {
            var response = await _httpClient.GetAsync("apod"); // Adjust if needed
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var apodData = JsonSerializer.Deserialize<NasaApodResponseDto>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return apodData;
        }
    }
}