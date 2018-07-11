using System;

namespace DevideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please give me a number: ");
            int divisor = Int32.Parse(Console.ReadLine());

            Console.WriteLine(TakingANumber(divisor));
            Console.ReadLine();
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0
        }
        public static string TakingANumber(int divisorTen)
        {
            double basicDiv = 10;
            try
            {
                basicDiv = basicDiv / divisorTen;
                return basicDiv.ToString();
            }
            catch (DivideByZeroException e)
            {
                return e.ToString();
            }
        }
    }
}
