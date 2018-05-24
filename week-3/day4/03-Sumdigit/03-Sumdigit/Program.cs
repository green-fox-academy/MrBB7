using System;

namespace _03_Sumdigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a non-negative int n, return the sum of its digits recursively (no loops). 
            // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
            // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).

            Console.WriteLine(FirstSumdigit(Int32.Parse(Console.ReadLine())));
            Console.ReadLine();

        }

        public static int FirstSumdigit(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                return (number % 10 + FirstSumdigit(number / 10));
            }
        }
    }
}
