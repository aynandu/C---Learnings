using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class SimpleMethod
    {
        public static string firstName;
        public static string lasttName;
        public static string city;

        public  void GetValue()
        {
            Console.WriteLine("The Name Game");
            Console.Write("Your First Name: ");
            firstName = Console.ReadLine();
            Console.Write("Your Last Name: ");
            lasttName = Console.ReadLine();
            Console.Write("Your City Name: ");
            city = Console.ReadLine();
            DisplayValue(RevereseValue(firstName), RevereseValue(lasttName), RevereseValue(city));
            DisplayValue(RevereseValue(firstName));
            DisplayValue(RevereseValue(lasttName));
            DisplayValue(RevereseValue(city));
        }
        private static string RevereseValue(string stringValue) 
        {
            char[] charArrayz = stringValue.ToCharArray();
            Array.Reverse(charArrayz);
            return String.Concat(charArrayz);
        }
        private static void DisplayValue(string firstName,string lasttName,string city) 
        {
            Console.Write($"Result : {firstName}" +
                $" {lasttName} {city} ");
        }

        private static void DisplayValue(string Name)
        {
            Console.Write($"Result : {Name}");
        }

    }
}
