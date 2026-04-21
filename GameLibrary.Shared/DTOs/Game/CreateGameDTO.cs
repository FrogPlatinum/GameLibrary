using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary.Domain.Enums;

namespace GameLibrary.Shared.DTOs.Game
{
    public class CreateGameDTO
    {
        [Required, MaxLength(200)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public GameGenre Genre { get; set; }

        [Required]
        public GameStatus Status { get; set; }

        [Range(0,500)]
        public double HowLongToBeat { get; set; }
    }
}
