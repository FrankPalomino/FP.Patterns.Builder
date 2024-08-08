namespace FP.Patterns.Builder.Exercice5
{
    public class NonVegMealBuilder : IMealBuilder
    {
        private Meal _meal;

        public NonVegMealBuilder()
        {
            _meal = new Meal();
        }
        public void AddBurguer()
        {
            _meal.Burguer = "Non vegan Burguer";
        }

        public void AddDrink()
        {
            _meal.Drink = "Non vegan Drink";
        }

        public void AddSide()
        {
            _meal.Side = "Non vegan Side";
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
