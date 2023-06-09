using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    public class Squirtle : Pokemon
    {
        public Squirtle(string name, PokemonType strength, PokemonType weakness) : base(name, strength, weakness)
        {
            this.Name = name;
            this.Strength = strength;
            this.Weakness = weakness;
        }

        public override void battle_cry()
        {
            Console.WriteLine("Squirtle does its battle cry: " + this.Name.ToUpper() + "!");
        }
    }
}
