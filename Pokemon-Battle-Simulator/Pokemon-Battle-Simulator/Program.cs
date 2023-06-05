using System.Diagnostics;

namespace Pokemon_Battle_Simulator;
public class Program
{
    static void Main(string[] args)
    {
        Pokemon pokemonType(string type, string name)
        {
            switch (type.ToLower())
            {
                case "f":
                    Pokemon charmander = new Charmander(name);
                    return charmander;
                case "g":
                    Pokemon bulbasaur = new Bulbasaur(name);
                    return bulbasaur;
                case "w":
                    Pokemon squirtle = new Squirtle(name);
                    return squirtle;
                default:
                    Console.WriteLine("That is not a valid option");
                    charmander = new Charmander(name);
                    return charmander;
            }
        }

        bool answer = true;
        while (answer)
        {
            Console.WriteLine("Name trainer 1 ...");
            string newName = Console.ReadLine().ToLower();
            Trainer trainer1 = new Trainer(newName);

            Console.WriteLine("Name trainer 2 ...");
            newName = Console.ReadLine().ToLower();
            Trainer trainer2 = new Trainer(newName);


            for(int i = 1; i <= 6; i++)
            {
                // Trainer 1 names his pokemon
                Console.WriteLine("Trainer 1, what will you name pokemon " + i + "? ...");
                string namePokemon = Console.ReadLine();

                // Trainer 1 chooses his pokemon type
                Console.WriteLine("What type is that pokemon? Choose between: f (fire), g (grass), w (water)");
                string typePokemon = Console.ReadLine();

                // Create variable for pokemon, create pokeball and add it to the trainers belt
                Pokemon pokemon = pokemonType(typePokemon, namePokemon);
                trainer1.add_balls(new Pokeball(pokemon));

                // Trainer 2 names his pokemon
                Console.WriteLine("Trainer 2, what will you name pokemon " + i + "? ...");
                namePokemon = Console.ReadLine();

                // Trainer 2 chooses his pokemon type
                Console.WriteLine("What type is that pokemon? Choose between: f (fire), g (grass), w (water)");
                typePokemon = Console.ReadLine();

                // Create variable for pokemon, create pokeball and add it to the trainers belt
                pokemon = pokemonType(typePokemon, namePokemon);
                trainer2.add_balls(new Pokeball(pokemon));
            }

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Trainer 1 throws his pokeball..");
                Pokeball pokeball = trainer1.throw_ball(i);
                pokeball.open_ball();
                pokeball.Pokemon.battle_cry();
                pokeball.close_ball();

                Console.WriteLine("Trainer 2 throws his pokeball..");
                pokeball = trainer2.throw_ball(i);
                pokeball.open_ball();
                pokeball.Pokemon.battle_cry();
                pokeball.close_ball();

                Console.WriteLine("");
            }

            // End game
            Console.WriteLine("Continue playing? Y/N");
            string x = Console.ReadLine().ToUpper();
            answer = x == "Y" ? true : false;
        }
    }
}