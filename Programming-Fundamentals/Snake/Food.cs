namespace SnakeGame
{
    public class Food
    {
        private static char[] foodSymbols = new char[] { '#', '@', '%', '*', '&' };

        public Food(int windowHeight, int windowWidth)
        {
            Random random = new Random();

            this.XCoordinate = random.Next(2, windowHeight);
            this.YCoordinate = random.Next(2, windowWidth);

            this.Symbol = foodSymbols[random.Next(0, foodSymbols.Length)];
        }

        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public char Symbol { get; set; }
    }
}