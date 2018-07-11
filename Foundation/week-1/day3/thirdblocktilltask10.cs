using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
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

            Console.WriteLine();
            Console.WriteLine("Task09");
            Console.WriteLine();

            double massInKg = 81.2;
            double heightInM = 1.78;
            double BMI;

            BMI = massInKg / (heightInM * heightInM);
            Console.WriteLine("The BMI index is: " + BMI);
            Console.Read();

            Console.WriteLine();
            Console.WriteLine("Task10");

            string myName = "Bence";
            int myAge = 23;
            double myHeight = 1.84;
            bool myMaritalStatus = false;

        }
    }
}
