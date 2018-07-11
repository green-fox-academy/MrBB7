using System;

namespace _26___CountFromTo
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            int diff;
            Console.Write("Please give me the first number: ");
            first = Int32.Parse(Console.ReadLine());
            Console.Write("Please give me the second number: ");
            second = Int32.Parse(Console.ReadLine());

            if (second <= first)
            {
                Console.WriteLine("the second number should be bigger");
            }
            else if ( second > first)
            {
                for (int i = first; i < second-1; i++)
                {
                    first = first + 1;
                    Console.WriteLine(first);
                }
            }
            Console.ReadLine();
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
        }
    }
}
