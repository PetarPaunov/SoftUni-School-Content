using System.Text;
using SnakeGame;

Console.OutputEncoding = Encoding.Unicode;

const int BoardWidth = 80;
const int BoardHeight = 30;

const int ScorePanelTextPosition = 2;
const int BordersOffset = 4;

SetWindowProperties();

Position[] directions = new Position[]
{
    new Position(0, 2), // right
    new Position(0, -2), // left
    new Position(1, 0), // down
    new Position(-1, 0), // up
};

int playerPoints = 0;
int startingDirection = (int)Direction.Right;

DrawBorders();

Food food = null;
Snake snake = new Snake(BordersOffset, BoardHeight, BoardWidth);

DrawNewFood();

PlayGame();

void SetWindowProperties()
{
    Console.CursorVisible = false;
    Console.BufferHeight = Console.WindowHeight = BoardHeight;
    Console.BufferWidth = Console.WindowWidth = BoardWidth;
}

void DrawBorders()
{
    StringBuilder stringBuilder = new StringBuilder();

    Console.ForegroundColor = ConsoleColor.Cyan;

    char horizontalBordersPiece = '█';
    string verticalBordersPiece = "██";

    string horizontalSide = new string(horizontalBordersPiece, BoardWidth - BordersOffset + 2);
    string emptyHorizontalSide = new string(' ', BoardWidth - BordersOffset);

    stringBuilder.AppendLine
        ($"{horizontalBordersPiece}{horizontalSide}{horizontalBordersPiece}");

    for (int row = 0; row < BoardHeight - BordersOffset; row++)
    {
        stringBuilder.AppendLine
            ($"{verticalBordersPiece}{emptyHorizontalSide}{verticalBordersPiece}");
    }

    stringBuilder.AppendLine
        ($"{horizontalBordersPiece}{horizontalSide}{horizontalBordersPiece}");

    string borders = stringBuilder.ToString().TrimEnd();
    Console.WriteLine(borders);
}

void DrawNewFood()
{
    Console.ForegroundColor = ConsoleColor.Yellow;

    if (food != null)
    {
        int currentYFoodCoordinate = food.YCoordinate;
        int currentXFoodCoordinate = food.XCoordinate;

        // Delete food on the current position
        Console.SetCursorPosition(currentYFoodCoordinate, currentXFoodCoordinate);
        Console.Write(" ");
    }

    GenerateNewFood();

    // Draw food on the new position
    Console.SetCursorPosition(food.YCoordinate, food.XCoordinate);
    Console.Write(food.Symbol);
}

void GenerateNewFood()
{
    food = new Food(BoardHeight - BordersOffset, BoardWidth - BordersOffset);

    while (FoodIsInSnake())
    {
        food = new Food(BoardHeight - BordersOffset, BoardWidth - BordersOffset);
    }
}

bool FoodIsInSnake()
        => snake.Elements.Any(x => x.col == food.YCoordinate ||
                             x.row == food.XCoordinate);

void PlayGame()
{
    while (true)
    {
        DrawSnake();

        if (Console.KeyAvailable)
        {
            ChangeSnakeDirection();
        }

        GenerateSnakeNewHead();

        string endMessage = GetEndGameMessage();
        if (endMessage != null)
        {
            WriteEndGameMessage(endMessage);
            break;
        }

        snake.Elements.Enqueue(snake.NewHeadPosition);

        if (SnakeEatsFood())
        {
            DrawNewFood();
            ModifyPlayerAndSnake();
        }
        else
        {
            MoveSnake();
        }

        DrawSnakeHead();
        DrawScorePanel();

        Thread.Sleep(snake.Speed);
    }
}

void DrawSnake()
{
    foreach (Position position in snake.Elements)
    {
        Console.SetCursorPosition(position.col, position.row);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("□");
    }
}

void ChangeSnakeDirection()
{
    ConsoleKeyInfo userInput = Console.ReadKey();
    DetermineDirection(userInput.Key);
}

