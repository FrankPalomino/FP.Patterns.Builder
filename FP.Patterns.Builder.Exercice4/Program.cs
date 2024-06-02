using FP.Patterns.Builder.Exercice4;

VeganMealBuilder veganMealBuilder = new VeganMealBuilder();
MealDirector director = new MealDirector(veganMealBuilder);
director.ConstructMeal();
var veganMeal = veganMealBuilder.GetMeal();
veganMeal.Show();

Console.WriteLine("--------------------------------");
StandarMealBuilder standarMealBuilder = new StandarMealBuilder();
director.SetBuilder(standarMealBuilder);
director.ConstructMeal();
var standarMeal = standarMealBuilder.GetMeal();
standarMeal.Show();