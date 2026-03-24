using GameLibrary.Domain.Entities;
using GameLibrary.Domain.Enums;

namespace GameLibrary.Blazor.Services
{
    public class GameService
    {
        private readonly HttpClient _http;
        private readonly string _baseUrl;
        
        public GameService(HttpClient http, IConfiguration configuration)
        {
            _http = http;
            _baseUrl = configuration["ApiSettings:BaseUrl"];
        }

        public async Task<List<Game>> GetGamesAsync()
        {
            var response = await _http.GetAsync($"{_baseUrl}/game");
            return await response.Content.ReadFromJsonAsync<List<Game>>();
        }
    }
}
