using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTracker
{
    public class TemperatureTable
    {

        private int numOfInput; //will be used to ask user how many values to convert
        private double originalTemperature; //will be used to record the input from the user
        private double convertedTemperature; //will be used to convert the input
        private bool toCelcius; //determins if we are converting to Celcius or Fahrenheit

        public void Start()
        {
            WriteProgramInfo();
            ReadInput();
            if (toCelcius == true) //depending on the user choice, the conversion will either go from C to F or from F to C
            {
                ConvertValuesToCelcius();

                Console.WriteLine(); //just leaving some empty space
            }
            else
            {
                ConvertValuesToFahrenheit();
               
                Console.WriteLine(); //just leaving some empty space
            }

            void WriteProgramInfo()
            {
                Console.WriteLine("\n\n The temperature converter"); //Wrties the program info out
            }

            void ReadInput()
            {
                string converterChoice;
                
                Console.WriteLine(" Type the unit FROM which you want to convert (Using first letters, such as C or F)");
                Console.Write(" ");
                converterChoice = Console.ReadLine(); //tracks the way user wants the values to be converted

                if (converterChoice == "C" || converterChoice == "c")  //sets the toCelcius to differnt values, depending on which different methods will start (see lines 19-30)
                {
                    toCelcius = false;
                }
                else if (converterChoice == "F" || converterChoice == "f")
                {
                    toCelcius = true;
                }
                else
                {
                    Console.WriteLine("Wrong input. Please, try again!");

                    ReadInput();
                }

                Console.Write("\n Number of values to convert? ");
                numOfInput = Input.ReadIntegerConsole(); //reads how many values the user would like to convert.
                Console.WriteLine();
                Console.WriteLine("\n Fill out numbers the numbers you want to convert");
                Console.WriteLine("\n-----------------------------------------");
                if (toCelcius == true) //displays different headings depending on the conversion type
                {
                    Console.WriteLine("\tTABLE FAHRENHEIT TO CELCIUS");
                }
                else
                {
                    Console.WriteLine("\tTABLE CELCIUS TO FAHRENHEIT");
                }

                Console.WriteLine("-----------------------------------------");
            }

            void ConvertValuesToCelcius()
            {
                int index; //variable used to track which cycle the program is on

                /*
                In this case se don't know how many values the user would like to convert. 
                If we are using while we would force the user to input some value to stop the cycle, and it would be difficult to do that, since the temperature values could vary greatly

                */

                for (index = 0; index < numOfInput; index++)
                {
                    Console.Write("\n\n\t "); //leaves some space

                    originalTemperature = Input.ReadDoubleConsole(); //records the temperature given by the user
                    convertedTemperature = ((originalTemperature - 32)*5)/9; //cconverts the temperature according to the formula

                    Console.SetCursorPosition(0, Console.CursorTop - 1); //allows to re-write the existing line, instead of moving everything to a new one, making the program tidier
                                        
                    Console.Write("\r\t {0},00°F\t = \t{1}°C", Math.Round(originalTemperature, 0), Math.Round(convertedTemperature, 2)); //displays the values, rounded up in the way shown in the screenshot
                }
            }

            void ConvertValuesToFahrenheit()
            {
                int index;

                for (index = 0; index < numOfInput; index++)
                {
                    Console.Write("\n\n\t "); //leaves some space

                    originalTemperature = Input.ReadDoubleConsole(); //records the temperature given by the user
                    convertedTemperature = (1.8 * originalTemperature) + 32; //cconverts the temperature according to the formula

                    Console.SetCursorPosition(0, Console.CursorTop - 1); //allows to re-write the existing line, instead of moving everything to a new one, making the program tidier

                    Console.Write("\r\t {0},00°C\t = \t{1}°F", Math.Round(originalTemperature, 0), Math.Round(convertedTemperature, 2)); //displays the values, rounded up in the way shown in the screenshot
                }
            }
        }
    }
}
