using AbstractClasses_Interfaces.Entities;
using System;

namespace AbstractClasses_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instances from class Subject
            var subject1 = new Subject() { Name = "HTML", Semester = 1, IDE = "SublimeText3", };
            var subject2 = new Subject() { Name = "CSS", Semester = 1, IDE = "SublimeText3", };
            var subject3 = new Subject() { Name = "JS Basic", Semester = 1, IDE = "VS Code", };
            var subject4 = new Subject() { Name = "JS Advanced", Semester = 1, IDE = "VS Code", };
            var subject5 = new Subject() { Name = "C# Basic", Semester = 2, IDE = "VS 2019", };
            var subject6 = new Subject() { Name = "C# Advanced", Semester = 2, IDE = "VS 2019", };

            var allSubjects = new Subject() { allSubjects = { subject1, subject2, subject3, subject4, subject5, subject6 } };
            
            allSubjects.PrintSbjectsBySemester(subject1);
            Console.WriteLine("-----------------------------------------------------");
            subject6.PrintSubjectInfo();

            //Instances from class Student
            var student1 = new Student()
            {
                Name = "Maja",
                Username = "Maja123",
                Password = "123",
                Grades =
                {
                    { subject1, 5},{subject2, 5},
                    { subject3, 5}, { subject4, 5},
                    { subject5, 5},{ subject6, 5}
                },
            };
            var student2 = new Student()
            {
                Name = "Ljupco",
                Username = "Ljupco123",
                Password = "123",
                Grades =
                {
                    { subject1, 5},{subject2, 5},
                    { subject3, 5}, { subject4, 5},
                    { subject5, 5},{ subject6, 5}
                },
            };

            Console.WriteLine("-----------------------------------------------------");
            student2.Greetings();
            Console.WriteLine("-----------------------------------------------------");
            student1.PrintGrades();
            Console.WriteLine("-----------------------------------------------------");
            student1.PrintUser();
            Console.WriteLine("-----------------------------------------------------");

            //Instances from class Teacher
            var teacher1 = new Teacher()
            {
                Name = "Goce",
                Username = "Goce123",
                Password = "123",
                Subjects = { subject5, subject6 }
            };
            var teacher2 = new Teacher()
            {
                Name = "Ivan",
                Username = "Ivan123",
                Password = "123",
                Subjects = { subject6 }
            };

            teacher1.PrintUser();
            Console.WriteLine("-----------------------------------------------------");
            teacher1.PrintSubjects();
            Console.WriteLine("-----------------------------------------------------");
            teacher2.Greetings();
            Console.WriteLine("-----------------------------------------------------");

        }
    }
}
