using System;

namespace _10_Refactorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(Int32.Parse(Console.ReadLine())));
            Console.ReadLine();
        }

        private static int Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}
