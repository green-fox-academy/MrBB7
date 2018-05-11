using System;

namespace OneTwoALot
{
    class Program
    {
        static void Main(string[] args)
        {

            int standard;
            standard = Int32.Parse(Console.ReadLine());
            if (standard <= 0)
            {
                Console.WriteLine("Not enough");
            }
            else if (standard == 1)
            {
                Console.WriteLine("One");
            }
            else if (standard == 2)
            {
                Console.WriteLine("Two");
            }
            else
            {
                Console.WriteLine("A lot");
            }
            Console.ReadLine();
            // Write a program that reads a number form the standard input,
            // If the number is zero or smaller it should print: Not enough
            // If the number is one it should print: One
            // If the number is two it should print: Two
            // If the number is more than two it should print: A lot
        }
    }
}
