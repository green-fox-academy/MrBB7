using System;

namespace _27___FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 )
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
            // Write a program that prints the numbers from 1 to 100.
            // But for multiples of three print “Fizz” instead of the number
            // and for the multiples of five print “Buzz”.
            // For numbers which are multiples of both three and five print “FizzBuzz”.
        }
    }
}
