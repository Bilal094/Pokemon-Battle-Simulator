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

        public void throw_ball(int count)
        {
            Pokeball thrownBall = belt[count];
            thrownBall.open_ball();
        }

        public void add_balls(Pokeball pokeball)
        {
            belt.Add(pokeball);
        }
    }
}
