using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    public class Pokeball
    {
        public string Name { get; set; }
        public Charmander Pokemon { get; set; }

        public Pokeball(Charmander charmander)
        {
            Pokemon = charmander;
            Name = Pokemon.Name;
        }

        public void open_ball()
        {
            Console.WriteLine(this.Name + " is released!");
            Console.WriteLine(this.Name + " does its battle cry: " + this.Name.ToUpper() + "!");
            Console.WriteLine(this.Name + " returns to its pokeball...");
        }
    }
}
