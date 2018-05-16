using System;

namespace ReverseList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayAj = { 3, 4, 5, 6, 7 };
            int[] arraynewAj = new int[5];

            int j = 0;

            for (int i = arrayAj.Length - 1; i >= 0; i--)
            {
                arraynewAj[j] = arrayAj[i];
                j++;
                Console.Write(arrayAj[i]+" ");
            }
            Console.ReadLine();
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`
        }
    }
}
