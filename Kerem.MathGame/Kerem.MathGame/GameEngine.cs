namespace Kerem.MathGame ;

    public class GameEngine
    {
        private static Random random = new Random();
        
        public bool AdditionGameEasy()
        {
            Console.WriteLine("Welcome to the addition game!");
            int number1 = random.Next(100);
            int random2 = random.Next(100);
            Console.WriteLine($"What is {number1} + {random2} ?");
            int playerAnswer = Convert.ToInt32(Console.ReadLine());
            int correctAnswer = number1 + random2;
            return playerAnswer == correctAnswer;
        }
 
    }