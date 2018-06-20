using System;
using System.Collections.Generic;
using System.Linq;

namespace GetEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            IEnumerable<int> oddNumbers =
                from number in numbers
                where number % 2 == 0
                select number;

            foreach (int item in oddNumbers)
            {
                Console.WriteLine(item);
            }

            IEnumerable<int> methodOddNumbers = numbers.Where(number => number % 2 == 0).OrderBy(n => n);

            foreach (int item in methodOddNumbers)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
