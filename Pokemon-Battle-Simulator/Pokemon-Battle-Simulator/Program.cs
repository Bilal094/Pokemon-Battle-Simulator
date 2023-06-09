using System.Diagnostics;
using System.Linq.Expressions;

namespace Pokemon_Battle_Simulator;
public class Program
{
    static void Main(string[] args)
    {
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
            arena.createBattle();

            while (trainer1.belt.Count > 0 || trainer2.belt.Count > 0)
            {
                arena.beginBattle();
                if (trainer2.belt.Count == 0)
                {
                    Console.WriteLine($"Trainer {trainer1.Name} wins with {Battle.trainer1} points");
                    break;
                } else if (trainer1.belt.Count == 0)
                {
                    Console.WriteLine($"Trainer {trainer2.Name} wins with {Battle.trainer2} points");
                    break;
                }
            }

            // End game
            Console.WriteLine("Continue playing? Y/N");
            string replay = Console.ReadLine().ToUpper();
            if (replay == "N")
            {
                break;
            }
        }
    }
}