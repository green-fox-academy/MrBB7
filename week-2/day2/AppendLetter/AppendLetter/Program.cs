using System;
using System.Collections.Generic;
using System.Text;

namespace AppendLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };

            // Create a method called AppendA() that adds "a" to every string in the far list.
            // The parameter should be a list.

            Console.WriteLine(AppendA(far));
            Console.ReadLine(); 
            // Expected output: "kutya", "macska", "kacsa", "róka", "halacska"
        }
        public static string AppendA(List<string>endings)
        { StringBuilder endingBuilder = new StringBuilder();

            for (int i = 0; i < endings.Count; i++)
            {
                endingBuilder
                    .Append(endings[i] +"a ");
            }
            return endingBuilder.ToString();
        }
    }
}
