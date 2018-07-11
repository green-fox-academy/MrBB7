using System;

namespace AppendAFunc
{
    class Program
    {

        static void Main(string[] args)
        {
            string am = "kuty";
            Console.WriteLine(appendAFunc(am));
            Console.ReadLine();
        }
        public static string appendAFunc(string am)
        {
            return am + "a";
        }
            // - Create a string variable named `am` and assign the value `kuty` to it
            // - Write a function called `appendA` that gets a string as an input,
            //   appends an 'a' character to its end and returns with a string
            // - Print the result of `appendAFunc(am)`
    }
}
