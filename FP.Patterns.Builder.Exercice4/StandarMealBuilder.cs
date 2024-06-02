namespace FP.Patterns.Builder.Exercice4
{
    public class StandarMealBuilder : IMealBuilder
    {
        private Meal _meal;
        public void BuildDessert()
        {
            _meal.Dessert = "Standar Dessert";
        }

        public void BuildDrink()
        {
            _meal.Drink = "Standar Drink";
        }

        public void BuildMainCourse()
        {
            _meal.MainCourse = "Standar Main course";
        }

        public void BuildSideDish()
        {
            _meal.SideDish = "Standar Side Dish";
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
