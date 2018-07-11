using System;

namespace _12Cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            double side;
            side = Double.Parse(Console.ReadLine());
            double surface = side * side;
            double volume = side * side * side;         
            Console.WriteLine("Surface area: " + surface);
            Console.WriteLine("Volume : " + volume);
            Console.ReadLine();
        }
    }
}
