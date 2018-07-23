using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToStringConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] inputChars = new char[] { 'H', 'e', 'l', 'l', 'o' };

            var lambda = string.Join("", inputChars.Select(x => x.ToString()));

            var query = from character in inputChars
                        select character.ToString();

            Console.WriteLine(lambda);

            Console.WriteLine(string.Join("", query));

            Console.ReadLine();

        }
    }
}
