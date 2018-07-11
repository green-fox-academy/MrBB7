using System;

namespace _30___DrawDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Please give me the number: ");
            number = Int32.Parse(Console.ReadLine());

            if (number % 2 != 0)
            {
                for (int i = 1; i <= (number / 2) + 1; i++)
                {
                    for (int j = 0; j < (number - i); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    for (int k = 1; k < i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int i = (number) / 2; i >= 1; i--)
                {
                    for (int j = 0; j < (number - i); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    for (int k = 1; k < i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 1; i <= (number / 2); i++)
                {
                    for (int j = 0; j < (number - i); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    for (int k = 1; k < i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int i = ((number) / 2); i >= 1; i--)
                {
                    for (int j = 0; j < (number - i); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    for (int k = 1; k < i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
  
                                   // Write a program that reads a number from the standard input, then draws a
                                   // diamond like this:
                                   //
                                   //
                                   //    *
                                   //   ***
                                   //  *****
                                   // *******
                                   //  *****
                                   //   ***
                                   //    *
                                   //
                                   // The diamond should have as many lines as the number was
            }
            Console.ReadLine();
        }
    }
}
