using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 1521;
            int divider1 = 3;
            int divider2 = 5;
            // tell if j is dividable by 3 or 5 (print as a boolean)
            bool dividable = true;
            bool notdividable = false;
            if ((j % divider1 == 0) || (j % divider2 == 0))
            {
                Console.WriteLine(dividable);
            }
            else
            {
                Console.WriteLine(notdividable);
            }


            string k = "Apple";
            string kfilling = k;
            //fill the k variable with its cotnent 4 times
            for (int i = 0; i < 3; i++)
            {
                k += kfilling;
            }

            Console.WriteLine(k);
            Console.ReadLine();
        }
    }
}
