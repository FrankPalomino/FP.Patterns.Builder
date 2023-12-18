using FP.Patterns.Builder.Exercice1;

Director director = new Director();

MageBuilder mageBuilder = new MageBuilder();

director.MakeMage(mageBuilder);

Mage mage = mageBuilder.GetCharacter();

Console.WriteLine(mage.ToString());

Console.WriteLine("--------------------------");

WarriorBuilder warriorBuilder = new WarriorBuilder();

director.MakeWarrior(warriorBuilder);

Warrior warrior = warriorBuilder.GetCharacter();

Console.WriteLine(warrior.ToString());