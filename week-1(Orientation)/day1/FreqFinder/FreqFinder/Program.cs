using System;
using System.Linq;
using System.Collections.Generic;

namespace FreqFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of numbers in the following array:

            int[] numbers = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var freqFinder = from number in numbers
                             orderby number
                             group number by number into grupo
                             select new { Value = grupo.Count(), Key = grupo.Key };

            foreach (var item in freqFinder)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            var methodSnytFinder = numbers.GroupBy(number => number);

            foreach (var item in methodSnytFinder)
            {
                Console.WriteLine(item.Key + " " + item.Count());
            }

            Console.ReadLine();
        }
    }
}
