using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    public sealed class Pokeball
    {
        public string Name { get; set; }
        public readonly Pokemon Pokemon;

        public Pokeball(Pokemon _pokemon)
        {
            Pokemon = _pokemon;
            Name = Pokemon.Name;
        }

        public void open_ball()
        {
            Console.WriteLine(this.Name + " is released!");
            
        }
    }
}
