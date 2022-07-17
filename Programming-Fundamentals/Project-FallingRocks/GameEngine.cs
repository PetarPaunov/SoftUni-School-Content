namespace FallingRocks
{
    public class GameEngine
    {
        const int WindowHeight = 40;
        const int WindowWidth = 50;
        public void Run()
        {
            int rockProbability = int.Parse(Console.ReadLine());

            if (rockProbability < 0 || rockProbability >= 10)
            {
                rockProbability = 4;
            }

            Console.Clear();

            setWindowProperties();

            List<Rock> rocks = new List<Rock>();  
            Rock rock = new Rock();
            Dwarf dwarf = new Dwarf((Console.WindowWidth - 1) / 2, Console.WindowHeight - Score.sizeOfScorePanel - 1);
            dwarf.drawDwarf();

            while (true)
            {
                dwarf.DrawScorePanel();
                dwarf.moveDwarf();
                dwarf.drawDwarf();

                rock.CreateRocks(rocks, rockProbability);
                rock.drawRocks(rocks);

                MoveRocks(rocks, dwarf);

                if (dwarf.checkDwarfForCollision())
                {
                    Thread.Sleep(2000);
                    return;
                }

                Thread.Sleep(140);
                Console.SetCursorPosition(0, 0);
                Console.Clear();
            }
        }

        private List<Rock> MoveRocks(List<Rock> rocks, Dwarf dwarf)
        {
            List<Rock> rocksToRemove = new List<Rock>();
            foreach (Rock rock in rocks)
            {
                rock.Y += 1;
                if (rock.Y == Console.WindowHeight - Score.sizeOfScorePanel)
                {
                    rocksToRemove.Add(rock);
                    Score.AddToScore(1);
                }
                if (ThereIsCollision(rock, dwarf))
                {
                    dwarf.HasBeenHit = true;
                }
            }
            foreach (Rock rock in rocksToRemove)
            {
                rocks.Remove(rock);
            }
            return rocks;
        }
        private bool ThereIsCollision(Rock rock, Dwarf dwarf)
        {
            for (int i = 0; i < dwarf.Representation.Length; ++i)
            {
                if (rock.X == dwarf.X + i && rock.Y == dwarf.Y)
                {
                    return true;
                }
            }
            return false;
        }

        private void setWindowProperties()
        {
            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight = WindowHeight;
            Console.BufferWidth = Console.WindowWidth = WindowWidth;
        }
    }
}
