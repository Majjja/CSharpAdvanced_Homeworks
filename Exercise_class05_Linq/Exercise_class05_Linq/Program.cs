using Exercise_class05_Linq.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_class05_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfPersons = FakeDB.ListOfPersons;
            var listOfDogs = FakeDB.ListOfDogs;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---Persons Names starting with 'R', ordered by Age - DESCENDING ORDER---");
            Console.ResetColor();

            //Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
            List<Person> personNameStartswithR = listOfPersons
                .Where(n => n.Firstname.StartsWith('R'))
                .OrderByDescending(n => n.Age)
                .ToList();

            personNameStartswithR.ForEach(x => Console.WriteLine($"{x.Firstname} - {x.Age} years old."));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---Brown dogs older than 3 years, ordered by Age - ASCENDING ORDER---");
            Console.ResetColor();

            //Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
            List<Dog> brownDogsOlderThen3 = listOfDogs
                .Where(d => d.Color == "Brown" && d.Age > 3)
                .OrderBy(d => d.Age)
                .ToList();

            brownDogsOlderThen3.ForEach(x => x.Info());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---Persons with more than 2 dogs, ordered by Name - DESCENDING ORDER---");
            Console.ResetColor();

            //Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
            List<Person> personsWithMoreThen2Dogs = listOfPersons
                .Where(x => x.Dogs.Count > 2)
                .OrderByDescending(x => x.Firstname)
                .ToList();

            personsWithMoreThen2Dogs.ForEach(x => x.Info());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---Freddy`s dogs older than 1 year---");
            Console.ResetColor();

            //Find and print all Freddy`s dogs names older than 1 year
            List<string> freddysDogs = listOfPersons
                .Where(x => x.Firstname == "Freddy")
                .SelectMany(x => x.Dogs)
                .Where(x => x.Age > 1)
                .Select(x => x.Name)
                .ToList();

            freddysDogs.ForEach(x => Console.WriteLine(x));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---Nathen`s first dog---");
            Console.ResetColor();

            //Find and print Nathen`s first dog
            Dog nathensFirstDog = listOfPersons
                .Where(x => x.Firstname == "Nathen")
                .SelectMany(x => x.Dogs)
                .FirstOrDefault();

            nathensFirstDog.Info();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---White dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER---");
            Console.ResetColor();

            //Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER
            List<string> allDogsNames = listOfPersons
                .Where(x => x.Firstname == "Cristofer" || x.Firstname == "Freddy" || x.Firstname == "Erin" || x.Firstname == "Amelia")
                .SelectMany(x => x.Dogs)
                .Where(x => x.Color == "White")
                .OrderBy(x => x.Name)
                .Select(x => x.Name)
                .ToList();
            allDogsNames.ForEach(x => Console.WriteLine(x));
        }
    }
}
