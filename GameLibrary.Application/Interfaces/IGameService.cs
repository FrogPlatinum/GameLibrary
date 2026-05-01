using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary.Domain.Entities;
using GameLibrary.Shared.DTOs.Game;

namespace GameLibrary.Application.Interfaces
{
    public interface IGameService
    {
        Task<GameDto?> GetGameById(int id);
        Task<GameDto[]> GetAllGames();
        Task<GameDto> AddGame(GameDto dto);
        Task UpdateGame(GameDto dto);
        Task DeleteGame(int id);
    }
}
