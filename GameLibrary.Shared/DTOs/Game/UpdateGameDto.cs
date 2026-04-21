using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary.Domain.Enums;

namespace GameLibrary.Shared.DTOs.Game
{
    public class UpdateGameDto
    {
        [MaxLength(200)]
        public string? Name { get; set; }
        public GameGenre? Genre { get; set; }
        public GameStatus? Status { get; set; }
        public double? HowLongToBeat { get; set; }
    }
}
