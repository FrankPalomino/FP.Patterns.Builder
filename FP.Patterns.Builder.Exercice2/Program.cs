using FP.Patterns.Builder.Exercice2;

Director director = new Director();

IBuilder utilitaryBuilder = new AutoBuilder();

director.MakeUtilitaryAutomovil(utilitaryBuilder);

var utilitary = utilitaryBuilder.MakeAuto("Pepito");

Console.WriteLine(utilitary.ToString());

IBuilder sportBuilder = new AutoBuilder();

director.MakeSportAutomovil(sportBuilder);

var sport = sportBuilder.MakeAuto("Deportivo");

Console.WriteLine(sport.ToString());