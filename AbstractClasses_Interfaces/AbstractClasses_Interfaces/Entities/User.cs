using AbstractClasses_Interfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses_Interfaces.Entities
{
    public abstract class User : IUser
    {
        private static int count;
        public User()
        {
            count++;
            Id = count;
        }
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public abstract void Greetings();

        public void PrintUser()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Username: {Username}");
        }
    }
}
