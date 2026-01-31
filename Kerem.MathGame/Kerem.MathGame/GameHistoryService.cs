namespace Kerem.MathGame ;

    public class GameHistoryService
    {
        public void ViewGameHistory(List<GameHistory> gameHistories)
        {
            foreach (var gameHistory in gameHistories)
            {
                Console.WriteLine($"{gameHistory.PlayerName} - {gameHistory.Score}");
            }
        }
    }