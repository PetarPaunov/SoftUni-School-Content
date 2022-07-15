namespace GameOfWar
{
    public class Card
    {
        public char Face { get; set; }

        public char Suite { get; set; }

        public int Power { get; set; }

        public override string ToString()
        {
            return $"{this.Face}{this.Suite}";
        }
    }
}
