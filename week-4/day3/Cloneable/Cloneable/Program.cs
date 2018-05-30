using System;
using GreenFoxOrganization;

namespace Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student("John", 20, "male", "BME");
            Object clone = john.Clone();
            Console.WriteLine(clone);
            Console.ReadLine();

        }
    }
}
