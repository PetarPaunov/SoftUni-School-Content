namespace GameOfWar
{
    public class Card
    {
        public CardFace Face { get; set; }

        public CardSuit Suite { get; set; }

        public override string ToString()
        {
            int face = (int)Enum.Parse(typeof(CardFace), this.Face.ToString());
            var suite = (char)this.Suite;

            if (face > 10)
            {
                return $"{this.Face.ToString()[0]}{suite}";
            }

            return $"{face}{suite}";
        }
    }
}
