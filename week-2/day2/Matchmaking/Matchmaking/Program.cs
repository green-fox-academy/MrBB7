using System;
using System.Collections.Generic;

namespace Matchmaking
{
    class Program
    {
        static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };

            // Write a method that joins the two lists by matching one girl with one boy into a new list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            Console.WriteLine(MakingMatches(girls, boys));
            Console.ReadLine();
        }
        public static string MakingMatches(List<string> chicks, List<string> guys)
        {
            int numberOfPairs = 0;
            string outPutString = "";
            if (chicks.Count < guys.Count)
            {
                numberOfPairs = chicks.Count;
            }
            else
            {
                numberOfPairs = guys.Count;
            }
            for (int i = 0; i < numberOfPairs; i++)
            {
                outPutString += chicks[i] +", " + guys[i] + ", ";
            }

            outPutString = outPutString.Substring(0, outPutString.Length-2);
            return outPutString;
        }
    }
}
