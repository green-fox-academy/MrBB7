using System;

namespace _24___PrintEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            for (int i = 0; i < 250; i++)
            {
                number = number + 2;
                Console.WriteLine(number);
            }
            Console.ReadLine();
            // Create a program that prints all the even numbers between 0 and 500
        }
    }
}
