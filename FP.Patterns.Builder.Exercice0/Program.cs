using FP.Patterns.Builder;

Director director = new Director();

//Create normal product
NormalBuilder normalBuilder = new NormalBuilder();
director.Construct(normalBuilder);

Product product = normalBuilder.GetResult();

product.Show();

Console.WriteLine("--------------------------");

//Create special product
SpecialBuilder specialBuilder = new SpecialBuilder();
director.Construct(specialBuilder);

Product product2 = specialBuilder.GetResult();

product2.Show();