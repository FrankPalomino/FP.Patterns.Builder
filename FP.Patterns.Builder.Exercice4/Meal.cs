namespace FP.Patterns.Builder.Exercice4
{
    public class Meal
    {
        public string MainCourse { get; set; }
        public string SideDish { get; set; }
        public string Drink { get; set; }
        public string Dessert { get; set; }
        public void Show()
        {
            Console.WriteLine($"The Main Course is: {MainCourse}\nThe Side Dish is:{SideDish}\nThe Drink is: {Drink}\nThe Dessert is:{Dessert}");
        }
    }
}
