using System.Text;

namespace GameOfLife
{
    public class GameOfLifeBase
    {
        internal StringBuilder stringBuilder;
        public GameOfLifeBase(int x, int y)
        {
            X = x;
            Y = y;
            CurrentGeneration = new int[X, Y];
            NextGeneration = new int[X, Y];
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int[,] CurrentGeneration { get; set; }
        public int[,] NextGeneration { get; set; }

        public string Draw(int boardSize, int windowWidth)
        {
            string[,] sceneBuffer = new string[boardSize, windowWidth];

            // Update Scene
            for (int row = 0; row < sceneBuffer.GetLength(0); row++)
            {
                for (int col = 0; col < sceneBuffer.GetLength(1); col++)
                {
                    if (CurrentGeneration[row, col] == 1)
                    {
                        sceneBuffer[row, col] = "□";
                    }
                    else
                    {
                        sceneBuffer[row, col] = " ";
                    }
                }
            }

            stringBuilder = new StringBuilder();
            // Draw Scene
            for (int row = 0; row < sceneBuffer.GetLength(0); row++)
            {
                for (int col = 0; col < sceneBuffer.GetLength(1); col++)
                {
                    stringBuilder.Append(sceneBuffer[row, col]);
                }

                if (row >= boardSize - 1)
                {
                    break;
                }
                stringBuilder.AppendLine();
            }

            DrawMenuPanel(windowWidth);

            return stringBuilder.ToString().TrimEnd();
        }

        public void SpawnNextGeneration()
        {
            for (int row = 0; row < X; row++)
            {
                for (int col = 0; col < Y; col++)
                {
                    int liveNeighbours = CalculateLiveNeighbours(row, col);

                    if (CurrentGeneration[row, col] == 1 && liveNeighbours < 2)
                    {
                        NextGeneration[row, col] = 0;
                    }
                    else if (CurrentGeneration[row, col] == 1 && liveNeighbours > 3)
                    {
                        NextGeneration[row, col] = 0;
                    }
                    else if (CurrentGeneration[row, col] == 0 && liveNeighbours == 3)
                    {
                        NextGeneration[row, col] = 1;
                    }
                    else
                    {
                        NextGeneration[row, col] = CurrentGeneration[row, col];
                    }
                }
            }

            TransferNextGenerations();
        }

        public virtual void DrawMenuPanel(int windowWidth)
        {
            stringBuilder.AppendLine(new String('=', windowWidth));
        }

        private void TransferNextGenerations()
        {
            for (int row = 0; row < X; row++)
            {
                for (int col = 0; col < Y; col++)
                {
                    CurrentGeneration[row, col] = NextGeneration[row, col];
                }
            }
        }

        private int CalculateLiveNeighbours(int x, int y)
        {
            // Calculate live neighours
            int liveNeighbours = 0;

            for (int row = -1; row <= 1; row++)
            {
                for (int col = -1; col <= 1; col++)
                {
                    if (IsOutOfBoundariesOrSameCell(x, y, row, col))
                    {
                        continue;
                    }

                    // Add cells value to current live neighbour count
                    liveNeighbours += CurrentGeneration[x + row, y + col];
                }
            }

            return liveNeighbours;
        }

        private bool IsOutOfBoundariesOrSameCell(int x, int y, int row, int col)
        {
            if (x + row < 0 || x + row >= X)
            {
                // Out of boundaries
                return true;
            }
            if (y + col < 0 || y + col >= Y)
            {
                // Out of boundaries
                return true;
            }
            if (x + row == x && y + col == y)
            {
                // Same cell
                return true;
            }

            return false;
        }
    }
}
