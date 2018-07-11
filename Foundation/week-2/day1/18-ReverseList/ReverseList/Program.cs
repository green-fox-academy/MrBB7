using System;

namespace ReverseList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aj = { 3, 4, 5, 6, 7 };

            for (int i = aj.Length - 1; i >= 0; i--)
            {
                Console.Write(aj[i]+" ");
            }
            Console.ReadLine();
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`
        }
    }
}
