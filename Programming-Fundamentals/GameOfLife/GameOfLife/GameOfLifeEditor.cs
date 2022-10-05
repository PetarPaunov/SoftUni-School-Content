namespace GameOfLife
{
    public class GameOfLifeEditor : GameOfLifeBase
    {
        int cursorPositionX = 0;
        int cursorPositionY = 0;

        int cellPositionX = 0;
        int cellPositionY = 0;

        public GameOfLifeEditor(int x, int y)
            : base(x, y)
        {
        }

        public void Move(ConsoleKeyInfo key, int sizeOfBoard, int windowWidth, int windowHeight)
        {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (cellPositionY > 0)
                    {
                        Console.SetCursorPosition(cursorPositionX -= 1, cursorPositionY);
                        cellPositionY--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (cellPositionY < CurrentGeneration.GetLength(1) - 1)
                    {
                        Console.SetCursorPosition(cursorPositionX += 1, cursorPositionY);
                        cellPositionY++;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (cellPositionX < CurrentGeneration.GetLength(0) - 1)
                    {
                        Console.SetCursorPosition(cursorPositionX, cursorPositionY += 1);
                        cellPositionX++;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (cellPositionX > 0)
                    {
                        Console.SetCursorPosition(cursorPositionX, cursorPositionY -= 1);
                        cellPositionX--;
                    }
                    break;
                //Toggle the current cell state (0 = dead, 1 = alive)
                case ConsoleKey.Spacebar:
                    //Current cell is alive, turn it dead
                    if (CurrentGeneration[cellPositionX, cellPositionY] == 1)
                    {
                        CurrentGeneration[cellPositionX, cellPositionY] = 0;
                        Draw(sizeOfBoard, windowWidth, windowHeight);
                    }
                    //Current cell is dead, turn it alive
                    else
                    {
                        CurrentGeneration[cellPositionX, cellPositionY] = 1;
                        Draw(sizeOfBoard, windowWidth, windowHeight);
                    }
                    //Write the current cell and set the correct position to the cursor
                    if (cellPositionX >= 0 && cellPositionX < CurrentGeneration.GetLength(0))
                    {
                        Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                    }
                    break;
                case ConsoleKey.Enter:
                    ResetLife();
                    Draw(sizeOfBoard, windowWidth, windowHeight);
                    if (cellPositionX >= 0 && cellPositionX < CurrentGeneration.GetLength(0))
                    {
                        Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                    }
                    break;
            }
        }

        public override void DrawMenuPanel(int windowHeight, int windowWidth)
        {
            base.DrawMenuPanel(windowHeight, windowWidth);
            Console.WriteLine("[Arrow keys] to move             [Enter] Reset the life");
            Console.WriteLine("[Spacebar] Toggle cell           [Escape] Start menue ");
            Console.WriteLine("[Backspace] Starts/Stop the life");
        }

        private void ResetLife()
        {
            for (int row = 0; row < CurrentGeneration.GetLength(0); row++)
            {
                for (int col = 0; col < CurrentGeneration.GetLength(1); col++)
                {
                    CurrentGeneration[row, col] = 0;
                }
            }
        }
    }
}
