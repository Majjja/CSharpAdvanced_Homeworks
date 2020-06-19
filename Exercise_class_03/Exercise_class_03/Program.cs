using Exercise_class_03.Entities;
using Exercise_class_03.Generics;
using System;
using System.Collections.Generic;

namespace Exercise_class_03
{
    class Program
    {
        public static object ListOfCats { get; private set; }

        static void Main(string[] args)
        {
            #region Exercise
            //      Create 4 classes:
            //  Pet( abstract ) with Name, Type, Age and abstract PrintInfo()
            //  Dog(from Pet) with GoodBoi and FavoriteFood
            //  Cat(from Pet) with Lazy and LivesLeft
            //  Fish(from Pet) with color, size

            //      Create a PetStore generic class with :
            //  Generic list of pets - Dogs, Cats or Fish depending on what is passed as T
            //  Generic method printsPets() - Prints Dogs, Cats or Fish depending on what is passed as T
            //  BuyPet() - Method that takes ‘name’ as parameter, find the first pet by that name, removes it from the list and gives a success message.If there is no pet by that name, inform the customer
            //      Create a Dog, Cat and fish store with 2 pets each
            //  Buy a dog and a cat from the Dog and Cat store
            //  Call PrintPets() method on all stores
            #endregion

            PetStore<Dog> dogStore = new PetStore<Dog>();
            PetStore<Cat> catStore = new PetStore<Cat>();
            PetStore<Fish> fishStore = new PetStore<Fish>();

            dogStore.Insert(new Dog() { Type = "dog", Name = "Nero", Age = 14, isGood = true, FavouriteFood = "chicken" });
            dogStore.Insert(new Dog() { Type = "dog", Name = "Shegy", Age = 10, isGood = true, FavouriteFood = "beaf meat" });
            dogStore.Insert(new Dog() { Type = "dog", Name = "Puppy", Age = 5, isGood = false, FavouriteFood = "eggs" });
            dogStore.Insert(new Dog() { Type = "dog", Name = "Bully", Age = 7, isGood = true, FavouriteFood = "beaf meat" });

            Console.WriteLine("---------All Dogs in Dog Store:---------");
            dogStore.PrintPets();
            dogStore.BuyPet("shegy ");

            catStore.Insert(new Cat() { Type = "cat", Name = "Mario", isLazy = true, LivesLeft = 10, Age = 2 });
            catStore.Insert(new Cat() { Type = "cat", Name = "Luiji", isLazy = false, LivesLeft = 10, Age = 2 });
            catStore.Insert(new Cat() { Type = "cat", Name = "Mimi", isLazy = false, LivesLeft = 9, Age = 3 });


            Console.WriteLine("---------All Cats in Cat Store:---------");
            catStore.PrintPets();
            catStore.BuyPet("Mimi");

            fishStore.Insert(new Fish() { Type = "fish", Name = "Boo", Color = "Blue", Size = 4.3f, Age = 4 });
            fishStore.Insert(new Fish() { Type = "fish", Name = "Loly", Color = "Purple", Size = 3.5f, Age = 3 });
            
            Console.WriteLine("---------All Fishes in Fish Store:---------");
            fishStore.PrintPets();
            fishStore.BuyPet("jiM ");
        }
    }
}
