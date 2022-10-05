namespace GameOfLife
{
    public class GameOfLifeBuiltIn : GameOfLifeBase
    {
        public GameOfLifeBuiltIn(int x, int y)
            : base(x, y)
        {
        }

        public void GenerateField(string fileName, int windowWidth, int sizeOfBoard)
        {
            int[,] field = GetFieldAsTextFile(fileName, windowWidth, sizeOfBoard);

            for (int row = 0; row < X; row++)
            {
                for (int col = 0; col < Y; col++)
                {
                    CurrentGeneration[row, col] = field[row, col];
                }
            }
        }

        public void GenerateRandomLifeSeed()
        {
            Random random = new Random();

            for (int row = 0; row < X; row++)
            {
                for (int col = 0; col < Y; col++)
                {
                    if (random.Next(1, 101) < 70)
                    {
                        CurrentGeneration[row, col] = 0;
                    }
                    else
                    {
                        CurrentGeneration[row, col] = 1;
                    }
                }
            }
        }

        public override void DrawMenuPanel(int windowHeight, int windowWidth)
        {
            base.DrawMenuPanel(windowHeight, windowWidth);
            Console.WriteLine("[F1] Generate random cell state   [F2] Pulsar field");
            Console.WriteLine("[Backspace] Starts/Stop the life  [F3] Glider gun field");
            Console.WriteLine("[Escape] Start menue              [F4] Living forever field");
        }

        private int[,] GetFieldAsTextFile(string fileName, int windowWidth, int sizeOfBoard)
        {
            var textFile = File.ReadAllText(fileName).Split(",").ToArray();

            var field = new int[sizeOfBoard, windowWidth];

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1) - 1; col++)
                {
                    var curretRow = textFile[row].ToCharArray();

                    if (curretRow[col] == 'X')
                    {
                        field[row, col] = 1;
                    }
                }
            }

            return field;
        }
    }
}
