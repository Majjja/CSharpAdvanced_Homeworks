using QuizApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApp.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
        public int Grade { get; set; }
    }
}
