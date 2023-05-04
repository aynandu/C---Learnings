using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
     class HandlingExceptions
    {
        public void IOReader()
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\nandu\Desktop\C#\Libraryexpanation.txt");
                Console.WriteLine(content);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Their is a Problem ");
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
