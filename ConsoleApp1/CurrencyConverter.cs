using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TimeTracker
{
    class CurrencyConverter
    {
        
        private double sum;
        private double inputNum;
        private double exchangeRate;
        private double convertedValue;
        private string currency1;
        private string currency2;

        public void Start()
        {
            WriteProgramInfo();
            ReadINputAndSumNumbers();
            ShowResults();

            void WriteProgramInfo()
            {
                Console.WriteLine("\n\n The currency converter");
                Console.WriteLine(" Using do-while loop");
            }

            void ReadINputAndSumNumbers()
            {
                Console.Write("\n Enter the name of your currency: "); //I decided to add this extra feature, which allows the user to specify the original currency
                currency1 = Console.ReadLine();
                Console.WriteLine("\n Use 0 to finish adding up");

                do
                {
                    Console.Write("\n Please type the values to add to total: ");
                    inputNum = Input.ReadDoubleConsole();
                    sum += inputNum;

                } while (inputNum != 0);

                Console.WriteLine("\n The sum is {0}", sum);

                Console.Write("\n Enter the name of the currency to which you want to convert: ");
                currency2 = Console.ReadLine();

                Console.Write("\n Enter the exchange rate: ");
                exchangeRate = Input.ReadDoubleConsole();

                convertedValue = sum / exchangeRate;


            }

            void ShowResults()
            {
                Console.WriteLine();
                Console.WriteLine("\n {0} {1} is converted to {2} {3} at the rate of {4} {1}/{3}", Math.Round(sum, 3), currency1 , Math.Round(convertedValue, 3), currency2, exchangeRate);
            }
        }
    }
}
