using System;

namespace DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraynumList = { 3, 4, 5, 6, 7 };
            arraynumList = Array.ConvertAll(arraynumList, x => x * 2);
            for (int i = 0; i < arraynumList.Length; i++)
            {
                Console.Write(arraynumList[i] +" ");
            }
            Console.ReadLine();
            // - Create an array variable named `numList`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array
        }
    }
}
