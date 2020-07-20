using Serialization_Deserialization.Entities;
using Serialization_Deserialization.Services;
using System;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace Serialization_Deserialization
{
    class Program
    {

        static void Main(string[] args)
        {
            #region MyRegion
            //Create a Dog class with :
            //Name, Age, Color
            //Let the user input these parameters from a console application
            //Create a new Dog object from the inputs and write it as a json in a new file on the file system
            //Create a method that reads and prints in the console all the dogs from the txt file
            #endregion
            
            string name;
            int age;
            string color;
            while (true)
            {
                DogServices.CreateFolder();
                DogServices.CreateFile();

                Console.WriteLine("Enter dog's name:");
                name = Console.ReadLine();

                Console.WriteLine("Enter dog's age:");
                bool parsed = int.TryParse(Console.ReadLine(), out age);
                if (!parsed)
                {
                    Console.WriteLine("You didn't enter a number for Age. Please try again!");
                    continue;
                }

                Console.WriteLine("Enter dog's color:");
                color = Console.ReadLine();
                DogServices.Insert(new Dog(name, age, color));

                Console.WriteLine("If you want to continue press: \"Enter\", otherwise: \"Exit\"");
                string user = Console.ReadLine();
                if (user.ToLower() == "exit")
                {
                    DogServices.PrintAllDogs();
                    break;
                }
            }

            Console.WriteLine("Do you want to clear the file? Y / N");
            if (Console.ReadLine().ToLower() == "y")
            {
                DogServices.ClearFile();
            }
        }
    }
}
