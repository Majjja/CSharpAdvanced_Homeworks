using System;
using System.IO;

namespace CustomReaderWriter
{
    class Program
    {
        public static string FolderPath = Path.Combine(@"..\..\..\", "Text");
        public static string FilePath = Path.Combine(FolderPath, "text.txt");
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

        public static void WriteTextInFile(string path, string text)
        {
            CustomWriter cw = new CustomWriter(path);
            cw.WriteInFile(text);
            cw.Dispose();
        }

        public static void ReadTextFromFile(string path)
        {
            using (CustomReader cr = new CustomReader(path))
            {
                cr.ReadFromFile();
            }
        }
        public static void WriteAndReadInFile()
        {
            try
            {
                Console.WriteLine("Please enter text for pt1:");
                string text1 = Console.ReadLine();
                WriteTextInFile(FilePath, text1);

                Console.WriteLine("Please enter text for pt1:");
                string text2 = Console.ReadLine();
                WriteTextInFile(FilePath, text2);

                Console.WriteLine("Please enter text for pt1:");
                string text3 = Console.ReadLine();
                WriteTextInFile(FilePath, text3);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem in the writing file");
                Console.WriteLine(ex.Message);
            }

            Console.Clear();
            Console.WriteLine("---------------You entered:---------------");
            try
            {
                ReadTextFromFile(FilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem in the reading from file");
                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {
            CreateFolder(FolderPath);
            CreateFile(FilePath);
            WriteAndReadInFile();
        }
    }
}
