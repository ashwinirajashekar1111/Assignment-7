using System;
using System.IO;

namespace ConAppAssignment12_14th_nov_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an operation: \n1. Create\n2. Read\n3. Append\n4. Delete");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter file name:");
                    string createFileName = Console.ReadLine();
                    Console.WriteLine("Enter content:");
                    string createFileContent = Console.ReadLine();
                    CreateFile(createFileName, createFileContent);
                    break;

                case 2:
                    Console.WriteLine("Enter file name to read:");
                    string readFile = Console.ReadLine();
                    ReadFile(readFile);
                    break;

                case 3:
                    Console.WriteLine("Enter file name to append:");
                    string appendFileName = Console.ReadLine();
                    Console.WriteLine("Enter content to append:");
                    string appendContent = Console.ReadLine();
                    AppendToFile(appendFileName, appendContent);
                    break;

                case 4:
                    Console.WriteLine("Enter file name to delete:");
                    string deleteFileName = Console.ReadLine();
                    DeleteFile(deleteFileName);
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        static void CreateFile(string fileName, string content)
        {
            try
            {
                File.WriteAllText(fileName, content);
                Console.WriteLine("File created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating file: {ex.Message}");
            }
        }

        static void ReadFile(string fileName)
        {
            try
            {
                string content = File.ReadAllText(fileName);
                Console.WriteLine($"File content:\n{content}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }

        static void AppendToFile(string fileName, string content)
        {
            try
            {
                File.AppendAllText(fileName, content);
                Console.WriteLine("Content appended successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error appending to file: {ex.Message}");
            }
        }

        static void DeleteFile(string fileName)
        {
            try
            {
                File.Delete(fileName);
                Console.WriteLine("File deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting file: {ex.Message}");
            }
        }
    }
}
