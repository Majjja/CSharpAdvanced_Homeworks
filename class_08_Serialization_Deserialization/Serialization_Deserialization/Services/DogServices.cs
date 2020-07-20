using Newtonsoft.Json;
using Serialization_Deserialization.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Serialization_Deserialization.Services
{
    public static class DogServices
    {

        private static string _folderPath = Path.Combine(@"..\..\..\", "JSON");
        private static string _filePath = Path.Combine(_folderPath, "Json.txt");

        public static void CreateFolder()
        {
            if (!Directory.Exists(_folderPath))
                Directory.CreateDirectory(_folderPath);
        }

        public static void CreateFile()
        {
            if (!File.Exists(_filePath))
                File.Create(_filePath).Close();
        }
        public static bool WriteInFile(List<Dog> dogs)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_filePath))
                {
                    string data = JsonConvert.SerializeObject(dogs);
                    sw.WriteLine(data);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[ERROR]: {ex.Message}");
                Console.ResetColor();
                return false;
            }
        }

        public static List<Dog> ReadFromFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_filePath))
                {
                    string data = sr.ReadToEnd();
                    List<Dog> dogs = JsonConvert.DeserializeObject<List<Dog>>(data);
                    return dogs;
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[ERROR]: {ex.Message}");
                Console.ResetColor();
                return null;
            }
           
        }

        public static void PrintAllDogs()
        {
            List<Dog> dogs = ReadFromFile();

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var dog in dogs)
            {
                Console.WriteLine($"Name: {dog.Name} | Age: {dog.Age} | Color: {dog.Color}");
            }
            Console.ResetColor();
        }

        public static void Insert(Dog dog)
        {
            try
            {
                List<Dog> data = ReadFromFile();

                if (data == null)
                    data = new List<Dog>();

                data.Add(dog);
                WriteInFile(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ClearFile()
        {
            WriteInFile(new List<Dog>());
        }
    }
}
