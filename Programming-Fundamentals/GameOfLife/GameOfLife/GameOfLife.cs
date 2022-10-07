using GameOfLife;

Console.OutputEncoding = System.Text.Encoding.Unicode;

const int WindowHeight = 30;
const int WindowWidth = 60;
const int SizeOfMenuePanel = 5;
const int BoardSize = WindowHeight - SizeOfMenuePanel;
const int LifeProcessSpeed = 120;

SetWindowProperties();

while (true)
{
    Console.Clear();
    Console.Write("Choose to create your own field or test the built-in fields");
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
    Console.SetCursorPosition(0, WindowHeight - SizeOfMenuePanel);
    Console.WriteLine(new String('=', WindowWidth));
    Console.WriteLine("[O] Create own field");
    Console.Write("[B] Test the build-in fields");
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

        ConsoleKeyInfo key = Console.ReadKey();

        if (key.Key == ConsoleKey.Escape)
        {
            break;
        }

        while (key.Key != ConsoleKey.Backspace)
        {
            string generation = gameOfLife.Move(key, BoardSize, WindowWidth, WindowHeight);

            if (generation == "")
            {
                key = Console.ReadKey();
                continue;
            }

            Console.SetCursorPosition(0, 0);
            Console.WriteLine(generation);
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
    Console.WriteLine(gameOfLife.Draw(BoardSize, WindowWidth));

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

        while (Console.KeyAvailable == false || Console.ReadKey().Key != ConsoleKey.Backspace)
        {
            LifeProcess(gameOfLife);
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