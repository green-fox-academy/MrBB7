using System;

namespace _06_BunniesDeNuevo
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
            // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
            // have 3 ears, because they each have a raised foot. Recursively return the
            // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).

            Console.WriteLine(BunniesInTheEar(Int32.Parse(Console.ReadLine())));
            Console.ReadLine();

        }

        public static int BunniesInTheEar(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else if (number % 2 == 0)
            {
                return 3 + (BunniesInTheEar(number - 1));
            }
            else
            {
                return 2 + (BunniesInTheEar(number - 1));
            }
        }
    }
}
