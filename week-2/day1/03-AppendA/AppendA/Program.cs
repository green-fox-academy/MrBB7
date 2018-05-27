using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "kuty", "macsk", "cic" };

            for (int i = 0; i < animals.Length; i++)
            {
                Console.Write(animals[i] + "a" + " "); 
            }
            Console.ReadLine();
            // - Create an array variable named `animals`
            //   with the following content: `["kuty", "macsk", "cic"]`
            // - Add all elements an `"a"` at the end
        }
    }
}
