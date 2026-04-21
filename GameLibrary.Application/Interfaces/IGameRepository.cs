using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary.Domain.Entities;
using GameLibrary.Shared.DTOs.Game;

namespace GameLibrary.Application.Interfaces
{
    public interface IGameRepository
    {
        //Read = Entity -> DTO
        Task<GameDTO?> GetByIdAsync(int id);
        Task<GameDTO[]> GetAllAsync();

        //Write = DTO -> Entity
        Task<Game> AddAsync(Game game);
        Task UpdateAsync(Game game);
        Task DeleteAsync(int id);
    }
}
