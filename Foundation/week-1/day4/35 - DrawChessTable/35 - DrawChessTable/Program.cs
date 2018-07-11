using System;

namespace _35___DrawChessTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "% % % %";
            string second = " % % % %";

            for (int i = 0; i < 8; i++)
            {
                if (i % 2 ==0)
                {
                    Console.WriteLine(first);
                }
                else
                {
                    Console.WriteLine(second);
                }
            }
            Console.ReadLine();

            /*
            int numberOfLines;
            string temp1 = " %";
            string temp2 = "%";
            Console.Write("Give me a number: ");
            numberOfLines = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                if (i % 2 ==0)
                {
                    temp1 *= ;
                    Console.Write(temp1);
                }
                else
                {
                    Console.WriteLine(temp2);
                }
            }
            Console.ReadLine(); */
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //
        }
    }
}
