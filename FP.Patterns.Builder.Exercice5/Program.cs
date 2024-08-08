using FP.Patterns.Builder.Exercice5;

IMealBuilder builder = new VegMealBuilder();
MealDirector director = new(builder);
director.Make();
Meal meal = builder.GetMeal();
Console.WriteLine(meal);

Console.WriteLine("----------------------");

builder = new NonVegMealBuilder();
director.ChangeBuilder(builder);
director.Make();
meal = builder.GetMeal();
Console.WriteLine(meal);