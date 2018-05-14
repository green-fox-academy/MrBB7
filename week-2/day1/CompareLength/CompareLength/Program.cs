using System;

namespace CompareLength
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayp1 = { 1, 2, 3 };
            int[] arrayp2 = { 4, 5 };
            int sizeOfArray1 = arrayp1.Length;
            int sizeOfArray2 = arrayp2.Length;
            if (sizeOfArray2 > sizeOfArray1)
            {
                Console.WriteLine("p2 has more elements than p1");
            }
            else
            {
                Console.WriteLine("p1 has more elements than p2");
            }           

            Console.ReadLine();
            // - Create an array variable named `p1`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            // - Print if `p2` has more elements than `p1`
        }
    }
}
