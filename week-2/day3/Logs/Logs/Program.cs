using System;
using System.IO;

namespace Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"log.txt";
            string[] arrayip = { };

            GiveMeIP(path);
            Console.WriteLine(File.ReadAllText(path));
            Console.ReadLine();
            // Read all data from 'log.txt'.
            // Each line represents a log message from a web server
            // Write a function that returns an array with the unique IP adresses.
            // Write a function that returns the GET / POST request ratio.
        }
        public static string[] GiveMeIP(string[,] ipList, string ips)
        {
            try
            {
                string[,] content = File.ReadAllText(ipList);
                StreamWriter sw = new StreamWriter(ips);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
