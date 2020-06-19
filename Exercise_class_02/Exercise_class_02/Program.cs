using Exercise_class_02.Entities;
using System;

namespace Exercise_class_02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise
            //Create a class called Dog that has:
            //      Id, Name, Color, Bark() - Prints “Bark Bark”
            //      A static method Validate() - Checks if dog has all 3 properties, 
            //   if Id is not less than 0 and Name is 2 characters or longer

            //Create a static class called DogShelter that has:
            //      List of Dogs
            //      PrintAll() - prints all dogs from List of Dogs
            //Create 3 Dog objects, call validate on them to see if they are okay, 
            //add them in the List of Dogs and call PrintAll()
            #endregion

            var nero = new Dog(1, "Nero", "Black");
            var kim = new Dog(2, "Kim", "Ochkre");
            var jeki = new Dog(3, "Jeki", null);
            var sharko = new Dog(4, "Sharko", "");
            var jo = new Dog(5, null, "Mixed");
            var sparky = new Dog(0, "Sparky", "Brown");
            var bo = new Dog(7, "Bo", "White");


            nero.Bark();
            Console.WriteLine("-------------------------------------");
            Dog.Insert(nero);
            Dog.Insert(kim);
            Dog.Insert(jeki);
            Dog.Insert(sharko);
            Dog.Insert(jo);
            Dog.Insert(sparky);
            Dog.Insert(bo);

            Console.WriteLine(nero.ToString());
            Console.WriteLine("-------------------------------------");
            DogShelter.PrintAll();

        }
    }
}
