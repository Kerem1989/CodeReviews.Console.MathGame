namespace Kerem.MathGame ;

    public class UserMenu
    {
        private static readonly GameEngine gameEngine = new GameEngine();
        private static readonly GameHistory gameHistory = new GameHistory();
        public void ShowMenu()
        {
            Player player = new Player();
            Console.WriteLine("Please enter your name:");
            player.Name = Console.ReadLine();
            Console.WriteLine($"Welcome {player.Name}");
            int rounds = 0;

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Start New Game");
                Console.WriteLine("2. View Game History");
                Console.WriteLine("3. Game Rules");
                Console.WriteLine("4. Exit");
                Console.Write("Please select an option (1-4): ");
                
                int choice = Convert.ToInt32(Console.ReadLine());

                
                switch (choice)
                {
                    case 1:
                    {

                        bool correctAnswer = gameEngine.AdditionGameEasy();
                        if (correctAnswer)
                        {
                            Console.WriteLine("You won!");
                        }
                        else
                        {
                            Console.WriteLine("You lost!");
                        }
                        break;
                    }
                    case 2:
                    {
                        // view game history
                        break;
                    }
                    case 3:
                    {
                        // view game rules
                        break;
                    }
                    case 4:
                    {
                        // exit game
                        return;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid option");
                        break;
                    }
                }
            }
        }
    }