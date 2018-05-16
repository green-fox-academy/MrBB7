using System;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string anotherFile = @"multiplelines.txt";
            string line = "mug";
            int numberOfLine = 5;
            MultipleLineWriter(anotherFile, line, numberOfLine);
            Console.WriteLine(File.ReadAllText(anotherFile));
            Console.ReadLine();
            // Create a function that takes 3 parameters: a path, a word and a number,
            // than it should write to a file.
            // The path parameter should be a string, that describes the location of the file.
            // The word parameter should be a string, that will be written to the file as lines
            // The number paramter should describe how many lines the file should have.
            // So if the word is "apple" and the number is 5, than it should write 5 lines
            // to the file and each line should be "apple"
            // The function should not raise any error if it could not write the file.

        }
        public static void MultipleLineWriter(string filePath, string inputText, int inputNumb )
        {
            
            try
            {
                StreamWriter sw = new StreamWriter(filePath);

                for (int i = 0; i < inputNumb; i++)
                {
                    sw.WriteLine(inputText);
                }
                sw.Dispose();
            }
            catch (Exception)
            {

                Console.WriteLine("an error occured");
            }
        }

    }
}
