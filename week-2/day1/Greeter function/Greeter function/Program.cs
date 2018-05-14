using System;

namespace Greeter_function
{
    class Program
    {   
        public static void greet()
        {
            string al = "Greenfox";
            Console.WriteLine("Greetings dear, {0}" ,al);
        }
        static void Main(string[] args)
        {
            greet();
            Console.ReadLine();
            // - Create a string variable named `al` and assign the value `Greenfox` to it
            // - Create a function called `greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Greenfox`
            // - Greet `al`
        }
    }
}
