using AbstractClasses_Interfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses_Interfaces.Entities
{
    public class Subject : ISubject
    {
        public string Name { get; set; }
        public int Semester { get; set; }
        public string IDE { get; set; }
        public List<Subject> allSubjects { get; set; } = new List<Subject>();

        public void PrintSbjectsBySemester(Subject semester)
        {
            Console.WriteLine($"Semester {semester.Semester}, Subjects:");
            foreach (var subject in allSubjects)
            {
                if (subject.Semester == semester.Semester)
                {
                Console.WriteLine($"***{subject.Name}***");

                }
            }
        }

        public void PrintSubjectInfo()
        {
            Console.WriteLine($"Subject: {Name}, Semester: {Semester}, IDE: {IDE}");
        }
    }
}
