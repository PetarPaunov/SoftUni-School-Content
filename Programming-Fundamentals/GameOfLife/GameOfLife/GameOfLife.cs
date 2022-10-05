using GameOfLife;

Console.OutputEncoding = System.Text.Encoding.Unicode;

const int WindowHeight = 30;
const int WindowWidth = 60;
const int SizeOfMenuePanel = 5;
const int BoardSize = WindowHeight - SizeOfMenuePanel;

SetWindowProperties();

while (true)
{
    Console.Clear();
    Console.WriteLine("Choose to create your own field or test the built-in fields");
    StartMenuPanel();

    ConsoleKeyInfo key = Console.ReadKey();
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

void StartMenuPanel()
{
    Console.SetCursorPosition(0, WindowHeight - 5);
    Console.WriteLine(new String('=', WindowWidth));
    Console.WriteLine("[O] Create own field");
    Console.Write("[B] Building a test field");
}

void CreateOwnField()
{
    GameOfLifeEditor gameOfLife = new GameOfLifeEditor(BoardSize, WindowWidth);

    Console.CursorVisible = true;

    gameOfLife.Draw(BoardSize, WindowWidth, WindowHeight);

    while (true)
    {
        ConsoleKeyInfo key = Console.ReadKey();

        if (key.Key == ConsoleKey.Escape)
        {
            break;
        }

        while (key.Key != ConsoleKey.Backspace)
        {
            gameOfLife.Move(key, BoardSize, WindowWidth, WindowHeight);
            key = Console.ReadKey();
        }

        while (Console.KeyAvailable == false || Console.ReadKey().Key != ConsoleKey.Backspace)
        {
            LifeProcess(gameOfLife);
        }
    }
}

void BuiltInFields()
{
    GameOfLifeBuiltIn gameOfLife = new GameOfLifeBuiltIn(BoardSize, WindowWidth);
    gameOfLife.Draw(BoardSize, WindowWidth, WindowHeight);

    while (true)
    {
        ConsoleKeyInfo key = Console.ReadKey();

        if (key.Key == ConsoleKey.Escape)
        {
            break;
        }

        if (key.Key == ConsoleKey.F1)
        {
            gameOfLife.GenerateRandomLifeSeed();
            gameOfLife.Draw(BoardSize, WindowWidth, WindowHeight);

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

        while (Console.KeyAvailable == false || Console.ReadKey().Key != ConsoleKey.Backspace)
        {
            LifeProcess(gameOfLife);
        }
    }
}

void LifeProcess(GameOfLifeBase gameOfLife)
{
    gameOfLife.Draw(BoardSize, WindowWidth, WindowHeight);
    gameOfLife.SpawnNextGeneration();

    Thread.Sleep(120);
}

void GenerateField(GameOfLifeBuiltIn gameOfLife, string fileName)
{
    gameOfLife.GenerateField(fileName, WindowWidth, BoardSize);
    gameOfLife.Draw(BoardSize, WindowWidth, WindowHeight);
}