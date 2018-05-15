using System;
using System.Collections.Generic;

namespace IsInList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Create a method that accepts list as an input
            // it should return "true" if it contains all, otherwise "false"
            Console.WriteLine(CheckNums(list));
            Console.ReadLine();
        }
        public static bool CheckNums(List<int>incomingData)
        {
            bool answer = true;
            foreach (var item in incomingData)
            {
                if (incomingData.Contains(4) && incomingData.Contains(8) && incomingData.Contains(12) && incomingData.Contains(16))
                {
                    answer = true;
                }
                else
                { 
                    answer = false;
                }
            }
            return answer;
        }
    }
}
