using System;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            double standard;

            standard = Double.Parse(Console.ReadLine()) % 2;

            if (standard == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            Console.ReadLine();
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.
        }
    }
}
