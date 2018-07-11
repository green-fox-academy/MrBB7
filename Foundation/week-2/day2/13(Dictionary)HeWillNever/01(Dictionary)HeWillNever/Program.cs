using System;
using System.Collections.Generic;

namespace _01_Dictionary_HeWillNever
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "";
            int[] notSoCrypticMessage = { 1, 12, 1, 2, 11, 1, 7, 11, 1, 49, 1, 3, 11, 1, 50, 11 };

            var map = new Dictionary<int, string>();

            map.Add(7, "run around and desert you");
            map.Add(50, "tell a lie and hurt you ");
            map.Add(49, "make you cry, ");
            map.Add(2, "let you down");
            map.Add(12, "give you up, ");
            map.Add(1, "Never gonna ");
            map.Add(11, "\n");
            map.Add(3, "say goodbye ");

            foreach (var item in notSoCrypticMessage)
            {
                output += map[item];
            }

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
