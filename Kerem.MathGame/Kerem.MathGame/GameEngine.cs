namespace Kerem.MathGame ;

    public class GameEngine
    {
        private static readonly CalculationLogic CalculationLogic = new CalculationLogic();


        public int AdditionGame(int score)
        {
            Console.WriteLine("Select difficulty level:");
            Console.WriteLine("1. Normal");
            Console.WriteLine("2. Hard");
            int difficultyLevel = int.TryParse(Console.ReadLine(), out difficultyLevel) ? difficultyLevel : 0;
            bool correctAnswer;

            switch (difficultyLevel)
            {
                case 1:
                    correctAnswer = CalculationLogic.AdditionGameNormal();
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
                    correctAnswer = CalculationLogic.AdditionGameHard();
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

        public int SubtractionGame(int score)
        {
            Console.WriteLine("Select difficulty level:");
            Console.WriteLine("1. Normal");
            Console.WriteLine("2. Hard");
            int difficultyLevel = int.TryParse(Console.ReadLine(), out difficultyLevel) ? difficultyLevel : 0;
            bool correctAnswer;

            switch (difficultyLevel)
            {
                case 1:
                    correctAnswer = CalculationLogic.SubtractionGameNormal();
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
            Console.WriteLine("1. Normal");
            Console.WriteLine("2. Hard");
            int difficultyLevel = int.TryParse(Console.ReadLine(), out difficultyLevel) ? difficultyLevel : 0;
            bool correctAnswer;

            switch (difficultyLevel)
            {
                case 1:
                    correctAnswer = CalculationLogic.MultiplicationGameNormal();
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
            Console.WriteLine("1. Normal");
            Console.WriteLine("2. Hard");
            int difficultyLevel = int.TryParse(Console.ReadLine(), out difficultyLevel) ? difficultyLevel : 0;
            bool correctAnswer;

            switch (difficultyLevel)
            {
                case 1:
                    correctAnswer = CalculationLogic.DivisionGameNormal();
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