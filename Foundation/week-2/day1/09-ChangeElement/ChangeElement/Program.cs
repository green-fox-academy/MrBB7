using System;

namespace ChangeElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrays = { 1, 2, 3, 8, 5, 6 };
            arrays[Array.IndexOf(arrays, 8)] = 4;
            Console.WriteLine(arrays[3]);
            Console.ReadLine();
            // - Create an array variable named `s`
            //   with the following content: `[1, 2, 3, 8, 5, 6]`
            // - Change the 8 to 4
            // - Print the fourth element
        }
    }
}
