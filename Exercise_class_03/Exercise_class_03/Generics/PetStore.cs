using Exercise_class_03.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_class_03.Generics
{
    public class PetStore<T> where T : Pet
    {
        private List<T> _listOfPet { get; set; } = new List<T>();

        public void Insert(T animalType)
        {
            _listOfPet.Add(animalType);
        }

        public void PrintPets()
        {
            foreach (T pet in _listOfPet)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(pet.Name);
                Console.ResetColor();
            }
        }

        public string BuyPet(string name)
        {
            name = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            T foundPet = _listOfPet.FirstOrDefault(pet => pet.Name == name.Trim());
            if (foundPet == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Sorry there is no pet by name {name.Trim()}.");
                Console.ResetColor();
                return name;
            }
            else
            {
                _listOfPet.Remove(foundPet);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"You have successfully bought a {foundPet.Type} with name: {foundPet.Name}");
                foundPet.PrintInfo();
                Console.ResetColor();

                Console.WriteLine($"{foundPet.Type} left:");
                PrintPets();
                return foundPet.Name;
            }
            
        }
    }
}
