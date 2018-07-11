using System;

namespace _28___DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Give me a number: ");
            number = Int32.Parse(Console.ReadLine());
            string temp = "";

            for (int i = 0; i < number+1; i++)
            {
                temp += "*";
                Console.WriteLine(temp);
            }
            Console.ReadLine();
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was
        }
    }
}
