using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace TimeTracker
{
    public class WholeNumbersForAdd
    {
        private int numOfInput;
        private int sum;

        public void Start()
        {
            WriteProgramInfo();
            ReadINput();
            SumNumbers();
            ShowResults(); 

            void WriteProgramInfo()
            {
                Console.WriteLine("\n\n Adding whole numbers");
                Console.WriteLine(" Using a for-a statement");
            }

            void ReadINput()
            {
                Console.Write("\n Number of values to sum? ");
                numOfInput = Input.ReadIntegerConsole();
                Console.WriteLine();
                Console.WriteLine("\n Type the numbers you want to get the sum of");
            }

            void SumNumbers()
            {
                int index;
                int num;

                for (index = 0; index < numOfInput; index++)
                {
                    Console.Write(" Please type the value # {0} (whole number):", index+1);
                    num = Input.ReadIntegerConsole();
                    sum += num;
                }
            }

            void ShowResults()
            {
                Console.WriteLine();
                Console.WriteLine("The sum is \t{0}", sum);
            }
        }
    }
}
