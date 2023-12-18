namespace FP.Patterns.Builder.Exercice2
{
    public interface IBuilder
    {
        Automovil MakeAuto(string name);
        void SetBrand(string brand);
        void SetColor(string color);
        void SetEngine(string engine);
    }
}
