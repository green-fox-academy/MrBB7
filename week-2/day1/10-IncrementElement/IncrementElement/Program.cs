using System;

namespace IncrementElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayt = { 1, 2, 3, 4, 5 };
            Console.Write("Give me the number you want to add: ");
            int increment = Int32.Parse(Console.ReadLine());
            
            arrayt[2] += increment;
            Console.WriteLine(arrayt[2]);
            Console.ReadLine();
            //- Create an array variable named `t`
            //  with the following content: `[1, 2, 3, 4, 5]`
            //- Increment the third element
            //- Print the third element
        }
    }
}
