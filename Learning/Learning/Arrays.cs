using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class Arrays
    {
        public void arys()
        {
            /*
            int[] numbers = new int[] { 1, 6, 7, 8, 9, 10 };
            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine(numbers[i]);
            }
            */
            /*
            string[] array = new string[] {"reshm","Neethu","Nandu"};
            
            foreach (string str in array) 
            {
                Console.WriteLine(str);
            }
            */

            string ztr = "he constructor will set up a handful of " +
                "private variables, and set the communication mode as well.";
            Console.WriteLine(ztr.Length);
            char[] charArrayz = ztr.ToCharArray();
            Console.WriteLine(charArrayz.Length);
            Array.Reverse(charArrayz);
            Console.WriteLine(charArrayz);

        }

    }
}
