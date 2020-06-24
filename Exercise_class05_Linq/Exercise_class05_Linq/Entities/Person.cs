using System;
using Exercise_class05_Linq.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace Exercise_class05_Linq.Entities
{
    public class Person : IDogandowner
    {
        public Person()
        {
            Dogs = new List<Dog>();
        }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public List<Dog> Dogs { get; set; }

        public void Info()
        {
            Console.WriteLine($"{Firstname} {Lastname}, {Age} years old, Owner of {Dogs.Count} dogs.");
        }
    }
}
