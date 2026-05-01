using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary.Application.Interfaces;
using GameLibrary.Domain.Entities;
using GameLibrary.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace GameLibrary.Infrastructure.Repositories
{
    public class DBGameRepo : IGameRepository
    {
        private AppDbContext _repo;
        public DBGameRepo(AppDbContext context)
        {
            _repo = context;
        }

        public async Task<Game> AddAsync(Game game)
        {
            _repo.Add(game);
            await _repo.SaveChangesAsync();
            return game;
        }

        public async Task DeleteAsync(int id)
        {
            var game = await _repo.Games.FindAsync(id);
            if (game != null)
            {
                _repo.Games.Remove(game);
                await _repo.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Game>> GetAllAsync()
        {
            return await _repo.Games.ToListAsync();
        }

        public async Task<Game?> GetByIdAsync(int id)
        {
            return await _repo.Games.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(Game game)
        {
            _repo.Games.Update(game);
            await _repo.SaveChangesAsync();
        }
    }
}
