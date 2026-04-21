using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary.Application.Interfaces;
using GameLibrary.Domain.Entities;
using GameLibrary.Infrastructure.Data;
using GameLibrary.Shared.DTOs.Game;
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

        public async Task<GameDTO[]> GetAllAsync()
        {
            return await _repo.Games
                .AsNoTracking()
                .Select(g => new GameDTO()
                {
                    Id = g.Id,
                    Name = g.Name,
                    Genre = g.Genre,
                    Status = g.Status,
                    HowLongToBeat = g.HowLongToBeat
                })
                .ToArrayAsync();
        }

        public async Task<GameDTO?> GetByIdAsync(int id)
        {
            return await _repo.Games
                .AsNoTracking()
                .Where(g => g.Id == id)
                .Select(g => new GameDTO()
                {
                    Id = g.Id,
                    Name = g.Name,
                    Genre = g.Genre,
                    Status = g.Status,
                    HowLongToBeat = g.HowLongToBeat
                })
                .FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Game game)
        {
            _repo.Games.Update(game);
            await _repo.SaveChangesAsync();
        }
    }
}
