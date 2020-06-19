using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_class_03.Entities
{
    public class Dog : Pet
    {
        public bool isGood { get; set; }
        public string FavouriteFood { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is {(isGood ? "a good" : "not very good")} {Type} and his favourite food is {FavouriteFood}");
        }
    }
}
