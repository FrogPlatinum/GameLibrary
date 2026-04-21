using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary.Domain.Enums;

namespace GameLibrary.Shared.DTOs
{
    public class GameDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Unamed Game DTO";
        public GameGenre Genre { get; set; } = GameGenre.RPG;
        public GameStatus Status { get; set; } = GameStatus.NotStarted;
        public double HowLongToBeat { get; set; } = 1;
    }
}
