using System;

namespace ConsoleApp6
{
    class thirdblock
    {
        static void Swap(string[] args)
        {
            Console.WriteLine("Task07");
            Console.WriteLine();
            int a = 7;
            Console.WriteLine("My favourite number is: " + a);

            Console.WriteLine("Task08");
            Console.WriteLine();


            int number1 = 123;
            int number2 = 526;
            int temp;
            Console.WriteLine("Number1 is: " + number1);
            Console.WriteLine("Number2 is: " + number2);
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);
            Console.Read();
        }
    }
}
