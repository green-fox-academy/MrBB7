using System;

namespace Secondsinaday
{
    class Program
    {
        private const int V = 60;

        static void Main(string[] args)
        {
            int currentHours;
            int currentMinutes;
            int currentSeconds;
             currentHours = Int32.Parse(Console.ReadLine());
             currentMinutes = Int32.Parse(Console.ReadLine());
             currentSeconds = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            int remainingHours = 24 - currentHours;
            int remainingMinutes = 60 - currentMinutes;
            int remainingSeconds = 60 - currentSeconds;

            Console.WriteLine("Remaining seconds from the day: " +((remainingHours * 60 * 60)+(currentMinutes * 60) + currentSeconds ));
            Console.ReadLine();
            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables
            //made the original task as well but decided to play with this variation too :)
        }
    }
}
