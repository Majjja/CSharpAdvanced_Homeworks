using System;
using System.Collections.Generic;

namespace Excercise2_WeekDays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Create a console application that checks if a day is a working day
            //The app should request for a user to enter a date as an input or multiple inputs
            //The app should then open and see if the day is a working day
            //It should show the user a message whether the date they entered is working or not
            //Weekends are not working
            //1 January, 7 January, 20 April, 1 May, 25 May, 3 August, 8 September, 12 October, 23 October and 8 December are not working days as well
            //It should ask the user if they want to check another date
            //Yes - the app runs again
            //No - the app closes
            #endregion

            List<DateTime> notWorkingDays = new List<DateTime>()
            {
                new DateTime(2020,1,1),
                new DateTime(2020,1,7),
                new DateTime(2020,4,20),
                new DateTime(2020,5,1),
                new DateTime(2020,5,25),
                new DateTime(2020,8,3),
                new DateTime(2020,9,8),
                new DateTime(2020,10,12),
                new DateTime(2020,10,23),
                new DateTime(2020,12,8),
            };

            while (true)
            {
                Console.WriteLine("Please enter date:");
                DateTime parsedInput;

                bool userInput = DateTime.TryParse(Console.ReadLine(), out parsedInput);
                if (userInput)
                {
                    var day = parsedInput.DayOfWeek;

                    if (notWorkingDays.Contains(parsedInput))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("It is Holiday - not working day");
                        Console.ResetColor();
                    }
                    else
                    {
                        if (day.Equals(DayOfWeek.Saturday) || day.Equals(DayOfWeek.Sunday))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("It is a weekend day");
                            Console.ResetColor();
                        }
                        else if (day != DayOfWeek.Saturday || day != DayOfWeek.Sunday)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("It is working day");
                            Console.ResetColor();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, you entered an invalid date, please try again");
                    continue;
                }

                Console.WriteLine("Do you want to try again? Yes or No:");
                string user = Console.ReadLine();
                if (user.ToLower() == "yes")
                    continue;
                if (user.ToLower() == "no")
                    break;
            }
        }
    }
}
