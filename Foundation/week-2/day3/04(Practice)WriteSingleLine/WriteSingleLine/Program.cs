using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "my-file.txt";
            WriteFile(path);
            Console.ReadLine();

            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"

        }
        public static void WriteFile(string pathToTxt)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"my-file.txt");
                sw.WriteLine("Bence Balazs");
                sw.Dispose();
                

            }
            catch (Exception)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
         
            }
   
        }

    }
}
