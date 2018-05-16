using System;

namespace PrintBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberone;
            int numbertwo;
            numberone = Int32.Parse(Console.ReadLine());
            numbertwo = Int32.Parse(Console.ReadLine());

            if (numberone>numbertwo)
            {
                Console.WriteLine("the first number is bigger");
            }
            else if (numbertwo > numbertwo)
            {
                Console.WriteLine("the second number is bigger");
            }
            else
            {
                Console.WriteLine("the two numbers are even");
            }
            Console.ReadLine();
            // Write a program that asks for two numbers and prints the bigger one
        }
    }
}
