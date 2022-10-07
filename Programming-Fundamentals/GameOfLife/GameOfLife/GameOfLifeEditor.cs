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

        public string Move(ConsoleKeyInfo key, int sizeOfBoard, int windowWidth, int windowHeight)
        {
            string generationToReturn = "";

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
                    }
                    //Current cell is dead, turn it alive
                    else
                    {
                        CurrentGeneration[cellPositionX, cellPositionY] = 1;
                    }
                    //Write the current cell and set the correct position to the cursor
                    if (cellPositionX >= 0 && cellPositionX < CurrentGeneration.GetLength(0))
                    {
                        Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                    }
                    generationToReturn = Draw(sizeOfBoard, windowWidth);
                    break; 
                case ConsoleKey.Enter:
                    ClearBoard();
                    generationToReturn = Draw(sizeOfBoard, windowWidth);
                    if (cellPositionX >= 0 && cellPositionX < CurrentGeneration.GetLength(0))
                    {
                        Console.SetCursorPosition(cursorPositionX, cursorPositionY);
                    }
                    break;
            }

            return generationToReturn;
        }

        public override void DrawMenuPanel(int windowWidth)
        {
            base.DrawMenuPanel(windowWidth);
            stringBuilder.AppendLine("[Arrow keys] to move             [Enter] Clear the board");
            stringBuilder.AppendLine("[Spacebar] Toggle cell           [Escape] Start menu");
            stringBuilder.AppendLine("[Backspace] Start/stop the life");
        }

        private void ClearBoard()
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
