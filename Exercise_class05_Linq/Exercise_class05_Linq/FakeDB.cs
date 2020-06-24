using Exercise_class05_Linq.Entities;
using Exercise_class05_Linq.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_class05_Linq
{
    public static class FakeDB
    {
        static FakeDB()
        {
            ListOfPersons[0].Dogs.AddRange(new List<Dog>() { ListOfDogs[0], ListOfDogs[5], ListOfDogs[12] });
            ListOfPersons[1].Dogs.AddRange(new List<Dog>() { ListOfDogs[1], ListOfDogs[9] });
            ListOfPersons[2].Dogs.AddRange(new List<Dog>() { ListOfDogs[8] });
            ListOfPersons[3].Dogs.AddRange(new List<Dog>() { ListOfDogs[2] });
            ListOfPersons[4].Dogs.AddRange(new List<Dog>() { ListOfDogs[10], ListOfDogs[7] });
            ListOfPersons[5].Dogs.AddRange(new List<Dog>() { ListOfDogs[3], ListOfDogs[11], ListOfDogs[13] });
            ListOfPersons[6].Dogs.AddRange(new List<Dog>() { ListOfDogs[6] });
            ListOfPersons[7].Dogs.AddRange(new List<Dog>() { ListOfDogs[4] });
        }
        public static List<Dog> ListOfDogs = new List<Dog>()
        {
                new Dog(){Name = "Coco", Color = "White", Age = 3, Race = DogRace.Alaskan_Malamute},
                new Dog(){Name = "Pupy", Color = "Brown", Age = 5, Race = DogRace.Dachshund},
                new Dog(){Name = "Bella ", Color = "Mixed", Age = 2, Race = DogRace.Border_Collie},
                new Dog(){Name = "Archie", Color = "Darkbrown", Age = 1, Race = DogRace.Greyhound},
                new Dog(){Name = "Charlie", Color = "White", Age = 3, Race = DogRace.Dobermann},
                new Dog(){Name = "Max", Color = "Brown", Age = 4, Race = DogRace.American_Eskimo_Dog},
                new Dog(){Name = "Buddy", Color = "White", Age = 4, Race = DogRace.Jack_Russell_Terrier},
                new Dog(){Name = "Oscar", Color = "Black", Age = 7, Race = DogRace.Pyrenean_Shepherd},
                new Dog(){Name = "Toby ", Color = "White", Age = 1, Race = DogRace.Samoyed},
                new Dog(){Name = "Milo", Color = "White", Age = 6, Race = DogRace.Sheltie},
                new Dog(){Name = "Ollie", Color = "Mixed", Age = 3, Race = DogRace.Pyrenean_Mastiff},
                new Dog(){Name = "Lucy", Color = "Darkbrown", Age = 4, Race = DogRace.Labrador_Retriever},
                new Dog(){Name = "Molly", Color = "Black", Age = 3, Race = DogRace.Mudhol_Hound},
                new Dog(){Name = "Ruby", Color = "Darkbrown", Age = 5, Race = DogRace.Dalmatian}

        };
        public static List<Person> ListOfPersons = new List<Person>()
        {
            new Person(){Firstname = "Nathen", Lastname = "Ericson",Age = 33, },
                new Person(){Firstname = "Richard", Lastname = "Brendon",Age = 36},
                new Person(){Firstname = "Erin", Lastname = "Doe",Age = 22},
                new Person(){Firstname = "Ron", Lastname = "Bates",Age = 55},
                new Person(){Firstname = "Freddy", Lastname = "Smith",Age = 40},
                new Person(){Firstname = "Bob", Lastname = "Bobsky",Age = 44},
                new Person(){Firstname = "Amelia", Lastname = "Milver",Age = 18},
                new Person(){Firstname = "Cristofer", Lastname = "Doel",Age = 38}

        };
    }
}
