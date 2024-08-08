namespace FP.Patterns.Builder.Exercice5
{
    public class MealDirector
    {
        private IMealBuilder _builder;

        public MealDirector(IMealBuilder builder)
        {
            _builder = builder;
        }

        public void ChangeBuilder(IMealBuilder builder)
        {
            _builder = builder;
        }

        public void Make()
        {
            _builder.Reset();
            _builder.AddBurguer();
            _builder.AddDrink();
            _builder.AddSide();
        }
    }
}
