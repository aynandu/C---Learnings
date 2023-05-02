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

       public  decimal DetermineMarketValue(Car car)
        {
            decimal carValue ;
            if (Year>2000)
                return carValue = 2000.0M;
            else 
                return carValue = 1000.0M;
        }
    }
}
