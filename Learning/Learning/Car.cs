 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string VIN { get; set; }
        public int StickerPrice { get; set; }

        public  decimal DetermineMarketValue(Car car)
        {
            decimal carValue ;
            if (Year>2000)
                return carValue = 2000.0M;
            else 
                return carValue = 1000.0M;
        }
        public Car()
        {
            Make = "Nissan";
        }
        public Car(string make,string model,int year,string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color =color;
        }
        public static void MyMethod()
        {
            Console.WriteLine("Static Member of Car class");

        }
    }
}
