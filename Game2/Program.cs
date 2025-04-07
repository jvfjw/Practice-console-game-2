using Game2;
internal class Program
{
    private static void Main(string[] args)
    {
        bool isRunning = true;
        string userInput;

        while (isRunning)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("Welcome to the city of progress, Lumina!\n" +
                             "1 - Start a new game\n" +
                             "2 - Load game\n" +
                             "3 - Exit");
            userInput = Console.ReadLine().Trim().ToLower();


            switch (userInput)
            {
                case "1":
                    Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Starting a new game...\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Enter your character's name:");
                    
                    string name = Console.ReadLine().Trim();
                    
                    Console.Clear();
                    
                    Console.WriteLine($"Welcome, {name}! GoodLuck making any progress...");
                               
                    Player player = new Player(name, Item.initialItems);
                    
                     Console.ForegroundColor = ConsoleColor.Green;
                    player.ShowInventory();
                        Console.WriteLine($"{player.name} stats:\n");
                    player.ShowStats();
                    
                    //Controller that manages the xp stats & level of the player
                    LevelController levelController = new LevelController(player);
                    


                    Console.WriteLine("Press any key to continue...");
                    
                    Console.ReadKey();
                    
                    break;                    
                case "2":
                    Console.WriteLine("Loading game...");

                    break;
                case "3":
                    Console.WriteLine("Exiting the game. Goodbye!");
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }


        }
    }
}



