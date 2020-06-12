using AbstractClasses_Interfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses_Interfaces.Entities
{
    class Teacher : User, ITeacher
    {
        public List<Subject> Subjects { get; set; } = new List<Subject>();

        public override void Greetings()
        {
            Console.WriteLine($"Hello my name is {Name} and I am a teacher!");
        }

        public void PrintSubjects()
        {
            Console.WriteLine($"Teacher: {Name}");
            foreach (var subject in Subjects)
            {
                Console.WriteLine(subject.Name);
            }
        }
    }
}
