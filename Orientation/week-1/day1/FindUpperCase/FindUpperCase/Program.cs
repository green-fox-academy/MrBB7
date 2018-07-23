using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindUpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var query = (from character in input
                         where character.ToString().Equals(character.ToString().ToUpper())
                         select character);

            Console.WriteLine(string.Join(",",query));

            Console.ReadLine();
        }
    }
}
