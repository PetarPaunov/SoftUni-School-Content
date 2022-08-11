using FallingRocks;

const int WindowHeight = 40;
const int WindowWidth = 50;
const int SizeOfScorePanel = 10;
const int TotalRocksFallSpeed = 200;

int score = 0;

int rocksSpawnRate = ProcessPlayerRocksSpawnRateChoice();
int rocksFallSpeed = ProcessPlayerRockFallSpeedChoice();

SetWindowProperties();

int playerWindowCenterWidth = (Console.WindowWidth - 1) / 2;

int consoleMaxHeight = Console.WindowHeight - SizeOfScorePanel;
int playerWindowBottomHeight = consoleMaxHeight - 1;

Player player = new Player(playerWindowCenterWidth, playerWindowBottomHeight);
List<Rock> rocks = new List<Rock>();

while (true)
{
    RedrawTheConsole();

    CreateRocks();

    player.Draw();
    DrawRocks();

    player.Move();
    MoveRocks();

    if (player.HasBeenHit)
    {
        Thread.Sleep(500);
        EndGame();
        return;
    }

    Thread.Sleep(rocksFallSpeed);
}

void CreateRocks()
{
    int consoleMaxWidth = Console.WindowWidth - 2;

    for (int width = 1; width <= consoleMaxWidth; width++)
    {
        if (ShouldGenerateSymbol())
        {
            Rock newRock = new Rock(width);
            rocks.Add(newRock);
        }
    }
}

void DrawRocks()
{
    foreach (Rock rock in rocks)
    {
        Console.SetCursorPosition(rock.X, rock.Y);
        Console.Write(rock.Symbol);
    }
}

List<Rock> MoveRocks()
{
    List<Rock> rocksToRemove = new List<Rock>();
    foreach (Rock rock in rocks)
    {
        rock.Y++;

        if (rock.Y == consoleMaxHeight)
        {
            rocksToRemove.Add(rock);
            score++;
        }

        if (ThereIsCollision(rock, player))
        {
            player.HasBeenHit = true;
        }
    }

    RemoveRocks(rocksToRemove, rocks);

    return rocks;
}

void RemoveRocks(List<Rock> rocksToRemove, List<Rock> rocks)
{
    foreach (var rock in rocksToRemove)
    {
        rocks.Remove(rock);
    }
}

bool ShouldGenerateSymbol()
{
    Random random = new Random();
    return random.Next(0, 101) >= 100 - rocksSpawnRate;
}

bool ThereIsCollision(Rock rock, Player player)
{
    for (int playerSymbol = 0; playerSymbol < player.Representation.Length; playerSymbol++)
    {
        if (RockAndPlayerAreOnSameWidth(rock, player)
            && RockAndPlayerAreOnSameHeight(rock, player))
        {
            return true;
        }
    }
    return false;
}

static bool RockAndPlayerAreOnSameWidth(Rock rock, Player player)
    => rock.X == player.X || rock.X == player.X + 1 || rock.X == player.X + 2;


static bool RockAndPlayerAreOnSameHeight(Rock rock, Player player)
    => rock.Y == player.Y + 1;

void EndGame()
{
    Console.SetCursorPosition(0, 33);
    Console.Write("GAME OVER!!");
}

void RedrawTheConsole()
{
    Console.SetCursorPosition(0, 0);
    for (int i = 0; i < WindowHeight - SizeOfScorePanel; i++)
    {
        Console.Write(new String(' ', 50));
    }

    DrawScorePanel();
}

void DrawScorePanel()
{
    for (int width = 0; width < Console.WindowWidth; width++)
    {
        Console.Write('=');
    }
    Console.WriteLine($"Your score is: {score}");
    Console.Write($"Rocks spawn rate: {rocksSpawnRate}   Rocks fall speed: {rocksFallSpeed}");
}

int ProcessPlayerRocksSpawnRateChoice()
{
    Console.WriteLine("Rocks spawn rate hardness level (from 1 to 10 - 4 is prefferable)");

    bool playerInputIsValid = int.TryParse(Console.ReadLine(), out rocksSpawnRate);

    if (!playerInputIsValid || rocksSpawnRate < 0 || rocksSpawnRate > 10)
    {
        rocksSpawnRate = 4;
    }

    return rocksSpawnRate;
}

int ProcessPlayerRockFallSpeedChoice()
{
    Console.WriteLine("Rocks fall speed level (from 50 to 150 - 120 is prefferable)");

    bool playerInputIsValid = int.TryParse(Console.ReadLine(), out rocksFallSpeed);

    rocksFallSpeed = ReversFallSpeedPlayerInput();

    if (!playerInputIsValid || rocksFallSpeed < 50 || rocksFallSpeed > 150)
    {
        rocksFallSpeed = 100;
    }

    return rocksFallSpeed;
}

void SetWindowProperties()
{
    Console.Clear();
    Console.CursorVisible = false;
    Console.BufferHeight = Console.WindowHeight = WindowHeight;
    Console.BufferWidth = Console.WindowWidth = WindowWidth;
}

int ReversFallSpeedPlayerInput()
    => TotalRocksFallSpeed - rocksFallSpeed;