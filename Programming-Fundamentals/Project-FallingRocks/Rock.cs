namespace FallingRocks
{
    public class Rock
    {
        public Rock()
        {
            this.Representation = new char[] { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';' };
        }
        private Rock(int x, int y, char symbol)
        {
            this.X = x;
            this.Y = y;
            this.Symbol = symbol;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; set; }
        public char[] Representation { get; set; }

        public void CreateRocks(List<Rock> rocks, int RockProbability)
        {
            Random random = new Random();
            int count = Console.WindowWidth - 2;

            for (int i = 1; i <= count; ++i)
            {
                if (random.Next(0, 101) >= 100 - RockProbability)
                {
                    char rockSymbol = this.Representation[random.Next(0, this.Representation.Length)];
                    Rock newRock = new Rock(i, 0, rockSymbol);
                    rocks.Add(newRock);
                }
            }
        }

        public void drawRocks(List<Rock> rocks)
        {
            foreach (Rock rock in rocks)
            {
                Console.SetCursorPosition(rock.X, rock.Y);
                Console.Write(rock.Symbol);
            }
        }
    }
}
