namespace FallingRocks
{
    public class Player
    {
        private bool maxRightLength
            => this.X + this.Representation.Length < Console.WindowWidth - 1;

        public Player(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Representation = "(0)";
        }

        public int X { get; set; }
        public int Y { get; set; }
        public string Representation { get; set; }
        public bool HasBeenHit { get; set; } = false; 

        public void Draw()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.Write(this.Representation);
        }

        public void Move()
        {
            if (Console.KeyAvailable) 
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();

                // Loop until the Console.KeyAvailable buffer is cleared
                ClearKeyAvailableBuffer();

                bool isRight = pressedKey.Key == ConsoleKey.RightArrow;
                bool isLeft = pressedKey.Key == ConsoleKey.LeftArrow;

                if (isRight && maxRightLength)
                {
                    this.X++;
                }
                else if (isLeft && this.X > 0)
                {
                    this.X--;
                }
            }
        }

        private void ClearKeyAvailableBuffer()
        {
            while (Console.KeyAvailable)
            {
                Console.ReadKey();
            }
        }
    }
}
