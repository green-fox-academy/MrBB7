using System;

namespace PartyIndicator
{
    class Program
    {
        static void Main(string[] args)
        {
            int girlees;
            int boys;
            int guests;
            long ratio;

            Console.Write("Number of girls: ");
            girlees = Int32.Parse(Console.ReadLine());
            Console.Write("Number of boys: ");
            boys = Int32.Parse(Console.ReadLine());
            guests = girlees + boys;
            ratio = girlees / boys;

            if (girlees == boys && guests > 20)
            {
                Console.WriteLine("The party is excellent!");
            }
            else if (guests > 20  && ratio != 1)
            {
                Console.WriteLine("Quite cool party!");
            }
            else if (guests < 20)
            {
                Console.WriteLine("Average party...");
            }
            else if (girlees == 0)
            {
                Console.WriteLine("Sausage party");
            }
            Console.ReadLine();
            // Write a program that asks for two numbers
            // Thw first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people
        }
    }
}
