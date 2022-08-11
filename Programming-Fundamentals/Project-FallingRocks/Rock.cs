namespace FallingRocks
{
    public class Rock
    {
        private Random random = new Random();
        private char[] Representation =
            new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };

        public Rock(int x)
        {
            this.X = x;
            this.Y = 0;
            this.Symbol = Representation[random.Next(0, Representation.Length)];
        }

        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; set; }
    }
}
