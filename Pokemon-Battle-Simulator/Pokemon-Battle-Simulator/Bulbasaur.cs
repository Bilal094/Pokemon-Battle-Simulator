using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur(string name) : base(name)
        {
            this.Name = name;
            this.Strength = "grass";
            this.Weakness = "fire";
        }

        public override void battle_cry()
        {
            Console.WriteLine("Bulbasaur does its battle cry: " + this.Name.ToUpper() + "!");
        }
    }
}
