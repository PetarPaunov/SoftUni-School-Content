namespace GameOfLife
{
    public class GameOfLifeBase
    {
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

        public void Draw(int boardSize, int windowWidth, int windowHeight)
        {
            Console.CursorVisible = false;
            string[,] sceneBuffer = new string[boardSize, windowWidth];

            // Update Scene
            for (int row = 0; row < sceneBuffer.GetLength(0); row++)
            {
                for (int col = 0; col < sceneBuffer.GetLength(1); col++)
                {
                    if (CurrentGeneration[row, col] == 1)
                    {
                        sceneBuffer[row, col] = "◦";
                    }
                    else
                    {
                        sceneBuffer[row, col] = " ";
                    }
                }
            }

            // Draw Scene
            Console.SetCursorPosition(0, 0);

            for (int row = 0; row < sceneBuffer.GetLength(0); row++)
            {
                for (int col = 0; col < sceneBuffer.GetLength(1); col++)
                {
                    Console.Write(sceneBuffer[row, col]);
                }

                if (row >= boardSize - 1)
                {
                    break;
                }
                Console.WriteLine();
            }

            DrawMenuPanel(windowHeight, windowWidth);
            Console.CursorVisible = true;
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

        public virtual void DrawMenuPanel(int windowHeight, int windowWidth)
        {
            Console.SetCursorPosition(0, windowHeight - 5);
            Console.WriteLine(new String('=', windowWidth));
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
                    if (x + row < 0 || x + row >= X)
                    {
                        // Out of bounds
                        continue;
                    }
                    if (y + col < 0 || y + col >= Y)
                    {
                        // Out of bounds
                        continue;
                    }
                    if (x + row == x && y + col == y)
                    {
                        // Same Cell
                        continue;
                    }

                    // Add cells value to current live neighbour count
                    liveNeighbours += CurrentGeneration[x + row, y + col];
                }
            }

            return liveNeighbours;
        }
    }
}
