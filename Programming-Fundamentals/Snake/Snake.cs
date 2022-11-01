namespace SnakeGame
{
    public class Snake
    {
        private const int StartingElementsCount = 5;
        private const int MaximumSnakeSpeed = 100;

        public Snake(int bordersOffset, int boardHeight, int boardWidth)
        {
            Random random = new Random();

            this.StartingXPosition = random.Next(bordersOffset, boardHeight - bordersOffset);
            this.StartingYPosition = random.Next(bordersOffset, boardWidth / 2);

            this.Speed = MaximumSnakeSpeed;

            this.Elements = InitialCreate();
        }

        public int StartingXPosition { get; set; }
        public int StartingYPosition { get; set; }
        public int Speed { get; set; }
        public Queue<Position> Elements { get; set; }
        public Position NewHeadPosition { get; set; }

        private Queue<Position> InitialCreate()
        {
            // Set the initial Y position of the snake as an even number
            if (this.StartingYPosition % 2 != 0)
            {
                this.StartingYPosition++;
            }

            Queue<Position> snakeElements = new Queue<Position>();
            for (int i = this.StartingYPosition; i < StartingElementsCount + this.StartingYPosition; i++)
            {
                snakeElements.Enqueue(new Position(this.StartingXPosition, i));
            }

            return snakeElements;
        }

        public bool IsOutOfBorders(int boardHeight, int boardWidth, int bordersOffset)
            => this.NewHeadPosition.row < 1 || this.NewHeadPosition.row > boardHeight - bordersOffset ||
               this.NewHeadPosition.col < 1 || this.NewHeadPosition.col >= boardWidth - bordersOffset + 2;

        public bool IsBitten()
            => this.Elements.Any(x => x.col == this.NewHeadPosition.col && x.row == this.NewHeadPosition.row);

        public int GetReversedSpeed()
            => MaximumSnakeSpeed - this.Speed;
    }
}