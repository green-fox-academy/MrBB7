using System;

namespace _33___GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 8;
            int guess;
            do
            {
                Console.Write("Guess the number: ");
                guess = Int32.Parse(Console.ReadLine());

                if (guess > number)
                {
                    Console.WriteLine("the number is smaller than this");
                }
                else if (number > guess)
                {
                    Console.WriteLine("the number is bigger than this");
                }
                else
                {
                    Console.WriteLine("you found the number: {0}", number);
                }
            } while (number != guess);
            Console.ReadLine();
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8
        }
    }
}
