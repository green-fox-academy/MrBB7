using System;
using System.Collections.Generic;
using System.Text;

namespace QuoteSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code
            // Create a method called QuoteSwap().

            // Also, print the sentence to the output with spaces in between.
            // Expected output: "What I cannot create I do not understand."     
            Console.WriteLine(QuoteSwap(list));
            Console.ReadLine();

        }
        public static string QuoteSwap(List<string>words)
        {
            StringBuilder temp = new StringBuilder();
            int indexOne = words.IndexOf("do");
            int indexTwo = words.IndexOf("cannot");

            words[indexOne] = "cannot";
            words[indexTwo] = "do";

            foreach (string item in words)
            {
                temp.Append(item + " ");
            }
            return temp.ToString();
        }
    }
}
