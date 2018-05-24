using System;

namespace _08_StringVol2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the 'x' chars have been removed.

            Console.WriteLine(RemoveX(Console.ReadLine()));
            Console.ReadLine();


        }

        private static string RemoveX(string inputText)
        {
            if (inputText == "")
            {
                return null;
            }

            else
            {
                if (inputText[0] == 'x')
                {
                    return RemoveX(inputText.Remove(0, 1));
                }
                else
                {
                    return inputText[0] + RemoveX(inputText.Remove(0, 1));
                }
            }
        }
    }
}
