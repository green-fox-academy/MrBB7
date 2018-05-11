using System;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int standard = 5;
            int newNumber;

            Console.WriteLine(" the standard numebr: " +standard);
            newNumber = Int32.Parse(Console.ReadLine());

            if (standard == newNumber)
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
