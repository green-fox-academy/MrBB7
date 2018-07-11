using System;

namespace _04_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).
            int baseValue = Int32.Parse(Console.ReadLine());
            int exponent = Int32.Parse(Console.ReadLine());
            Console.WriteLine(PowerN(baseValue, exponent));
            Console.ReadLine();

        }

        public static int PowerN(int baseNumber, int number)
        {
            if (number == 1)
            {
                return baseNumber;
            }
            else
            {
                return baseNumber * PowerN(baseNumber, number - 1);
            }
        }
    }
}
