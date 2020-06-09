using System;
using System.Collections.Generic;

namespace Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Create a console application that detect provided names in a provided text
            //The application should ask for names to be entered until the user enteres x
            //After that the application should ask for a text
            //When that is done the application should show how many times that name was included in the text ignoring upper / lower case
            #endregion

            var listOfNames = new List<string>();
            while (true)
            {
                Console.WriteLine("Please enter a name, or if you want to stop enter x:");
                string name = Console.ReadLine();
                if (name == "x")
                    break;
                listOfNames.Add(name.ToLower().Trim());
            }

            foreach (var name in listOfNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Please enter a text:");
            var text = Console.ReadLine().ToLower();

            string[] appeared = text.Split(" ");
            Console.WriteLine("--------------------------------");
            foreach (var name in listOfNames)
            {
                int count = 0;
                foreach (var item in appeared)
                {
                    if (name == item)
                        count++;
                }
                Console.WriteLine($"{name}, found {count} times");
            }

        }
    }
}
