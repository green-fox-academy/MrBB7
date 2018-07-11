using System;

namespace _09_StringVol3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the
            // adjacent chars are now separated by a "*".

            Console.WriteLine(CharAdd(Console.ReadLine()));
            Console.ReadLine();

        }

        private static string CharAdd(string inputText)
        {
            char space = '*';
            if (inputText == "")
            {
                return null;
            }

                if (inputText.Length == 1)
                {
                space = '\0';   
                }

                return inputText[0].ToString() + space.ToString() + CharAdd(inputText.Remove(0, 1));
            }
        }
    }

