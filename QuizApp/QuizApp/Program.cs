﻿using QuizApp.DB;
using QuizApp.Enums;
using QuizApp.Helpers;
using QuizApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Quizz App ✍
            //A school is requesting a quizz app to be developed so that the students can log in, 
            //answer questions and get an automatic grade.
            //The students can only solve the quizz once and the teachers can see the results of all the quizzes.

            //Features 🔹
            //Log in
            //  A student or a teacher can log in
            //  Usernames and passwords should be predefined(created before hand in the system)

            //Student logs in
            //  A quiz pops up with 5 multiple choice questions(4 choices)
            //  After the student picks a choice on the 5 answers a grade apears from 1 to 5
            //  After that the user is loged out and another user can log in
            //  If the same student tries to log in, it should say that they already did the test and log them out

            //Teacher logs in
            //  All students that did the quiz and have a grade show up in green
            //  all the students that did not do the quiz show up in red
            //  When hitin enter it logs out the teacher and another user can log in

            //Validations
            //  All the choices must be numbers from 1 to 4
            //  Username must exist in the database
            //  Username and Password must match
            //  If the username and password do not match 3 times, then close the application

            //Data 🔹

            //1. Q: What is the capital of Tasmania?
            //  a: Dodoma
            //  b: Hobart *
            //  c: Launceston
            //  d: Wellington

            //2. Q: What is the tallest building in the Republic of the Congo?
            //  a: Kinshasa Democratic Republic of the Congo Temple
            //  b: Palais de la Nation
            //  c: Kongo Trade Centre
            //  d: Nabemba Tower *

            //3. Q: Which of these is not one of Pluto's moons?
            //  a: Styx
            //  b: Hydra
            //  c: Nix *
            //  d: Lugia

            //4. Q: What is the smallest lake in the world?
            //  a: Onega Lake
            //  b: Benxi Lake *
            //  c: Kivu Lake
            //  d: Wakatipu Lake

            //5. Q: What country has the largest population of alpacas?
            //  a: Chad
            //  b: Peru *
            //  c: Australia
            //  d: Niger
            #endregion

            int count = 0;
            User user;
            User check;
            var listOfLogedUsers = new List<User>();
            while (true)
            {
                Console.WriteLine("Please enter username:");
                string username = Console.ReadLine();

                if (username == "exit")
                    break;

                Console.WriteLine("Please enter password:");
                string password = Console.ReadLine();

                check = listOfLogedUsers.SingleOrDefault(x => x.Username == username && x.Password == password);

                if (check != null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You already did the test. Have a nice day!");
                    Console.ResetColor();
                    continue;
                }

                user = DataBase.AllUsers.SingleOrDefault(x => x.Username == username && x.Password == password);

                if (user == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry. wrong username or password. Please try again.");
                    Console.ResetColor();
                    count++;
                    if (count == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You cross the limit");
                        Console.ResetColor();
                        break;
                    }
                    continue;
                }

                if (user.Type == UserType.Student)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Hello {user.Name}, Welcome to the quiz!");
                    Console.ResetColor();

                    listOfLogedUsers.Add(user);
                    UserHelper.GetQuiz();

                    Console.WriteLine("Pick the right answers:");

                    string usersAnswers = Console.ReadLine();

                    user.Grade = UserHelper.CheckAnswers(usersAnswers);
                    continue;
                }
                if (user.Type == UserType.Teacher)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Hello teacher {user.Name}, Here are the results:");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("----------Students that did the quiz:----------");
                    listOfLogedUsers.ForEach(user => Console.WriteLine($"Name: {user.Name}, Grade: {user.Grade}"));
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("----------Students that didn't do the quiz:----------");
                    var studentsDidNotDoQuiz = DataBase.AllUsers.Where(s => s.Type == UserType.Student).Except(listOfLogedUsers).ToList();
                    studentsDidNotDoQuiz.ForEach(s => Console.WriteLine(s.Name));
                    Console.ResetColor();

                    Console.ReadLine();

                }
            }
        }
    }
}
