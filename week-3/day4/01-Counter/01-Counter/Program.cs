using System;

namespace _01_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Counter(Int32.Parse(Console.ReadLine())));
            Console.ReadLine();
        }

        public static int Counter(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                Console.WriteLine(n);
                return Counter(n - 1);
            }
        }
    }
}
