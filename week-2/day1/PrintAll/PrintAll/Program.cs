using System;

namespace PrintAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraynumbers = { 4, 5, 6, 7 };
            for (int i = 0; i < arraynumbers.Length; i++)
            {
                Console.WriteLine(arraynumbers[i]);
            }
            Console.ReadLine();
            // - Create an array variable named `numbers`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print all the elements of `numbers`
        }
    }
}
