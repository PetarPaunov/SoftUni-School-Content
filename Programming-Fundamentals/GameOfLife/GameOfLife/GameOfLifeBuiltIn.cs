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
                    CurrentGeneration[row, col] = random.Next(0, 2);
                }
            }
        }

        public override void DrawMenuPanel(int windowWidth)
        {
            base.DrawMenuPanel(windowWidth);
            stringBuilder.AppendLine("[F1] Generate random cell state   [F2] Pulsar field");
            stringBuilder.AppendLine("[Backspace] Start/stop the life   [F3] Glider gun field");
            stringBuilder.AppendLine("[Escape] Start menu               [F4] Living forever field");
        }

        private int[,] GetFieldAsTextFile(string fileName, int windowWidth, int sizeOfBoard)
        {
            string[] textFile = File.ReadAllText(fileName).Split(",").ToArray();

            int[,] field = new int[sizeOfBoard, windowWidth];

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1) - 1; col++)
                {
                    char[] currentRow = textFile[row].ToCharArray();

                    if (currentRow[col] == 'X')
                    {
                        field[row, col] = 1;
                    }
                }
            }

            return field;
        }
    }
}
