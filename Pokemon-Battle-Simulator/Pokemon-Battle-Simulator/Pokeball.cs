﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    public class Pokeball
    {
        public string Name { get; set; }
        public Pokemon Pokemon { get; set; }

        public Pokeball(Pokemon _pokemon)
        {
            Pokemon = _pokemon;
            Name = Pokemon.Name;
        }

        public void open_ball()
        {
            Console.WriteLine(this.Name + " is released!");
            
        }

        public void close_ball()
        {
            Console.WriteLine(this.Name + " returns to its pokeball...");
        }
    }
}
