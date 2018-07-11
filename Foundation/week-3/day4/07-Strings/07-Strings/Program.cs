using System;

namespace _07_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.

            Console.WriteLine(Yalizer(Console.ReadLine()));
            Console.ReadLine();
        }

        public static string Yalizer(string inputText)
        {
            string tempWord = inputText;
            if (tempWord.Contains("x"))
            {
                return tempWord = Yalizer(tempWord.Replace("x","y"));
            }
            else
            {
                return tempWord;
            }
        }
    }
}
