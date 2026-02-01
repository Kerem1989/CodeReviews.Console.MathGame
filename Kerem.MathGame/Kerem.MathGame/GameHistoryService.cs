namespace Kerem.MathGame ;

    public class GameHistoryService
    {
        public void ViewGameHistory(List<GameHistory> gameHistories)
        {
            foreach (var gameHistory in gameHistories)
            {
                Console.WriteLine($"The player {gameHistory.PlayerName} scored {gameHistory.Score} points and it took {gameHistory.ElapsedTime} seconds.");
            }
        }
    }