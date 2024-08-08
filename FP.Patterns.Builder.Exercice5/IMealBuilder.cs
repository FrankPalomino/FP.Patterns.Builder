namespace FP.Patterns.Builder.Exercice5
{
    public interface IMealBuilder
    {
        void AddBurguer();
        void AddDrink();
        void AddSide();
        Meal GetMeal();
        void Reset();
    }
}
