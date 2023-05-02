using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class WorkingWithStrings
    {
        public  void StringMethod()
        {
            //string myString;

            //myString = "My \"MySo Called\" life";
            //myString = "my \n name";
            //myString = "Go to c:\\ drive";
            //myString = @"Go to c:\ drive";
            //myString = string.Format(" {0} = {1}", "First", "Second");
            //myString = string.Format("Currency :{0:C}", 123.45);
            //myString = string.Format("{0:N}", 1234567890);
            //myString = string.Format("Percentage : {0:P}", 0.123);
            //myString = string.Format("Phone Number : {0:(##)-####-###-###}", 918186258278);

            //myString = "That summer we took threes across the board";
            //myString = myString.Substring(6, 14);
            //myString=myString.ToUpper();
            // myString = myString.Replace(" ", "--");
            // myString = myString.Remove(6, 14);
            // myString=string.Format("Leg bef {0} --- leg aft {1}",myString.Length,myString.Trim().Length);
            /*
            string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString+="--"+i.ToString(); //Storage consuming and stressful process
            }
            */

            /*StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);   //Effective
            }
            */
            //Console.WriteLine(myString);
           // Console.ReadLine();
        }
    }
}
