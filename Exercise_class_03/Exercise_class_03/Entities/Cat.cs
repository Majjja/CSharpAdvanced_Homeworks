using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_class_03.Entities
{
    public class Cat : Pet
    {
        public bool isLazy { get; set; }
        public int LivesLeft { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is {(isLazy ? "lazy" : "not lazy")} {Type} and she has {LivesLeft} lives left");
        }
    }
}
