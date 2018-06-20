using System;
using System.Linq;
using System.Collections.Generic;

namespace CharFreq
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a LINQ Expression to find the frequency of characters in a given string!

            string characterChain= "Somethingrandomquote";

            var findCharFreq = from character in characterChain.ToLower()
                               group character by character into grupo
                               select new { Value = grupo.Count(), Key = grupo.Key };

            foreach (var item in findCharFreq)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            var methodSnytCharFinder = characterChain.GroupBy(number => number);

            foreach (var item in methodSnytCharFinder)
            {
                Console.Write(item.Key + " " + item.Count());
            }

            Console.ReadLine();

        }
    }
}
