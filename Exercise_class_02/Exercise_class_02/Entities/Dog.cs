using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_class_02.Entities
{
    public class Dog
    {
        public Dog()
        {

        }
        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Color: {Color}";
        }

        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }

        private static bool Validate(Dog dog)
        {
            if (dog.Id <= 0 || string.IsNullOrWhiteSpace(dog.Name) || string.IsNullOrWhiteSpace(dog.Color))
                return false;
            else
                return true;
        }

        public static void Insert(Dog dog)
        {
            if (Validate(dog))
                DogShelter.ListOfDogs.Add(dog);
        }
    }
}
