namespace Kerem.MathGame ;

    public class GameEngine
    {
        private static readonly CalculationLogic CalculationLogic = new CalculationLogic();


        public int AdditionGame(int score)
        {
            Console.WriteLine("Select difficulty level:");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            int difficultyLevel = Convert.ToInt32(Console.ReadLine());
            bool correctAnswer;

            switch (difficultyLevel)
            {
                case 1:
                    correctAnswer = CalculationLogic.AdditionGameEasy();
                    if (correctAnswer)
                    {
                        Console.WriteLine("Correct answer!");
                        score++;
                        Console.WriteLine($"Your score is {score}");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect answer!");
                    }
                    break;
                case 2:
                    correctAnswer = CalculationLogic.AdditionGameMedium();
                    if (correctAnswer)
                    {
                        Console.WriteLine("Correct answer!");
                        score++;
                        Console.WriteLine($"Your score is {score}");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect answer!");
                    }
                    break;
                case 3:
                    correctAnswer = CalculationLogic.AdditionGameHard();
                    if (correctAnswer)
                    {
                        Console.WriteLine("Correct answer!");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect answer!");

                    }
                    break;
            }
            return score;
        }

        public int SubtractionGame(int score)
        {
            Console.WriteLine("Select difficulty level:");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            int difficultyLevel = Convert.ToInt32(Console.ReadLine());
            bool correctAnswer;

            switch (difficultyLevel)
            {
                case 1:
                    correctAnswer = CalculationLogic.SubtractionGameEasy();
                    if (correctAnswer)
                    {
                        Console.WriteLine("Correct answer!");
                        score++;
                        Console.WriteLine($"Your score is {score}");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect answer!");
                    }
                    break;
                case 2:
                    correctAnswer = CalculationLogic.SubtractionGameMedium();
                    if (correctAnswer)
                    {
                        Console.WriteLine("Correct answer!");
                        score++;
                        Console.WriteLine($"Your score is {score}");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect answer!");
                    }
                    break;
                case 3:
                    correctAnswer = CalculationLogic.SubtractionGameHard();
                    if (correctAnswer)
                    {
                        Console.WriteLine("Correct answer!");
                        score++;
                        Console.WriteLine($"Your score is {score}");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect answer!");
                    }
                    break;
            }
            return score;
        }

        public int MultiplicationGame(int score)
        {
            Console.WriteLine("Select difficulty level:");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            int difficultyLevel = Convert.ToInt32(Console.ReadLine());
            bool correctAnswer;

            switch (difficultyLevel)
            {
                case 1:
                    correctAnswer = CalculationLogic.MultiplicationGameEasy();
                    if (correctAnswer)
                    {
                        Console.WriteLine("Correct answer!");
                        score++;
                        Console.WriteLine($"Your score is {score}");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect answer!");
                    }
                    break;
                case 2:
                    correctAnswer = CalculationLogic.MultiplicationGameMedium();
                    if (correctAnswer)
                    {
                        Console.WriteLine("Correct answer!");
                        score++;
                        Console.WriteLine($"Your score is {score}");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect answer!");
                    }
                    break;
                case 3:
                    correctAnswer = CalculationLogic.MultiplicationGameHard();
                    if (correctAnswer)
                    {
                        Console.WriteLine("Correct answer!");
                        score++;
                        Console.WriteLine($"Your score is {score}");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect answer!");
                    }
                    break;
            }
            return score;
        }

        public int DivisionGame(int score)
        {
            Console.WriteLine("Select difficulty level:");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Medium");
            Console.WriteLine("3. Hard");
            int difficultyLevel = Convert.ToInt32(Console.ReadLine());
            bool correctAnswer;

            switch (difficultyLevel)
            {
                case 1:
                    correctAnswer = CalculationLogic.DivisionGameEasy();
                    if (correctAnswer)
                    {
                        Console.WriteLine("Correct answer!");
                        score++;
                        Console.WriteLine($"Your score is {score}");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect answer!");
                    }
                    break;
                case 2:
                    correctAnswer = CalculationLogic.DivisionGameMedium();
                    if (correctAnswer)
                    {
                        Console.WriteLine("Correct answer!");
                        score++;
                        Console.WriteLine($"Your score is {score}");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect answer!");
                    }
                    break;
                case 3:
                    correctAnswer = CalculationLogic.DivisionGameHard();
                    if (correctAnswer)
                    {
                        Console.WriteLine("Correct answer!");
                        score++;
                        Console.WriteLine($"Your score is {score}");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect answer!");
                    }
                    break;
            }
            return score;
        }
    }