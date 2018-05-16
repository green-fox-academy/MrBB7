using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"mynewfile.txt";
            try
            {
                string[] content = File.ReadAllLines(path);
                int counter = 0;

                foreach (string item in content)
                {
                    counter++;
                }
                Console.WriteLine(counter);
            }
            catch (Exception)
            {
                Console.WriteLine(0);               
            }
            Console.ReadLine();
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.
        }
    }
}
