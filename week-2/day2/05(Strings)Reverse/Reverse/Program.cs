using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";


            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(Reversing(reversed));
            Console.ReadLine();
        }
        public static string Reversing(string inputString)
        {
            int length = inputString.Length;
            string reverse = String.Empty;
            for (int i = inputString.Length - 1; i > -1; i--)
            {
                reverse += inputString[i];
            }
            return reverse;
        }
    }
}
