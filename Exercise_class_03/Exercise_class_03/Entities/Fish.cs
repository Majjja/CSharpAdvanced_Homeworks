using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_class_03.Entities
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public float Size { get; set; }
        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is a {Color} fish with size: {Size}cm");
        }
    }
}
