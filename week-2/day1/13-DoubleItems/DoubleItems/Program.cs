using System;

namespace DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 4, 5, 6, 7 };
            numbers = Array.ConvertAll(numbers, x => x * 2);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] +" ");
            }
            Console.ReadLine();
            // - Create an array variable named `numList`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array
        }
    }
}
