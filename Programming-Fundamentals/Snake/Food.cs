namespace Snake
{
    public class Food
    {
        private Random random;
        private char[] foodSymbols;

        public Food(int windowHeight, int windowWidth)
        {
            this.foodSymbols = new char[] { '#', '@', '%', '*', '&' };
            this.random = new Random();

            this.XFoodCoordinate = random.Next(1, windowHeight);
            this.YFoodCoordinate = random.Next(1, windowWidth);

            this.FoodSymbol = this.foodSymbols[random.Next(0, this.foodSymbols.Length)];
        }

        public int XFoodCoordinate { get; set; }
        public int YFoodCoordinate { get; set; }
        public char FoodSymbol { get; set; }
    }
}