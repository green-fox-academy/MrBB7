using System;

namespace Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a list of numbers as a parameter
            //  Returns a list of numbers where every number in the list occurs only once
            //  Example
            //  should print: `[1, 11, 34, 52, 61]`

            int[] numbsUniq = { 1, 11, 34, 11, 52, 61, 1, 34, 52, 99 };

            numbsUniq = Unique(numbsUniq);

            foreach (int item in numbsUniq)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadLine();
        }
        public static int[] Unique(int[] numbsForUniq)
        {
            int[] tempArray = new int[numbsForUniq.Length];

            int index = 0;

            for (int i = 0; i < numbsForUniq.Length; i++)
            {
                int counter1 = 0;

                for (int j = 0; j < numbsForUniq.Length; j++)
                {
                    if (numbsForUniq[i] != tempArray[j])
                    {
                        counter1++;
                    }
                }

                if (counter1 == numbsForUniq.Length)
                {
                    tempArray[index] = numbsForUniq[i];
                    index++;
                }
            }
            return tempArray;
        }    
    }
}
