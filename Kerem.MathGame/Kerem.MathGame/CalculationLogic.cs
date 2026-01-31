namespace Kerem.MathGame ;

    public class CalculationLogic
    {
        private static Random random = new Random();
        
        public bool AdditionGameEasy()
        {
            Console.WriteLine("Welcome to the addition game on easy level!");
            int number1 = random.Next(100);
            int number2 = random.Next(100);
            Console.WriteLine($"What is {number1} + {number2} ?");
            int playerAnswer = Convert.ToInt32(Console.ReadLine());
            int correctAnswer = number1 + number2;
            return playerAnswer == correctAnswer;
        }

        public bool AdditionGameMedium()
        {
            Console.WriteLine("Welcome to the addition game on medium level!");
            int number1 = random.Next(100);
            int number2 = random.Next(100);
            int number3 = random.Next(100);
            Console.WriteLine($"What is {number1} + {number2} + {number3} ?");
            int playerAnswer = Convert.ToInt32(Console.ReadLine());
            int correctAnswer = number1 + number2;
            return playerAnswer == correctAnswer;
        }
        
        public bool AdditionGameHard()
        {
            Console.WriteLine("Welcome to the addition game on hard level!");
            int number1 = random.Next(100);
            int number2 = random.Next(100);
            int number3 = random.Next(100);
            int number4 = random.Next(100);
            Console.WriteLine($"What is {number1} + {number2} + {number3} + {number4} ?");
            int playerAnswer = Convert.ToInt32(Console.ReadLine());
            int correctAnswer = number1 + number2;
            return playerAnswer == correctAnswer;
        }

        public bool SubtractionGameEasy()
        {
            Console.WriteLine("Welcome to the subtraction game on easy level!");
            int number1 = random.Next(100);
            int number2 = random.Next(100);
            Console.WriteLine($"What is {number1} - {number2} ?");
            int playerAnswer = Convert.ToInt32(Console.ReadLine());
            int correctAnswer = number1 - number2;
            return playerAnswer == correctAnswer;
        }
        
        public bool SubtractionGameMedium()
        {
            Console.WriteLine("Welcome to the subtraction game on medium level!");
            int number1 = random.Next(100);
            int number2 = random.Next(100);
            int number3 = random.Next(100);
            Console.WriteLine($"What is {number1} - {number2} - {number3} ?");
            int playerAnswer = Convert.ToInt32(Console.ReadLine());
            int correctAnswer = number1 - number2 - number3;
            return playerAnswer == correctAnswer;
        }

        public bool SubtractionGameHard()
        {
            Console.WriteLine("Welcome to the subtraction game on hard level!");
            int number1 = random.Next(100);
            int number2 = random.Next(100);
            int number3 = random.Next(100);
            int number4 = random.Next(100);
            Console.WriteLine($"What is {number1} - {number2} - {number3} - {number4} ?");
            int playerAnswer = Convert.ToInt32(Console.ReadLine());
            int correctAnswer = number1 - number2 - number3 - number4;
            return playerAnswer == correctAnswer;
        }
        
        public bool MultiplicationGameEasy()
        {
            Console.WriteLine("Welcome to the multiplication game on easy level!");
            int number1 = random.Next(10);
            int number2 = random.Next(10);
            Console.WriteLine($"What is {number1} * {number2} ?");
            int playerAnswer = Convert.ToInt32(Console.ReadLine());
            int correctAnswer = number1 * number2;
            return playerAnswer == correctAnswer;
        }

        public bool MultiplicationGameMedium()
        {
            Console.WriteLine("Welcome to the multiplication game on medium level!");
            int number1 = random.Next(10);
            int number2 = random.Next(10);
            int number3 = random.Next(10);
            Console.WriteLine($"What is {number1} * {number2} * {number3} ?");
            int playerAnswer = Convert.ToInt32(Console.ReadLine());
            int correctAnswer = number1 * number2 * number3;
            return playerAnswer == correctAnswer;
        }

        public bool MultiplicationGameHard()
        {
            Console.WriteLine("Welcome to the multiplication game on hard level!");
            int number1 = random.Next(10);
            int number2 = random.Next(10);
            int number3 = random.Next(10);
            int number4 = random.Next(10);
            Console.WriteLine($"What is {number1} * {number2} * {number3} * {number4} ?");
            int playerAnswer = Convert.ToInt32(Console.ReadLine());
            int correctAnswer = number1 * number2 * number3 * number4;
            return playerAnswer == correctAnswer;
        }

        public bool DivisionGameEasy()
        {
            Console.WriteLine("Welcome to the division game on easy level!");
            int number1 = random.Next(1, 100);
            int number2 = random.Next(1, 100);
            do
            {
                number1 = random.Next(1, 100);
                number2 = random.Next(1, 100);
            } while (number1 % number2 != 0);
            Console.WriteLine($"What is {number1} / {number2} ?");
            int playerAnswer = Convert.ToInt32(Console.ReadLine());
            int correctAnswer = number1 / number2;
            return playerAnswer == correctAnswer;
        }

        public bool DivisionGameMedium()
        {
            Console.WriteLine("Welcome to the division game on medium level!");
            int number1 = random.Next(1, 100);
            int number2 = random.Next(1, 100);
            int number3 = random.Next(1, 100);
            Console.WriteLine($"What is {number1} / {number2} / {number3} ?");
            int playerAnswer = Convert.ToInt32(Console.ReadLine());
            int correctAnswer = number1 / number2 / number3;
            return playerAnswer == correctAnswer;
        }

        public bool DivisionGameHard()
        {
            Console.WriteLine("Welcome to the division game on hard level!");
            int number1 = random.Next(1, 100);
            int number2 = random.Next(1, 100);
            int number3 = random.Next(1, 100);
            int number4 = random.Next(1, 100);
            Console.WriteLine($"What is {number1} / {number2} / {number3} / {number4} ?");
            int playerAnswer = Convert.ToInt32(Console.ReadLine());
            int correctAnswer = number1 / number2 / number3 / number4;
            return playerAnswer == correctAnswer;
        }

    }