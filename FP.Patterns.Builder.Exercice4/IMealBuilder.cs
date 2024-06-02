namespace FP.Patterns.Builder.Exercice4
{
    public interface IMealBuilder
    {
        void Reset();
        void BuildMainCourse();
        void BuildSideDish();
        void BuildDrink();
        void BuildDessert();
        Meal GetMeal();
    }
}
