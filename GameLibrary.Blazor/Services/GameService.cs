using GameLibrary.Domain.Entities;
using GameLibrary.Domain.Enums;

namespace GameLibrary.Blazor.Services
{
    public class GameService
    {
        private readonly HttpClient _http;
        
        public GameService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Game>> GetGamesAsync()
        {
            return await _http.GetFromJsonAsync<List<Game>>($"{_http.BaseAddress}/games") ?? [];
        }
    }
}
