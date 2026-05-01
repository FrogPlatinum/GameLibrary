using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary.Application.Interfaces;
using GameLibrary.Domain.Entities;
using GameLibrary.Domain.Enums;
using GameLibrary.Shared.DTOs.Game;

namespace GameLibrary.Infrastructure.Repositories
{
    public class InMemoryGameRepo : IGameRepository
    {
        public Task<Game> AddAsync(Game game)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Game>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Game?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
