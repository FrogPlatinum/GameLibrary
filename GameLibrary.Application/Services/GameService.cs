using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary.Application.Interfaces;
using GameLibrary.Shared.DTOs.Game;
using GameLibrary.Domain.Entities;

namespace GameLibrary.Application.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _repo;
        public GameService(IGameRepository repo)
        {
            _repo = repo;
        }
        public async Task<GameDto> AddGame(GameDto dto)
        {
            var entity = new Game
            {
                Name = dto.Name,
                Genre = dto.Genre,
                Status = dto.Status,
                HowLongToBeat = dto.HowLongToBeat,
            };
            await _repo.AddAsync(entity);

            return new GameDto
            {
                Name = dto.Name,
                Genre = dto.Genre,
                Status = dto.Status,
                HowLongToBeat = dto.HowLongToBeat,
            };


        }

        public Task DeleteGame(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GameDto[]> GetAllGames()
        {
            throw new NotImplementedException();
        }

        public Task<GameDto?> GetGameById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateGame(GameDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
