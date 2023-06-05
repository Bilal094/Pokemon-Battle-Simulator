using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    internal class Trainer
    {
        public List<Pokeball> belt = new List<Pokeball>();
        public string Name { get; set; }

        public Trainer(string name)
        {
            Name = name;
        }

        public Pokeball throw_ball(int count)
        {
            Pokeball thrownBall = belt[count];
            return thrownBall;
        }

        public void add_balls(Pokeball pokeball)
        {
            belt.Add(pokeball);
        }

        public List<Pokeball> get_belt()
        {
            return belt;
        }
    }
}
