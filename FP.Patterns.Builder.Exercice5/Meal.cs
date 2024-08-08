namespace FP.Patterns.Builder.Exercice5
{
    public class Meal
    {
        public string Burguer { get; set; }
        public string Drink { get; set; }
        public string Side { get; set; }

        public override string ToString()
        {
            return $"Burguer: {Burguer}\nDrink: {Drink}\nSide: {Side}";
        }
    }
}
