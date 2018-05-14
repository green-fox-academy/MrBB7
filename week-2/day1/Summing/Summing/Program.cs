using System;

namespace Summing
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber;
            Console.Write("Please give me a number: ");
            inputNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Sum(inputNumber));
            Console.ReadLine();
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter and returns with an integer
        }
        public static int Sum(int inputNumber)
        {
            int output = 0;
            for (int i = 0; i <= inputNumber; i++)
            {
                output += i;
            }
            return output;
        }
    }
}
