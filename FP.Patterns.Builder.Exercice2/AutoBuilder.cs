namespace FP.Patterns.Builder.Exercice2
{
    public class AutoBuilder : IBuilder
    {
        private readonly Automovil _automovil;

        public AutoBuilder()
        {
            _automovil = new Automovil();
        }

        public Automovil MakeAuto(string name)
        {
            _automovil.Name = name;
            return _automovil;
        }

        public void SetBrand(string brand)
        {
            _automovil.Brand = brand;
        }

        public void SetColor(string color)
        {
            _automovil.Color = color;
        }

        public void SetEngine(string engine)
        {
            _automovil.Engine = engine;
        }
    }
}
