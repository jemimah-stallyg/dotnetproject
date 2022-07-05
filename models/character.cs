using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.rpg.Models
{
    public class character
    {
        public int id { get; set; }

        public string Name { get; set; } = "Jemimah";

        public int Hitpoints { get; set; } = 100;

        public int Defense { get; set; } = 10;

        public int Intelligence { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.knight;
    }
}