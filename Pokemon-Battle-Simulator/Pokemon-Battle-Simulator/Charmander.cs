﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    // Pokemon Classes
    public class Charmander : Pokemon
    {
        public Charmander(string name) : base(name)
        {
            this.Name = name;
            this.Strength = "fire";
            this.Weakness = "water";
        }

        public override void battle_cry()
        {
            Console.WriteLine("Charmander does its battle cry: " + this.Name.ToUpper() + "!");
        }
    }
}
