/* 1.The player start the game.
2. The player gives a name to a charmander.
3. The charmander does its battle cry for ten times.
4. The player can give a new name to the same charmander.
5. The charmander does its battle cry for ten times.
6. Repeat 4 and 5 until the player quits the game. */


// Main program
class Program
{
    static void Main(string[] args)
    {
        Charmander pokemon = new Charmander("Charmander");
        
        while (true)
        {
            Console.WriteLine("What will you name the charmander? Type 'n' to end the application");
            string newName = Console.ReadLine().ToLower();

            if (newName != "n")
            {
                pokemon.name = newName;
            }
            else
            {
                break;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Charmander does its battle cry 10 times: " + pokemon.name.ToUpper() + "!");
            }
        }
    }
}

// Pokemon Classes
class Charmander
{
    public string name;
    public string strength = "fire";
    public string weakness = "water";
    public Charmander(string defaultName)
    {
        name = defaultName;
    }
}