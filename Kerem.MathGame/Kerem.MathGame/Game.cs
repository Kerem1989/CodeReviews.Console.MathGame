namespace Kerem.MathGame ;

    public class Game
    {
        private int score;

        private decimal gameLength;

        public int Score
        {
            get => score;
            set => score = value;
        }

        public decimal GameLength
        {
            get => gameLength;
            set => gameLength = value;
        }
    }