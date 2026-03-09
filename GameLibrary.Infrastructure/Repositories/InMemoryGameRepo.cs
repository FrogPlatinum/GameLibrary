using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary.Application.Interfaces;
using GameLibrary.Domain.Entities;
using GameLibrary.Domain.Enums;

namespace GameLibrary.Infrastructure.Repositories
{
    public class InMemoryGameRepo : IGameRepository
    {
        private readonly List<Game> _games = new()
        {
            // Elden Ring: Nightreign (Soulslike co-op)
            new Game
            {
                Id = 1,
                Name = "Elden Ring: Nightreign",
                Genre = GameGenre.Coop,
                Status = GameStatus.InProgress,
                HowLongToBeat = 80
            },

            // Nioh 3 (Soulslike action)
            new Game
            {
                Id = 2,
                Name = "Nioh 3",
                Genre = GameGenre.Soulslike,
                Status = GameStatus.Completed,
                HowLongToBeat = 65
            },

            // Divinity: Original Sin 2 (RPG)
            new Game
            {
                Id = 3,
                Name = "Divinity: Original Sin 2",
                Genre = GameGenre.RPG,
                Status = GameStatus.Completed,
                HowLongToBeat = 120
            },

            // Slay the Spire 2 (roguelike deckbuilder)
            new Game
            {
                Id = 4,
                Name = "Slay the Spire 2",
                Genre = GameGenre.Roguelite,
                Status = GameStatus.NotStarted,
                HowLongToBeat = 40
            },

            // Mewgenics (cat breeding roguelike)
            new Game
            {
                Id = 5,
                Name = "Mewgenics",
                Genre = GameGenre.Roguelite,
                Status = GameStatus.InProgress,
                HowLongToBeat = 25
            },

            // Clair Obscur: Expedition 33 (turn-based RPG)
            new Game
            {
                Id = 6,
                Name = "Clair Obscur: Expedition 33",
                Genre = GameGenre.RPG,
                Status = GameStatus.NotStarted,
                HowLongToBeat = 60
            },

            // Kingdom Come: Deliverance 2 (realistisk RPG)
            new Game
            {
                Id = 7,
                Name = "Kingdom Come: Deliverance 2",
                Genre = GameGenre.RPG,
                Status = GameStatus.InProgress,
                HowLongToBeat = 100
            }
        };
        public Task<Game> AddAsync(Game game)
        {
            _games.Add(game);
            return Task.FromResult(game);
        }

        public Task DeleteAsync(int id)
        {
            var gameToDelete = _games.FirstOrDefault(x=> x.Id == id);
            if (gameToDelete != null)
            {
                _games.Remove(gameToDelete);
            }
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Game>> GetAllAsync()
        {
            return Task.FromResult(_games.AsEnumerable());
        }

        public Task<Game?> GetByIdAsync(int id)
        {
            var game = _games.FirstOrDefault(x=> x.Id == id);
            return Task.FromResult(game);
        }

        public Task UpdateAsync(Game game)
        {
            var existing = _games.FirstOrDefault(x=> x.Id == game.Id);
            if(existing != null)
            {
                existing.Name = game.Name;
                existing.Genre = game.Genre;
                existing.Status = game.Status;
                existing.HowLongToBeat = game.HowLongToBeat;
            }
            return Task.CompletedTask;
        }
    }
}
