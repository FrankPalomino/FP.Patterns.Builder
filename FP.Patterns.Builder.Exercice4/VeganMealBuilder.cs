namespace FP.Patterns.Builder.Exercice4
{
    public class VeganMealBuilder : IMealBuilder
    {
        private Meal _meal;
        public void BuildDessert()
        {
            _meal.Dessert = "Vegan Dessert";
        }

        public void BuildDrink()
        {
            _meal.Drink = "Vegan Drink";
        }

        public void BuildMainCourse()
        {
            _meal.MainCourse = "Vegan Main Course";
        }

        public void BuildSideDish()
        {
            _meal.SideDish = "Vegan Side Dish";
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
