using System;
using System.IO;

namespace ReadWriteOnFileSystem
{
    class Program
    {
        #region Exercise
        //Create a folder called Exercise
        //Create a txt file in it called calculations
        //Create a method that calculates 2 numbers and returns a string in the format: num1 + num2 = result(Ex: 2 + 3 = 5 )
        //Ask the user to enter 2 numbers, call the calculate method and give the result
        //After the result is written in the console it should also be written in the calculations.txt file with a time stamp next to it
        //Call the console 3 times and write 3 results in the txt file
        #endregion
        public static string FolderPath = Path.Combine(@"..\..\..\", "Exercise");
        public static string FilePath = Path.Combine(FolderPath, "Calculations.txt");

        public static void CreateFolder(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        public static void CreateFile(string path)
        {
            if (!File.Exists(path))
                File.Create(path).Close();
        }

        public static void WriteInFile(string path, string text)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(text);
            }
        }

        public static void ReadFromFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("All your calculations:");
                Console.ResetColor();
                Console.WriteLine(sr.ReadToEnd());
            }
        }
        public static string CalculateTwoNumbers(int num1, int num2)
        {
            int result = num1 + num2;
            return $"{num1} + {num2} = {result} --- {DateTime.Now.ToLocalTime()}";
        }

        public static void UserInput()
        {
            int count = 0;
            while (count < 3)
            {
                count++;
                Console.WriteLine("Please enter 2 numbers separated with comma:");
                var numbers = Console.ReadLine();
                if (numbers.Contains(','))
                {
                    string[] nums = numbers.Split(',');
                    int num1;
                    bool parsedFirstNum = int.TryParse(nums[0].Trim(), out num1);
                    int num2;
                    bool parsedSecondNum = int.TryParse(nums[1].Trim(), out num2);

                    if (parsedFirstNum && parsedSecondNum)
                    {
                        string usersCalculation = CalculateTwoNumbers(num1, num2);
                        Console.WriteLine(usersCalculation);
                        WriteInFile(FilePath, usersCalculation);
                    }
                    else Console.WriteLine("You didn't enter numbers.");
                }
                else Console.WriteLine("You should separate numbers with comma.");
            }
            ReadFromFile(FilePath);
        }
        static void Main(string[] args)
        {
            CreateFolder(FolderPath);
            CreateFile(FilePath);
            UserInput();
        }
    }
}