void DetermineDirection(ConsoleKey userInputKey)
{
    if (userInputKey == ConsoleKey.LeftArrow &&
        startingDirection != (int)Direction.Right)
    {
        startingDirection = (int)Direction.Left;
    }
    else if (userInputKey == ConsoleKey.RightArrow &&
        startingDirection != (int)Direction.Left)
    {
        startingDirection = (int)Direction.Right;
    }
    else if (userInputKey == ConsoleKey.UpArrow &&
        startingDirection != (int)Direction.Down)
    {
        startingDirection = (int)Direction.Up;
    }
    else if (userInputKey == ConsoleKey.DownArrow &&
        startingDirection != (int)Direction.Up)
    {
        startingDirection = (int)Direction.Down;
    }
}

void GenerateSnakeNewHead()
{
    Position snakeHeadPosition = snake.Elements.Last();
    Position nextDirection = directions[startingDirection];

    snake.NewHeadPosition = new Position(snakeHeadPosition.row + nextDirection.row,
        snakeHeadPosition.col + nextDirection.col);
}

string GetEndGameMessage()
{
    bool isBitten = snake.IsBitten();
    bool isOutOfBorders = snake.IsOutOfBorders(BoardHeight, BoardWidth, BordersOffset);

    if (isBitten)
    {
        string bitesItselfOutcomeMessage = "The snake bites itself!";
        return bitesItselfOutcomeMessage;
    }

    if (isOutOfBorders)
    {
        string outOfBordersOutcomeMessage = "The snake must stay within the border!";
        return outOfBordersOutcomeMessage;
    }

    return null;
}

void WriteEndGameMessage(string outcomeMessage)
{
    Console.SetCursorPosition(0, BoardHeight - ScorePanelTextPosition);
    Console.BufferHeight = Console.WindowHeight = BoardHeight + (2 * BordersOffset);

    StringBuilder stringBuilder = new StringBuilder();

    stringBuilder.AppendLine($"Game Over! {outcomeMessage}");
    stringBuilder.Append($"Your total number of points is: {playerPoints}");

    string message = stringBuilder.ToString().TrimEnd();
    Console.WriteLine(message);
}

bool SnakeEatsFood()
    => (snake.NewHeadPosition.row == food.XCoordinate &&
        snake.NewHeadPosition.col + 1 == food.YCoordinate) ||
        (snake.NewHeadPosition.row == food.XCoordinate &&
        snake.NewHeadPosition.col == food.YCoordinate);

void ModifyPlayerAndSnake()
{
    int pointsPerEatenFood = 10;
    playerPoints += pointsPerEatenFood;

    snake.Speed--;
}

void MoveSnake()
{
    Position last = snake.Elements.Dequeue();
    Console.SetCursorPosition(last.col, last.row);
    Console.WriteLine(" ");
}

void DrawSnakeHead()
{
    Console.SetCursorPosition(snake.NewHeadPosition.col, snake.NewHeadPosition.row);
    string headElement = GetSnakeHeadElementSymbol();
    Console.Write(headElement);
}

string GetSnakeHeadElementSymbol()
{
    if (startingDirection == (int)Direction.Right)
    {
        return "▷";
    }
    else if (startingDirection == (int)Direction.Left)
    {
        return "◁";
    }
    else if (startingDirection == (int)Direction.Up)
    {
        return "△";
    }
    else if (startingDirection == (int)Direction.Down)
    {
        return "▽";
    }

    return "@";
}

void DrawScorePanel()
{
    StringBuilder stringBuilder = new StringBuilder();

    int reversedSnakeSpeed = snake.GetReversedSpeed();
    stringBuilder.AppendLine($"Score: {playerPoints}   Snake speed: {reversedSnakeSpeed}");

    string scorePanel = stringBuilder.ToString().TrimEnd();

    Console.SetCursorPosition(0, BoardHeight - ScorePanelTextPosition);
    Console.WriteLine(scorePanel);
}