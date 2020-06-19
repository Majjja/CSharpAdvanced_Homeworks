using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_class_02.Entities
{
    public static class DogShelter
    {
        public static List<Dog> ListOfDogs { get; set; } = new List<Dog>();

        public static void PrintAll() 
        {
            foreach (var dog in ListOfDogs)
            {
                Console.WriteLine(dog);
            }
        }
    }
}
