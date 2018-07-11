using System;

namespace _02_NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Summarizer(Int32.Parse(Console.ReadLine())));
            Console.ReadLine();
        }

        private static int Summarizer(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                Console.WriteLine(number);
                return number + Summarizer(number - 1);
            }
        }
    }
}
