
namespace Kerem.MathGame ;

    public class Game
    {
        private int score;

        private int gameLength;


        public Game(int score, int gameLength)
        {
            this.score = score;
            this.gameLength = gameLength;
        }

        public int Score
        {
            get => score;
            set => score = value;
        }

        public int GameLength
        {
            get => gameLength;
            set => gameLength = value;
        }
    }