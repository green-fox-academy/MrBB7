using System;

namespace Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie firstSharpie = new Sharpie("orange" , 13);
            Sharpie secondSharpie = new Sharpie("blue", 41);

            firstSharpie.Use();
            secondSharpie.Use();

            Console.WriteLine( "the level of ink is: " + firstSharpie.inkAmount);
            Console.WriteLine("the level of ink is: " + secondSharpie.inkAmount);
            Console.ReadLine();
        }
    }
}
