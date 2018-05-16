using System;

namespace animalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int chickens;
            int pigs;

            chickens = Int32.Parse(Console.ReadLine());
            pigs = Int32.Parse(Console.ReadLine());

            Console.WriteLine(chickens * 2 + pigs * 4);
            Console.ReadLine();
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have
        }
    }
}
