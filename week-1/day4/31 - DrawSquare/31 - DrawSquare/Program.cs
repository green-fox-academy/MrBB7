using System;

namespace _31___DrawSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string tempstr = "";
            Console.Write("Please give me the number: ");
            number = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                if (i == 0 || i == number-1)
                {
                    for (int j = 0; j < number; j++)
                    {
                        tempstr += "%";
                    }
                    Console.WriteLine(tempstr);
                    tempstr = "";
                }
                else
                {
                    tempstr += "%";
                    for (int j = 1; j < number -1; j++)
                    {
                        tempstr += " ";
                    }
                    tempstr += "%";
                    Console.WriteLine(tempstr);
                    tempstr = "";
                }
            }
            Console.ReadLine();
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %   %
            // %   %
            // %   %
            // %   %
            // %%%%%
            //
            // The square should have as many lines as the number was
        }
    }
}
