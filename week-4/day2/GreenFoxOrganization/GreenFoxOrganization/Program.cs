using System;

namespace GreenFoxOrganization
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Jane = new Person();
            Console.WriteLine(Jane.Introduce());
            Console.WriteLine(Jane.GetGoal());
            Console.ReadLine();
        }
    }
}
