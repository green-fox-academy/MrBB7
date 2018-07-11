using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter sum = new Counter();

            sum.Reset();
            Console.WriteLine(sum.Get());
            Console.ReadLine();
        }
    }
}

