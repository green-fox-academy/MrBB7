using System;

namespace _05_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).

            Console.WriteLine(BunniesInTheEar(Int32.Parse(Console.ReadLine())));
            Console.ReadLine();
        }

        private static int BunniesInTheEar(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                return 2 + (BunniesInTheEar(number - 1));
            }
        }
    }
}
