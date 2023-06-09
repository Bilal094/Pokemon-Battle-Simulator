using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle_Simulator
{
    internal class Arena
    {
        // Fields
        public int round = 1;
        public Battle Battle { get; set; }

        public Trainer TrainerOne { get; set; }
        public Trainer TrainerTwo { get; set; }


        // Constructor for arena
        public Arena(Trainer trainerOne, Trainer trainerTwo)
        {
            this.TrainerOne = trainerOne;
            this.TrainerTwo = trainerTwo;
        }

        // Methods
        public void createBattle()
        {
            Battle battle = new Battle(this.TrainerOne, this.TrainerTwo);
            this.Battle = battle;
        }

        public void beginBattle()
        {
            Console.WriteLine($"Round {round}");
            // The 2 trainers throw their pokeballs off their belt
            Pokeball thrownBallOne = TrainerOne.throw_ball();
            Pokeball thrownBallTwo = TrainerTwo.throw_ball();

            // The 2 pokeballs are opened
            thrownBallOne.open_ball();
            thrownBallTwo.open_ball();
            round++;
            if (thrownBallOne != null && thrownBallTwo != null)
            {
                // The 2 pokemons do their battle cry
                thrownBallOne.Pokemon.battle_cry();
                thrownBallTwo.Pokemon.battle_cry();

                Trainer winner = Battle.comparePokemon(thrownBallOne, thrownBallTwo);
            }
        }

    }
}
