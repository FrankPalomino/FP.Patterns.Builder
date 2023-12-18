namespace FP.Patterns.Builder.Exercice2
{
    public class Automovil
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }

        public override string ToString()
        {
            return $"The Name is: {Name}, Brand is: {Brand}, Color is: {Color} and the Engine is: {Engine}";
        }
    }
}
