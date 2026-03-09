using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary.Domain.Enums;

namespace GameLibrary.Domain.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GameGenre Genre { get; set; }
        public GameStatus Status { get; set; }
        public double HowLongToBeat { get; set; }
    }
}
