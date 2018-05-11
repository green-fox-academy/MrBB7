using System;

namespace AverageOfInput
{
    class Program
    {
        static void Main(string[] args)
        {
            int first;
            int second;
            int third;
            int fourth;
            int fifth;
            long sum;            

            Console.Write("please give me the first number: ");
            first = Int32.Parse(Console.ReadLine());
            Console.Write("please give me the second number: ");
            second = Int32.Parse(Console.ReadLine());
            Console.Write("please give me the third number: ");
            third = Int32.Parse(Console.ReadLine());
            Console.Write("please give me the fourth number: ");
            fourth = Int32.Parse(Console.ReadLine());
            Console.Write("please give me the fifth number: ");
            fifth = Int32.Parse(Console.ReadLine());          

            sum = first + second + third + fourth + fifth;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + (sum /5.00));
            Console.ReadLine();
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

        }
    }
}
