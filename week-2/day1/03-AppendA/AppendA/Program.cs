using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayAnimals = { "kuty", "macsk", "cic" };
            string append = "a";

            for (int i = 0; i < arrayAnimals.Length; i++)
            {
                Console.Write(arrayAnimals[i] + "a" + " "); 
            }
            Console.ReadLine();
            // - Create an array variable named `animals`
            //   with the following content: `["kuty", "macsk", "cic"]`
            // - Add all elements an `"a"` at the end
        }
    }
}
