namespace FP.Patterns.Builder.Exercice4
{
    public class MealDirector
    {
        private IMealBuilder _builder;
        public MealDirector(IMealBuilder builder) 
        {
            _builder = builder;
        }

        public void SetBuilder(IMealBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructMeal()
        {
            _builder.Reset();
            _builder.BuildMainCourse();
            _builder.BuildSideDish();
            _builder.BuildDrink();
            _builder.BuildDessert();
        }
    }
}
