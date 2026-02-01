using System.Diagnostics;

namespace Kerem.MathGame ;

    public class UserMenu
    {
        private static readonly GameHistory gameHistory = new GameHistory();
        private static readonly Game game = new Game(0, 5);
        private static readonly GameEngine gameEngine = new GameEngine();
        private static List<GameHistory> _gameHistories = new List<GameHistory>();
        private static readonly GameHistoryService gameHistoryService = new GameHistoryService();
        private static readonly GameRules gameRules = new GameRules();
        private static readonly Stopwatch stopwatch = new Stopwatch();
        bool runProgram = true;
        
        public void ShowMenu()
        {
            Player player = new Player();
            Console.WriteLine("Please enter your name:");
            player.Name = Console.ReadLine();
            Console.WriteLine($"Welcome {player.Name}");
            int rounds = game.GameLength;
            int score = game.Score;
            
            while (runProgram)
            {
                stopwatch.Reset();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Start New Game");
                Console.WriteLine("2. View Game History");
                Console.WriteLine("3. Game Rules");
                Console.WriteLine("4. Exit");
                Console.Write("Please select an option (1-4): ");
                
                int choice = int.TryParse(Console.ReadLine(), out choice) ? choice : 0;
                
                switch (choice)
                {
                    case 1:
                    {
                        stopwatch.Start();
                        rounds = game.GameLength;
                        score = game.Score;
                        while (rounds > 0)
                        {
                            Console.WriteLine("Please select a math operation:");
                            Console.WriteLine("1. Addition");
                            Console.WriteLine("2. Subtraction");
                            Console.WriteLine("3. Multiplication");
                            Console.WriteLine("4. Division");
                            int operation = int.TryParse(Console.ReadLine(), out operation) ? operation : 0;
                            switch (operation)
                            {
                                case 1:
                                    score = gameEngine.AdditionGame(score);
                                    rounds--;
                                    Console.WriteLine($"Round {rounds}");
                                    break;
                                case 2:
                                    score = gameEngine.SubtractionGame(score);
                                    rounds--;
                                    Console.WriteLine($"Round {rounds}");
                                    break;
                                case 3:
                                    score = gameEngine.MultiplicationGame(score);
                                    rounds--;
                                    Console.WriteLine($"Round {rounds}");
                                    break;
                                case 4:
                                    score = gameEngine.DivisionGame(score);
                                    rounds--;
                                    Console.WriteLine($"Round {rounds}");
                                    break;
                                default:
                                    Console.WriteLine("Invalid option");
                                    rounds--;
                                    Console.WriteLine($"Round {rounds}");
                                    break;
                            }
                        }
                        Console.WriteLine($"Game over! Your final score is {score}");
                        stopwatch.Stop();
                        TimeSpan ts = stopwatch.Elapsed;
                        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                            ts.Hours, ts.Minutes, ts.Seconds,
                            ts.Milliseconds / 10);
                        Console.WriteLine($"Elapsed time: {elapsedTime}");
                        _gameHistories.Add(new GameHistory
                        {
                            PlayerName = player.Name,
                            Score = score,
                            ElapsedTime = elapsedTime
                        });
                        break;
                    }
                    case 2:
                    {
                        gameHistoryService.ViewGameHistory(_gameHistories);
                        break;
                    }
                    case 3:
                    {
                        gameRules.ViewGameRules();
                        break;
                    }
                    case 4:
                    {
                        runProgram = false;
                        Console.WriteLine("Goodbye!");
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