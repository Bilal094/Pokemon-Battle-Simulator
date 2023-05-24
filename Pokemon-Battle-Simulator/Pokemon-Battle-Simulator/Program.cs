using System.Diagnostics;

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


            for(int i = 1; i <= 6; i++)
            {
                Console.WriteLine("Trainer "+ trainer1.Name +", what will you name charmander " + i + "? ...");
                
                string nameCharmander1 = Console.ReadLine();
                Charmander charmander1 = new Charmander(nameCharmander1, null, null);
                Pokeball pokeball1 = new Pokeball(charmander1);
                trainer1.add_balls(pokeball1);


                Console.WriteLine("Trainer " + trainer2.Name + ", what will you name charmander " + i + "? ...");
                string nameCharmander2 = Console.ReadLine();
                Charmander charmander2 = new Charmander(nameCharmander2, null, null);
                Pokeball pokeball2 = new Pokeball(charmander2);
                trainer2.add_balls(pokeball2);
            }

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Trainer " + trainer1.Name + "'s turn!");
                trainer1.throw_ball(i);
                //Thread.Sleep(2000);

                Console.WriteLine("Trainer " + trainer2.Name + "'s turn!");
                trainer2.throw_ball(i);
                //Thread.Sleep(1500);
            }
            Console.WriteLine("Wil je nog een keer spelen Y/N");
            string x = Console.ReadLine().ToUpper();
            answer = x == "Y" ? true : false;
        }
    }
}