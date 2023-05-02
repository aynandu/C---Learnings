using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class WhileIlteration
    {
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("\nGame yard");
            Console.WriteLine("Option 1");
            Console.WriteLine("Option 2");
            Console.WriteLine("3 to Exit");
            string guessedNumber = Console.ReadLine();
            if (guessedNumber == "1")
            {
                PrintNumber();
                return true;
            }
            else if (guessedNumber == "2")
            {
                GuessingNumber();
                return true;
            }
            else if (guessedNumber == "3")
                return false;
            else
            {
                Console.WriteLine("Give Correct Input");
                return true;
            }
                
        }
        private static void PrintNumber()
        {
            Console.Clear();
            Console.WriteLine("Print Number");
            int number = int.Parse(Console.ReadLine());
            int i = 1;
            while (number+1 > i) 
            { 
                Console.Write(i);
                Console.Write("-");
                i++
;            }
            Console.ReadLine();
        }
        private static void GuessingNumber()
        {
            Console.Clear();
            Console.WriteLine("Gussing Game");
            Console.WriteLine("Gusses a Number");
            int guesses = 0;
            bool incorrect = true;
            Random myRandum = new Random();
            int randomNumber = myRandum.Next(1,11);
     
            do
            {
                string number = Console.ReadLine();
                if(number == randomNumber.ToString())
                    incorrect = false;
                else
                {
                    Console.WriteLine("wrong");
                }
                guesses++;
            } while (incorrect);
            Console.WriteLine($"Your Guesses was correct, total gueesse {guesses}");
            Console.ReadLine();
        }
        public void DisplayMenu()
        {
            bool display = true;
            while(display)
            {
                display = MainMenu();
            }
        }
    }
}
