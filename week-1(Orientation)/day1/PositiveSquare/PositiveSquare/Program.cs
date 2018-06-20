using System;
using System.Collections.Generic;
using System.Linq;

namespace PositiveSquare
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a LINQ Expression to get the squared value of the positive numbers from the following array:
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            IEnumerable<int> squarNumbers = from number in numbers
                                            where number > 0
                                            select number * number;

            foreach (var item in squarNumbers)
            {
                Console.WriteLine(item);
            }

            IEnumerable<int> MethodSynSquar = numbers.Where(number => number > 0).Select(number => number * number);

            foreach (int item in MethodSynSquar)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
