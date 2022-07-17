namespace FallingRocks
{
    public class Dwarf
    {
        public Dwarf(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Representation = "(0)";
        }

        public int X { get; set; }
        public int Y { get; set; }
        public string Representation { get; set; }
        public bool HasBeenHit { get; set; } = false; 

        public void drawDwarf()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.Write(this.Representation);
        }

        public void moveDwarf()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                bool isRight = (pressedKey.Key == ConsoleKey.RightArrow);
                bool isLeft = (pressedKey.Key == ConsoleKey.LeftArrow);

                if (isRight && this.X + this.Representation.Length < Console.WindowWidth - 1)
                {
                    this.X++;
                }
                else if (isLeft && this.X > 0)
                {
                    this.X--;
                }
            }
        }

        public void DrawScorePanel()
        {
            Console.SetCursorPosition(0, Console.WindowHeight - Score.sizeOfScorePanel);
            for (int i = 0; i < Console.WindowWidth; ++i)
            {
                Console.Write('=');
            }
            Console.WriteLine("Your Score is: {0}", Score.GetScore());
        }

        public bool checkDwarfForCollision()
        {
            if (this.HasBeenHit)
            {
                EndGame();
                return true;
            }
            return false;
        }

        public static void EndGame()
        {
            Score.WriteToScorePanel();
        }
    }
}
