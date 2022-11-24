using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace TimeTracker
{

    
    public class Menu
    {
        public void start()
        {
            int choice = -1;

            while (choice != 0)
            {
                WriteMenuText();
                choice = int.Parse(Console.ReadLine());

                switch (choice) //depending on the user's choice, different classes would be triggered
                {
                    case 0:
                    {
                         Environment.Exit(0);
                         break;
                    }
                    case 1:
                    {
                         WholeNumbersForAdd sumObj = new WholeNumbersForAdd();

                         sumObj.Start();
                         break;
                    }
                    case 2:
                    {
                         FloatNumbersWhileAdd sumObj = new FloatNumbersWhileAdd();

                         sumObj.Start();
                         break;
                    }
                    case 3:
                    {
                         CurrencyConverter converter = new CurrencyConverter();

                         converter.Start();
                         break;
                    }
                    case 4:
                    {
                         WorkingSchedule schedule = new WorkingSchedule();

                         schedule.Start();
                         break;
                    }
                    case 5:
                    {
                         TemperatureTable converter = new TemperatureTable();

                         converter.Start();
                         break;
                    }
                }
               


            }
        }

        public void WriteMenuText() //writing out the menu text
        {



            Console.WriteLine("\n-----------------------------------------");
            Console.WriteLine("\t\tMAIN MENU");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("\tWhole Numbers With For \t                 : 1");
            Console.WriteLine("\tFloating Point Numbers With While \t : 2");
            Console.WriteLine("\tCurrency Converter With Do While loop \t : 3");
            Console.WriteLine("\tWork Schedule \t                         : 4");
            Console.WriteLine("\tTemperature Table \t                 : 5");
            Console.WriteLine("\tExit Program \t                         : 0");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Waiting for input: ");
        }
    }
}
