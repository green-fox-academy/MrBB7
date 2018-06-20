using System;
using System.Collections.Generic;
using System.Linq;

namespace MoreThanTwenty
{
    class Program
    {
        static void Main(string[] args)
        {
           // Write a LINQ Expression to find which number squared value is more then 20 from the following array:

            int[] numbers = new[] { 3, 9, 2, 8, 6, 5 };

            IEnumerable<int> moreThenTwenty = from number in numbers
                                              where number * number > 20
                                              select number;

            foreach (var item in moreThenTwenty)
            {
                Console.WriteLine(item);
            }

            IEnumerable<int> methodSyntMoreThenTwenty = numbers.Select(number => number * number).Where(number => number > 20);

            foreach (var item in methodSyntMoreThenTwenty)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
