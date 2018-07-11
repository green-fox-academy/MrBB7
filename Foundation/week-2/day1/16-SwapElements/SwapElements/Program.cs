using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = "";
            string[] arrayAbc = { "first", "second", "third" };
            temp = arrayAbc[0];
            arrayAbc[0] = arrayAbc[2];
            arrayAbc[2] = temp;

            for (int i = 0; i < arrayAbc.Length; i++)
            {
                Console.Write(arrayAbc[i] + " ");
            }
            Console.ReadLine();
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`
        }
    }
}
