using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTracker
{
    public class WorkingSchedule
    {
        public void Start()
        {

            int choice = -1; //introducing a similar setup as in the Menu.cs

            while (choice != 0)
            {
                WritesecondaryMenuText();
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        {
                            Menu menu = new Menu(); 
                            menu.start(); //causes the return to the main manu
                            break;
                        }
                    case 1:
                        {

                            WeekendsToWork(); //calls upon the method which shows how many weeks the user has to work on weekends
                            break;
                        }
                    case 2:
                        {
                            NightsToWork(); //calls upon the method which shows how many weeks the user has to work on night shifts

                            break;
                        }
                }



            }


            void WritesecondaryMenuText()
            {
                Console.WriteLine("\n-----------------------------------------");
                Console.WriteLine("\tYOUR SCHEDULE PROGRAM");
                Console.WriteLine("Select which type of schedule you want to see");
                Console.WriteLine("-----------------------------------------");

                Console.WriteLine("\tShow a list of weekends to work \t                 : 1");
                Console.WriteLine("\tShow a list of night shifts to work \t                 : 2");
                Console.WriteLine("\tReturn to Main Menu \t                                 : 0"); //Writing out the menu text
            }

            void WeekendsToWork()
            {
                Console.WriteLine(" Your choice: 1 \n");

                int workingWeek = 1; //variable that sets the starting week at 1
                int numOfCycles = 0; //this variable will be counting the number of cycles that have passed in order to make the schedule more comprehensible (explained in more detail on line 78)

                /*
                 Since we are told to assume that there are 52 weeks in a year, we know exactly when the cycle would end
                 The schedule is limited to a year, thus it would make sense to use do-while, rather than ask user to specify the amount of weeks or ask user to abrupt the cycle themselves
                 */

                do
                {
                    Console.Write("\t Week {0}   ", workingWeek); //displays a week during which the user will be working
                    workingWeek = workingWeek+3; //adds the pre-defined interval of 3
                    numOfCycles = numOfCycles + 1; //counts the nuber of cycles

                    if (numOfCycles == 6 || numOfCycles == 12 || numOfCycles == 18)
                    {
                        Console.WriteLine(); //after a certain amount of cycles, the text will be shifted to a new line, so it would look prettier
                    }

                } while (workingWeek !<= 52); //ends the cycle once we go beyond 52
            }

            void NightsToWork()
            {
                Console.WriteLine(" Your choice: 2 \n");

                int workingWeek = 6; //variable that sets the starting week at 1
                int numOfCycles = 0; //this variable will be counting the number of cycles that have passed in order to make the schedule more comprehensible (explained in more detail on line 102)

                // Same logic as in the comment on line 66


                do
                {
                    Console.Write("\t Week {0}   ", workingWeek); //displays a week during which the user will be working
                    workingWeek = workingWeek + 5; //adds the pre-defined interval of 5
                    numOfCycles = numOfCycles + 1; //counts the nuber of cycles

                    if (numOfCycles == 6 || numOfCycles == 12)
                    {
                        Console.WriteLine(); //after a certain amount of cycles, the text will be shifted to a new line, so it would look prettier
                    }
                } while (workingWeek! <= 52); //ends the cycle once we go beyond 52
            }

        }
    }
}
