namespace FP.Patterns.Builder.Exercice5
{
    public class VegMealBuilder : IMealBuilder
    {
        private Meal _meal;
        public VegMealBuilder()
        {
            _meal = new Meal();
        }
        public void AddBurguer()
        {
            _meal.Burguer = "Vegan Burguer";
        }

        public void AddDrink()
        {
            _meal.Drink = "Vegan Drink";
        }

        public void AddSide()
        {
            _meal.Side = "Vegan Side";
        }

        public Meal GetMeal()
        {
            return _meal;
        }

        public void Reset()
        {
            _meal = new Meal();
        }
    }
}
