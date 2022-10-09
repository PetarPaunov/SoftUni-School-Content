using GameOfLife;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

const int WindowHeight = 35;
const int WindowWidth = 70;
const int SizeOfMenuPanel = 5;
const int BoardSize = WindowHeight - SizeOfMenuPanel;
const int LifeProcessSpeed = 120;

SetWindowProperties();

while (true)
{
    Console.Clear();
    string menuPanel = StartMenuPanel();
    Console.WriteLine(menuPanel);

    ConsoleKeyInfo key = Console.ReadKey(true);
    Console.Clear();

    if (key.Key == ConsoleKey.O)
    {
        CreateOwnField();
    }

    if (key.Key == ConsoleKey.B)
    {
        BuiltInFields();
    }
}

void SetWindowProperties()
{
    Console.Clear();
    Console.CursorVisible = false;
    Console.BufferHeight = Console.WindowHeight = WindowHeight;
    Console.BufferWidth = Console.WindowWidth = WindowWidth;
}

string StartMenuPanel()
{
    StringBuilder stringBuilder = new StringBuilder();

    stringBuilder.AppendLine("Choose to create your own field or test the built-in fields");

    for (int row = 0; row < BoardSize - 1; row++)
    {
        stringBuilder.AppendLine(new String(' ', WindowWidth));
    }

    stringBuilder.AppendLine(new String('=', WindowWidth));
    stringBuilder.AppendLine("[O] Create own field");
    stringBuilder.Append("[B] Test the build-in fields");

    return stringBuilder.ToString().TrimEnd();
}

void CreateOwnField()
{
    GameOfLifeEditor gameOfLife = new GameOfLifeEditor(BoardSize, WindowWidth);

    Console.CursorVisible = true;

    Console.SetCursorPosition(0, 0);
    Console.WriteLine(gameOfLife.Draw(BoardSize, WindowWidth));

    while (true)
    {
        Console.CursorVisible = true;

        ConsoleKeyInfo key = Console.ReadKey(true);

        if (key.Key == ConsoleKey.Escape)
        {
            break;
        }

        bool gameIsStopped = false;

        while (key.Key != ConsoleKey.Backspace)
        {
            string generation = gameOfLife.Move(key, BoardSize, WindowWidth);

            if (key.Key == ConsoleKey.Escape)
            {
                gameIsStopped = true;
                break;
            }

            if (generation == "")
            {
                key = Console.ReadKey(true);
                continue;
            }

            Console.SetCursorPosition(0, 0);
            Console.WriteLine(generation);
            key = Console.ReadKey(true);
        }

        bool keyIsBackspace = key.Key == ConsoleKey.Backspace ? true : false;

        while (keyIsBackspace)
        {
            LifeProcess(gameOfLife);
            if (Console.KeyAvailable == true)
            {
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Escape)
                {
                    gameIsStopped = true;
                    break;
                }

                if (key.Key == ConsoleKey.Backspace)
                {
                    break;
                }
            }
        }

        if (gameIsStopped)
        {
            break;
        }
    }
}

void BuiltInFields()
{
    GameOfLifeBuiltIn gameOfLife = new GameOfLifeBuiltIn(BoardSize, WindowWidth);
    Console.WriteLine(gameOfLife.Draw(BoardSize, WindowWidth));

    while (true)
    {
        ConsoleKeyInfo key = Console.ReadKey(true);

        if (key.Key == ConsoleKey.Escape)
        {
            break;
        }

        if (key.Key == ConsoleKey.F1)
        {
            gameOfLife.GenerateRandomLifeSeed();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(gameOfLife.Draw(BoardSize, WindowWidth));

            continue;
        }

        if (key.Key == ConsoleKey.F2)
        {
            string fileName = "pulsar.txt";
            GenerateField(gameOfLife, fileName);

            continue;
        }

        if (key.Key == ConsoleKey.F3)
        {
            string fileName = "gosper-glider-gun.txt";
            GenerateField(gameOfLife, fileName);

            continue;
        }

        if (key.Key == ConsoleKey.F4)
        {
            string fileName = "living-forever.txt";
            GenerateField(gameOfLife, fileName);

            continue;
        }

        bool gameIsStopped = false;
        bool keyIsBackspace = key.Key == ConsoleKey.Backspace ? true : false;

        while (keyIsBackspace)
        {
            LifeProcess(gameOfLife);
            if (Console.KeyAvailable == true)
            {
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Escape)
                {
                    gameIsStopped = true;
                    break;
                }

                if (key.Key == ConsoleKey.Backspace)
                {
                    break;
                }
            }
        }

        if (gameIsStopped)
        {
            break;
        }
    }
}

void LifeProcess(GameOfLifeBase gameOfLife)
{
    Console.CursorVisible = false;

    Console.SetCursorPosition(0, 0);
    Console.WriteLine(gameOfLife.Draw(BoardSize, WindowWidth));

    gameOfLife.SpawnNextGeneration();

    Thread.Sleep(LifeProcessSpeed);
}

void GenerateField(GameOfLifeBuiltIn gameOfLife, string fileName)
{
    gameOfLife.GenerateField(fileName, WindowWidth, BoardSize);
    Console.SetCursorPosition(0, 0);
    Console.WriteLine(gameOfLife.Draw(BoardSize, WindowWidth));
}