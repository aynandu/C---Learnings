// See https://aka.ms/new-console-template for more information
using Learning;
using ScrapeLibrary;
using System.Collections;
using System.Threading.Tasks;
using System.Timers;

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
/*
myCar.Model = "Swift";
myCar.Make = "Maruthi";
myCar.Year = 2019;
myCar.Color = "Red";
Console.WriteLine($"{myCar.Make } {myCar.Make} {myCar.Model} {myCar.Year} {myCar.Color} ");
Console.WriteLine("{0:C}",myCar.DetermineMarketValue(myCar));
Car myOtherCar;
myOtherCar = myCar;

Console.WriteLine($"{myOtherCar.Make} {myOtherCar.Make}" +
    $" {myOtherCar.Model} {myOtherCar.Year} {myOtherCar.Color} ");
Car mySecondCar = new Car("Ford", "XL6", 2012, "Red");
Console.WriteLine($"{mySecondCar.Make} {mySecondCar.Make}" +
    $" {mySecondCar.Model} {mySecondCar.Year} {mySecondCar.Color} ");
Car.MyMethod();
*/
Scrape myScrape = new Scrape();
/*string Value = myScrape.ScrapeWebpage("http://msdn.microsoft.com");
Console.WriteLine(Value);
Console.ReadLine();
*/
Cars cars = new Cars();
cars.Make = "Oldsmobile";
cars.Model = "Cutlas Supreme";
cars.VIN = "A1";

Cars cars2 = new Cars();
cars2.Make = "Nippon";
cars2.Model = "Supreme";
cars2.VIN = "A2"; 

Book b1 = new Book();
b1.Author = "Robert Tabour";
b1.Title = "Microsoft .Net XML Web Services";
b1.ISBN = "0-000-00000-0";
/*
ArrayList   myArrayList = new ArrayList();
myArrayList.Add(b1);
myArrayList.Add(cars);
myArrayList.Add(cars2);
myArrayList.Remove(b1);
*/
/*
List<Cars> myList = new List<Cars>();
myList.Add(cars);
myList.Add(cars2);
*/
/*/
Dictionary<string,Cars> myDictionary = new Dictionary<string,Cars>();
myDictionary.Add(cars.VIN, cars);
myDictionary.Add(cars2.VIN, cars2);

Console.WriteLine(myDictionary["A2"].Model);
*/

List<Car> myCar2 = new List<Car>()
{ 
    new Car { Make="Nippon", Model="5581",VIN="A12",StickerPrice=5500,Year=2019},
    new Car{ Make="Hyundai", Model="6521",VIN="B12",StickerPrice=6500,Year=2009},
    new Car{ Make="Maruthi", Model="7200",VIN="C12",StickerPrice=4500,Year=2007},
    new Car{ Make="Hyundai", Model="8500",VIN="D12",StickerPrice=6500,Year=2009},
    new Car{ Make="Hyundai", Model="2100",VIN="E12",StickerPrice=6500,Year=2008}
}; //LINQ - Language Integrated Query  +> LINQ Query & LINQ Method

//LINQ Query
/*
var Hundi = from car2 in myCar2
           where car2.Make == "Hyundai"
           && car2.Year ==2009
           select car2;
*/
/*
 * var Hundi = from car2 in myCar2
           where car2.Make == "Hyundai"
           && car2.Year ==2009
           select new {car2.Make , car2.M0del};
*/
/*
var orderCar = from ordercar in myCar2
               orderby ordercar.Year descending
               select ordercar;
*/
//LINQ Method
//var Hundi = myCar2.Where(p => p.Make == "Hyundai"  && p.Year == 2009);
//var Hundi = myCar2.OrderByDescending(p => p.Year).First(p=>p.Make=="BMW")
/*
var orderCar = myCar2.OrderByDescending(p => p.Year);
foreach (var car2 in orderCar)
{
    Console.WriteLine("{0} {1} {2}", car2.Year, car2.Model, car2.VIN);
}
*/
//Timer myTimer = new Timer(2000);
/*
var myTimer=new System.Timers.Timer(2000);
myTimer.Elapsed += MyTimer_Elapsed;
myTimer.Elapsed += MyTimer_Elapsed2;

myTimer.Start();
Console.WriteLine("Enter to close green");
Console.ReadLine();
myTimer.Elapsed -= MyTimer_Elapsed;
Console.ReadLine();

void MyTimer_Elapsed(object? sender, ElapsedEventArgs e)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Elapsed : {0}", e.SignalTime);
}
void MyTimer_Elapsed2(object? sender, ElapsedEventArgs e)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Elapsed : {0}", e.SignalTime);
}
*/
/*
DateTime localDate = DateTime.Now;
Console.WriteLine(localDate);
*/
HandlingExceptions handlingExceptions = new HandlingExceptions();
handlingExceptions.IOReader();