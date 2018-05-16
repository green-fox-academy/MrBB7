using System;
using System.IO;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\GreenFox\MrBB7\week1\day2\greenfox\MrBB7\week-2\day3\CopyFile\myfile.txt";
            WriteFile(path);
            ReadFile(path);
            Console.ReadLine();
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
        }
        public static string WriteFile(string path)
        {
            File.WriteAllText(path, "Bence Balazs");
            return path;
        }
        public static string ReadFile(string path)
        {
            Console.WriteLine(File.ReadAllText(path));
            return path;
        }
    }
}
