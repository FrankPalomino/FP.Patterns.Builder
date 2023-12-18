namespace FP.Patterns.Builder.Exercice2
{
    public class Director
    {

        public void MakeSportAutomovil(IBuilder builder)
        {
            builder.SetBrand("Jaguar");
            builder.SetEngine("Sport Engine");
            builder.SetColor("Red");
        }

        public void MakeUtilitaryAutomovil(IBuilder builder)
        {
            builder.SetBrand("Seat");
            builder.SetEngine("Utilitary Engine");
            builder.SetColor("White");
        }
    }
}
