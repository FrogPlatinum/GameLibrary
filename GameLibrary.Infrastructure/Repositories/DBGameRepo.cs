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

        public async Task<Game> AddAsync(Game entity)
        {
            await _repo.AddAsync(entity);
            await _repo.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id)
        {
            await _repo.Games.Where(g => g.Id == id).ExecuteDeleteAsync();
            await _repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<Game>> GetAllAsync()
        {
           return await _repo.Games.ToListAsync();
        }

        public async Task<Game?> GetByIdAsync(int id)
        {
            return await _repo.Games.FindAsync(id);
        }

        public async Task UpdateAsync(Game entity)
        {
            throw new NotImplementedException();
        }
    }
}
