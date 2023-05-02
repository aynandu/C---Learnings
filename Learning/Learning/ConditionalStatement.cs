 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class ConditionalStatement
    {
        public void Statement()
        {
            Console.WriteLine("Give Away day");
            Console.Write("Choose \"1\" or \"2\"");
            string userValue=Console.ReadLine();
            //string message = "";
            /*
            if(userValue =="1") 
                message = "You won a boat";
            else if(userValue =="2")
                message = "you won a cat";
            else
            {
                message = "what was that";
                message += "you lose";
            }
            */
            string message = (userValue == "1") ? "boat" : "you lose"; //only for if&else
            Console.WriteLine($"you just won {message}");
        }
    }
}
