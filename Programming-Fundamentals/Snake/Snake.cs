using Snake;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

const int SnakeStartingElements = 5;
const int SnakeStartingXPossition = 5;
const int SnakeStartingYPossition = 1;

const int BorderWidth = 80;
const int BorderHeigth = 30;
const int MaximumSnakeSpeed = 100;

const int ScorePanelTextPossition = 3;
const int SpeedIncrease = 1;
const int PointsPerEatenFood = 10;

const int OffsetOnTheLeftSide = 4;
const int OffsetOnTheBottomSide = 5;
const int OffsetForTheBordersHorizontalSides = 2;

const string OutOfBorderOutcomeMessage = "The snake must stay within the border!";
const string BitesItselfOutcomeMessage = "The snake bites itself!";

SetWindowProperties();

Console.SetCursorPosition(0, 0);
Console.ForegroundColor = ConsoleColor.Cyan;

string border = DrawBorder();
Console.WriteLine(border);

Queue<Position> snakeElements = new Queue<Position>();
for (int i = SnakeStartingYPossition; i < SnakeStartingElements; i++)
{
    snakeElements.Enqueue(new Position(SnakeStartingXPossition, i));
}

Position[] directions = new Position[]
{
    new Position(0, 1), // right
    new Position(0, -1), // left
    new Position(1, 0), // down
    new Position(-1, 0), // up
};

int playerPoints = 0;
int snakeSpeed = 100;

int startingDirection = (int)Direction.Right;

Food food = DrawFoodOnTheBoard();

while (true)
{
    DeterminSnakeDirection();

    Position snakeHead = snakeElements.Last();
    Position nextDirection = directions[startingDirection];

    Position snakeNewHead = new Position(snakeHead.row + nextDirection.row,
        snakeHead.col + nextDirection.col);

    string outcomeMessage = IsSnakeDeath(snakeNewHead);

    if (outcomeMessage != "")
    {
        string message = EndGame(outcomeMessage);

        Console.SetCursorPosition(0, BorderHeigth - ScorePanelTextPossition);
        Console.WriteLine(message);

        Thread.Sleep(5000);
        break;
    }

    snakeElements.Enqueue(snakeNewHead);

    if (HasCollision(snakeNewHead, food))
    {
        playerPoints += PointsPerEatenFood;
        snakeSpeed -= SpeedIncrease;
        food = DrawFoodOnTheBoard();
    }
    else
    {
        Position last = snakeElements.Dequeue();
        Console.SetCursorPosition(last.col, last.row);
        Console.Write(" ");
    }

    Console.SetCursorPosition(snakeHead.col, snakeHead.row);
    Console.Write("□");

    Console.SetCursorPosition(snakeNewHead.col, snakeNewHead.row);

    DetermineSnakeHeadDirection();

    Console.SetCursorPosition(0, BorderHeigth - ScorePanelTextPossition);
    string scorePanel = DrawScorePanel();
    Console.WriteLine(scorePanel);

    Thread.Sleep(snakeSpeed);
}

void SetWindowProperties()
{
    Console.CursorVisible = false;
    Console.BufferHeight = Console.WindowHeight = BorderHeigth;
    Console.BufferWidth = Console.WindowWidth = BorderWidth;
}

string DrawBorder()
{
    StringBuilder stringBuilder = new StringBuilder();

    char borderPiece = '█';

    string horizontalSide = new string(borderPiece, BorderWidth - OffsetForTheBordersHorizontalSides);
    string emptyHorizontalSide = new string(' ', BorderWidth - OffsetForTheBordersHorizontalSides);

    stringBuilder.
        AppendLine
        ($"{borderPiece}{horizontalSide}{borderPiece}");

    for (int row = 0; row < BorderHeigth - OffsetOnTheBottomSide; row++)
    {
        stringBuilder.
            AppendLine
            ($"{borderPiece}{emptyHorizontalSide}{borderPiece}");
    }

    stringBuilder.
        AppendLine
        ($"{borderPiece}{horizontalSide}{borderPiece}");

    return stringBuilder.ToString().TrimEnd();
}

Food DrawFoodOnTheBoard()
{
    Food food = new Food(BorderHeigth - OffsetOnTheLeftSide, BorderWidth - ScorePanelTextPossition);

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.SetCursorPosition(food.YFoodCoordinate, food.XFoodCoordinate);
    Console.Write(food.FoodSymbol);

    return food;
}

void DetermineSnakeHeadDirection()
{
    if (startingDirection == (int)Direction.Right)
    {
        Console.Write("▷");
    }
    if (startingDirection == (int)Direction.Left)
    {
        Console.Write("◁");
    }
    if (startingDirection == (int)Direction.Up)
    {
        Console.Write("△");
    }
    if (startingDirection == (int)Direction.Down)
    {
        Console.Write("▽");
    }
}

string IsSnakeDeath(Position snakeNewHead)
{
    bool isContained = snakeElements
        .Any(x => x.col == snakeNewHead.col && x.row == snakeNewHead.row);

    if (isContained)
    {
        return BitesItselfOutcomeMessage;
    }
    else if (snakeNewHead.row < 1 || snakeNewHead.row > BorderHeigth - OffsetOnTheBottomSide ||
             snakeNewHead.col < 1 || snakeNewHead.col >= BorderWidth - OffsetForTheBordersHorizontalSides)
    {
        return OutOfBorderOutcomeMessage;
    }

    return "";
}

string EndGame(string outcomeMessage)
{
    StringBuilder stringBuilder = new StringBuilder();

    stringBuilder.AppendLine($"Game Over!!");
    stringBuilder.Append($"{outcomeMessage}");

    return stringBuilder.ToString().TrimEnd();
}

bool HasCollision(Position snakeNewHead, Food food)
    => snakeNewHead.row == food.XFoodCoordinate &&
        snakeNewHead.col == food.YFoodCoordinate;

string DrawScorePanel()
{
    StringBuilder stringBuilder = new StringBuilder();

    stringBuilder.AppendLine($"Score: {playerPoints}");

    int reversedSnakeSpeed = MaximumSnakeSpeed - snakeSpeed;
    stringBuilder.Append($"Snake speed: {reversedSnakeSpeed}");

    return stringBuilder.ToString().TrimEnd();
}

void DeterminSnakeDirection()
{
    if (Console.KeyAvailable)
    {
        ConsoleKeyInfo userInput = Console.ReadKey();
        if (userInput.Key == ConsoleKey.LeftArrow)
        {
            if (startingDirection != (int)Direction.Right)
            {
                startingDirection = (int)Direction.Left;
            }
        }
        if (userInput.Key == ConsoleKey.RightArrow)
        {
            if (startingDirection != (int)Direction.Left)
            {
                startingDirection = (int)Direction.Right;
            }
        }
        if (userInput.Key == ConsoleKey.UpArrow)
        {
            if (startingDirection != (int)Direction.Down)
            {
                startingDirection = (int)Direction.Up;
            }
        }
        if (userInput.Key == ConsoleKey.DownArrow)
        {
            if (startingDirection != (int)Direction.Up)
            {
                startingDirection = (int)Direction.Down;
            }
        }
    }
}