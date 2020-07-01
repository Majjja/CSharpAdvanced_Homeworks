using QuizApp.Enums;
using QuizApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.DB
{
    public static class DataBase
    {
        public static Dictionary<string, List<string>> MultipleChoiceQuestions = new Dictionary<string, List<string>>()
            {
                { "1. What is the capital of Tasmania?", new List<string>{"a: Dodoma", "b: Hobart *", "c: Launceston", "d: Wellington"}},
                { "2. What is the tallest building in the Republic of the Congo?", new List<string>{ "a: Kinshasa Democratic Republic of the Congo Temple", "b: Palais de la Nation", "c: Kongo Trade Centre", "d: Nabemba Tower *"}},
                { "3. Which of these is not one of Pluto's moons?", new List<string>{ "a: Styx", "b: Hydra", "c: Nix *", "d: Lugia"}},
                { "4. What is the smallest lake in the world?", new List<string>{ "a: Onega Lake", "b: Benxi Lake *", "c: Kivu Lake", "d: Wakatipu Lake"}},
                { "5.  What country has the largest population of alpacas?", new List<string>{ "a: Chad", "b: Peru *", "c: Australia", "d: Niger"}}
            };

        public static List<User> AllUsers { get; set; } = new List<User>()
        {

                new User{Name = "John", Username = "johndoe", Password = "johny123", Type = UserType.Student},
                new User{Name = "Anica", Username = "anica", Password = "AnicaAnica", Type = UserType.Student},
                new User{Name = "Mark", Username = "mark", Password = "mark123", Type = UserType.Student},
                new User{Name = "Stjepan", Username = "stjepan", Password = "step987", Type = UserType.Student},
                new User{Name = "Lokica", Username = "lokica", Password = "lokica567", Type = UserType.Student},
                new User{Name = "Hauser", Username = "hauser", Password = "hauser123", Type = UserType.Teacher},
                new User{Name = "Moreli", Username = "moreli", Password = "morimori8", Type = UserType.Teacher},
                new User{Name = "Markus", Username = "markus", Password = "markus888", Type = UserType.Teacher},
                new User{Name = "Jill", Username = "jill", Password = "jillWein", Type = UserType.Teacher},
                new User{Name = "Novak", Username = "novak", Password = "novak345", Type = UserType.Teacher}

        };
    }
}
