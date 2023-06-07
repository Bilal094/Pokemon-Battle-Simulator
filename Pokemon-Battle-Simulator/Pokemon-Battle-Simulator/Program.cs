using System.Diagnostics;
using System.Linq.Expressions;

namespace Pokemon_Battle_Simulator;
public class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        bool answer = true;
        while (answer)
        {
            Console.WriteLine("Name trainer 1 ...");
            string newName = Console.ReadLine().ToLower();
            Trainer trainer1 = new Trainer(newName);

            Console.WriteLine("Name trainer 2 ...");
            newName = Console.ReadLine().ToLower();
            Trainer trainer2 = new Trainer(newName);


            for(int i = 1; i <= 3; i++)
            {
                // Trainer 1 names his pokemon
                Console.WriteLine($"Trainer 1, what will you name pokemon set {i}? ...");
                string namePokemon = Console.ReadLine();
                trainer1.create_balls(namePokemon, i);

                // Trainer 2 names his pokemon
                Console.WriteLine($"Trainer 2, what will you name pokemon set {i}? ...");
                namePokemon = Console.ReadLine();
                trainer2.create_balls(namePokemon, i);
            }

            // Creation of the arena after the trainers were made
            Arena arena = new Arena(trainer1, trainer2);

            // Method creates a battle, which returns a battle object and the battle object goes into the other method
            
            arena.createBattle();

            Console.WriteLine("");
            Console.WriteLine("Battle " + arena.BattleCount);
            while (trainer1.belt.Count > 0 || trainer2.belt.Count > 0)
            {
                arena.beginBattle();
                if (trainer1.belt.Count == 0 || trainer2.belt.Count == 0)
                {
                    break;
                }
            }

            // End game
            Console.WriteLine("Continue playing? Y/N");
            string replay = Console.ReadLine().ToUpper();
            if (replay == "N")
            {
                break;
            } else if (replay == "Y")
            {
                arena.updateBattle();
                arena.BattleCount = arena.updateBattle();
            }

        }
    }
}