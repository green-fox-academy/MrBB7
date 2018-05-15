using System;

namespace SumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayAi = { 3, 4, 5, 6, 7 };
            int sum=0;
            for (int i = 0; i < arrayAi.Length; i++)
            {
                sum += arrayAi[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
            // - Create an array variable named `ai`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `ai`
        }
    }
}
