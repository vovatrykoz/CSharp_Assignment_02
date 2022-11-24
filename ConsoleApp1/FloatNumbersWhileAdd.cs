using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTracker
{
    public class FloatNumbersWhileAdd
    {
        private double sum;

        public void Start()
        {
            WriteProgramInfo();
            ReadINputAndSumNumbers();
            ShowResults();

            void WriteProgramInfo()
            {
                Console.WriteLine("\n\n Adding real numbers");
                Console.WriteLine(" Using while loop");
                Console.WriteLine("\n Write 0 to finish input");
            }

            void ReadINputAndSumNumbers()
            {
                bool done = false;
                double inputNum;

                while (!done)
                {
                    Console.Write("\n Please type the values :");
                    inputNum = Input.ReadDoubleConsole();

                    if ((Math.Round(inputNum, 7) == 0))
                    {
                        done = true;
                    }
                    else
                    {
                        sum += inputNum;
                    }
                    
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
