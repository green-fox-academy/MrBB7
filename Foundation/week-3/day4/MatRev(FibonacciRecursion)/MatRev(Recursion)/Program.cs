using System;

namespace MatRev_Recursion_
{
    class Program
    {
        static void Main(string[] args)
        {
            //0,1,1,2,3,5,8,13,21

            Console.WriteLine(GetFibonacci(30));
            Console.ReadLine();
        }

        public static int GetFibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return GetFibonacci(n - 1) + GetFibonacci(n - 2);
            }
        }
    }
}
