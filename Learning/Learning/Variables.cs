using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class Variables
    {
        public void Sum()
        {
            int x;
            int y;

            x = 7;
            y = x + 3;
            Console.WriteLine(y);
        }
        public void StringVarible()
        {
            Console.WriteLine("What is Your Name ");
            Console.WriteLine("Type your First Name : ");
            string myFirstName=Console.ReadLine();
            Console.WriteLine("Type Your last Name: ");
            string myLastName=Console.ReadLine();
            Console.WriteLine("hey," +myFirstName+" " +myLastName);
        }
    }
}
