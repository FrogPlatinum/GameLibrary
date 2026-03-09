using GameLibrary.Application.Interfaces;
using GameLibrary.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameLibrary.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameRepository _gameRepo;
        public GameController(IGameRepository gameRepo)
        {
            //Dependency Injection
            _gameRepo = gameRepo;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> GetGames()
        {
            var games = await _gameRepo.GetAllAsync();
            return Ok(games);
        }
    }
}
