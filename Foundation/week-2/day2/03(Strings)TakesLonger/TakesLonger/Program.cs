using System;
using System.Text;

namespace TakesLonger
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
            String toFind = "you";
            int index = quote.IndexOf("you");

            StringBuilder sentenceFixer = new StringBuilder();

            sentenceFixer
                 .Append("always takes longer than ");

            quote = quote.Substring(0, index) + sentenceFixer + quote.Substring(index, quote.Length - index);

            Console.WriteLine(quote);
            Console.ReadLine();

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)

        }
    }
}
