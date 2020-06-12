using AbstractClasses_Interfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses_Interfaces.Entities
{
    class Student : User, IStudent
    {
        public Dictionary<Subject, int> Grades { get; set; } = new Dictionary<Subject, int>();

        public override void Greetings()
        {
            Console.WriteLine($"Hello my name is {Name} and I am a student!");
        }

        public void PrintGrades()
        {
            Console.WriteLine($"Student {Name}, Grades:");
            foreach (var item in Grades)
            {
                Console.WriteLine($"Subject: {item.Key.Name}, Grade: {item.Value}");
            }
        }

    }
}
