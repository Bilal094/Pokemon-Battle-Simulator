using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    // Pokemon Classes
    public class Charmander
    {
        public string Name { get; set; }
        public string Strength { get; set; }
        public string Weakness { get; set; }


        public Charmander(string name, string strength, string weakness)
        {
            Name = name;
            Strength = strength;
            Weakness = weakness;
        }

        public void battle_cry()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Charmander does its battle cry 10 times: " + Name.ToUpper() + "!");
            }
        }
    }
}
