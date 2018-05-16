using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberForFact;
            Console.Write("Please give me a number: ");
            numberForFact = Int32.Parse(Console.ReadLine());

            Console.WriteLine(factorio(numberForFact));
            Console.ReadLine();
            // - Create a function called `factorio`
            //   that returns it's input's factorial
        }
        public static int factorio(int numberForFact)
        {
            int factored = 1;
            for (int i = 1; i <= numberForFact; i++)
            {
                factored *= i;
            }
            return factored;
        }
    }
}
