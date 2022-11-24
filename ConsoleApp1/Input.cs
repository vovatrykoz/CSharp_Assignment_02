using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTracker
{
    public class Input
    {
        public static int ReadIntegerConsole()
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Wrong input. Please, try again");
                return ReadIntegerConsole();
            }
            
        }

        public static double ReadDoubleConsole()
        {
            double input;
            if (double.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("Wrong input. Please, try again");
                return ReadDoubleConsole();
            }

        }



    }
}
