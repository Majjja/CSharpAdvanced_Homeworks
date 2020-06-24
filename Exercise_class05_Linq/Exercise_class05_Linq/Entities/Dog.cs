using System;
using Exercise_class05_Linq.Enums;
using Exercise_class05_Linq.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace Exercise_class05_Linq.Entities
{
    public class Dog : IDogandowner
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public DogRace Race { get; set; }

        public void Info()
        {
            Console.WriteLine($"Name: {Name}, Color: {Color}, Age: {Age}, Race: {Race}");
        }
    }
}
