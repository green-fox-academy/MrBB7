using System;

namespace _34___ParametricAverage_exam_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIncomes;
            int numbers = 0;
            int sum = 0;
            Console.Write("Give me a number: ");
            numberOfIncomes = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfIncomes; i++)
            {
                Console.WriteLine("give me another number: ");
                numbers = Int32.Parse(Console.ReadLine());
                sum += numbers;
            }
            double average = (double)sum/(double)numberOfIncomes;
            Console.WriteLine(sum);
            Console.WriteLine(average);
            Console.ReadLine();
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4
        }
    }
}
