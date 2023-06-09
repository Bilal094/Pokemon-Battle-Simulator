using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    public abstract class Pokemon
    {
        public enum PokemonType
        {
            Fire,
            Water,
            Grass,
        }
        public string Name { get; protected set; }
        protected internal PokemonType Strength { get; protected set; }
        protected internal PokemonType Weakness { get; protected set; }

        public Pokemon(string name, PokemonType strength, PokemonType weakness)
        {
            Name = name;
            Strength = strength;
            Weakness = weakness;
        }
        public abstract void battle_cry();
    }
}
