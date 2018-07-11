using System;

namespace PrintAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 5, 6, 7 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
            // - Create an array variable named `numbers`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print all the elements of `numbers`
        }
    }
}
