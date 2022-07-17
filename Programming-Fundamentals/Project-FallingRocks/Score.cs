namespace FallingRocks
{
    public class Score
    {
        private static int score = 0;
        public const int sizeOfScorePanel = 10;
        public static void AddToScore(int points)
        {
            score += points;
        }
        public static void DeductScore(int points)
        {
            score -= points;
        }
        public static void SetScore(int scorePoints)
        {
            score = scorePoints;
        }
        public static int GetScore()
        {
            return score;
        }
        public static void WriteToScorePanel()
        {
            Console.SetCursorPosition(0, Console.WindowHeight - sizeOfScorePanel + 2);
            Console.WriteLine("GAME OVER");
        }
    }

}
