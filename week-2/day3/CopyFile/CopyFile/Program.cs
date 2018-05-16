using System;
using System.IO;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"myfile.txt";
            string pathCopy = @"copied.txt";
            CopyFile(path, pathCopy);
            Console.ReadLine();
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
        }
        public static bool CopyFile(string pathOrigi, string pathNew)
        {
            try
            {
                string[] content = File.ReadAllLines(pathOrigi);
                StreamWriter sw = new StreamWriter(pathNew);
                foreach (char item in pathOrigi)
                {
                    sw.WriteLine(item);
                }
                sw.Dispose();
                return true;
            }
            catch (Exception)
            {

                Console.WriteLine(" an error has ocurred");
                return false;
            }
        }
    }
}
