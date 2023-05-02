// See https://aka.ms/new-console-template for more information
using Learning;

Variables variables = new Variables();
//variables.Sum();
//variables.StringVarible();
ConditionalStatement conditionalStatement = new ConditionalStatement();
//conditionalStatement.Statement();
Iteration iteration = new Iteration();
//iteration.Ilter();
Arrays arrays = new Arrays();
//arrays.arys();
SimpleMethod method = new SimpleMethod();
//method.GetValue();
WhileIlteration Game = new WhileIlteration();
//Game.DisplayMenu();
WorkingWithStrings str = new WorkingWithStrings();
//str.StringMethod();
DateAndTime Mydate = new DateAndTime();
//Mydate.DateTime();
Car myCar = new Car();
myCar.Model = "Swift";
myCar.Make = "Maruthi";
myCar.Year = 2019;
myCar.Color = "Red";
Console.WriteLine($"{myCar.Make } {myCar.Make} {myCar.Model} {myCar.Year} {myCar.Color} ");
Console.WriteLine("{0:C}",myCar.DetermineMarketValue(myCar));