﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    internal class Trainer
    {
        //private int index;
        public List<Pokeball> belt = new List<Pokeball>();
        public string Name { get; set; }
        private Pokeball ThrownBall { get; set; }
        Random random = new Random();


        public Trainer(string name)
        {
            Name = name;
        }

        public Pokeball throw_ball()
        {
                if (belt.Count > 0)
            {
                // Pick a random pokeball
                int index = random.Next(belt.Count);
                ThrownBall = belt[index];
                return ThrownBall;
            } else
            {
                return null;

            }
        }

        public void create_balls(string name, int count)
        {
            if (count == 1)
            {
                belt.Add(new Pokeball(new Charmander(name, Pokemon.PokemonType.Fire, Pokemon.PokemonType.Water)));
                belt.Add(new Pokeball(new Charmander(name, Pokemon.PokemonType.Fire, Pokemon.PokemonType.Water)));
            }
            else if (count == 2)
            {
                belt.Add(new Pokeball(new Squirtle(name, Pokemon.PokemonType.Water, Pokemon.PokemonType.Grass)));
                belt.Add(new Pokeball(new Squirtle(name, Pokemon.PokemonType.Water, Pokemon.PokemonType.Grass)));
            }
            else if (count == 3)
            {
                belt.Add(new Pokeball(new Bulbasaur(name, Pokemon.PokemonType.Grass, Pokemon.PokemonType.Fire)));
                belt.Add(new Pokeball(new Bulbasaur(name, Pokemon.PokemonType.Grass, Pokemon.PokemonType.Fire)));
            }
        }

        public List<Pokeball> getBelt()
        {
            return this.belt;
        }

        public void removePokeball()
        {
            if (this.belt.Contains(ThrownBall)) {
                this.belt.Remove(ThrownBall);
            }
        }
    }
}
