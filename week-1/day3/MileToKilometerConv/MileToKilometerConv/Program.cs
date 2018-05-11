using System;

namespace MileToKilometerConv
{
    class Program
    {
        static void Main(string[] args)
        {
            int km;
            int mile;

            mile = Int32.Parse(Console.ReadLine());
            Console.WriteLine(mile * 1.609);
            Console.ReadLine();
        }
    }
}
