using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    internal class Battle
    {
        // Fields
        public Trainer TrainerOne { get; set; }
        public Trainer TrainerTwo { get; set; }
        public Trainer winner;

        // Constructor for battle
        public Battle(Trainer trainerOne, Trainer trainerTwo)
        {
            this.TrainerOne = trainerOne;
            this.TrainerTwo = trainerTwo;
        }

        public Trainer comparePokemon(Pokeball pokeball1, Pokeball pokeball2)
        {
            // The 2 pokemons are released from the pokeballs, now the comparison can begin
            Pokemon pokemonOne = pokeball1.Pokemon;
            Pokemon pokemonTwo = pokeball2.Pokemon;
            
            if (pokemonOne.Strength == pokemonTwo.Weakness)
            {
                Console.WriteLine($"{pokemonOne.Name} wins! {pokemonOne.Name} stays in battle and {pokemonTwo.Name} returns to its pokeball");
                Console.WriteLine("");
                winner = TrainerOne;
                TrainerTwo.removePokeball();
                return winner;
            } else if (pokemonTwo.Strength == pokemonOne.Weakness)
            {
                Console.WriteLine($"{pokemonTwo.Name} wins! {pokemonTwo.Name} stays in battle and {pokemonOne.Name} returns to its pokeball");
                Console.WriteLine("");
                winner = TrainerTwo;
                TrainerOne.removePokeball();
                return winner;
            }
            else
            {
                Console.WriteLine("Draw, both pokemons return to their pokeball");
                Console.WriteLine("");
                TrainerOne.removePokeball();
                TrainerTwo.removePokeball();

                return winner;
            }
        }
    }
}
