using System;

namespace _29___DrawPyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            int number;
            Console.Write("Please give me a number: ");
            number = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j < number -i +1; j++)
                {                   
                    Console.Write(" ");
                }
                for (int b = 1; b <= i; b++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was
        }
    }
}
