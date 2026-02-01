namespace Kerem.MathGame ;

    public class GameHistory
    {
        private string playerName;
        
        private int score;
        
        private string elapsedTime;
        
        public string PlayerName { get => playerName; set => playerName = value; }
        
        public int Score { get => score; set => score = value; }
        
        public string ElapsedTime { get => elapsedTime; set => elapsedTime = value; }
    }