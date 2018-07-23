using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindGreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fox> foxes = new List<Fox>
            {
                new Fox("Vuk", "pallida", "green"),
                new Fox("Karak", "fulvipes", "green"),
                new Fox("yMaxy", "pallida", "grey"),
                new Fox("Tom", "cat", "greyish"),
                new Fox("Jerry", "mouse", "brown"),
            };

            var lambda = foxes.Where(x =>  x.Color == "green")
                                          .Select(x => x.Name);            

            var query = from fox in foxes
                        where fox.Type == "pallida" && fox.Color == "green"
                        select fox.Name;

            Console.Write(string.Join(", ", lambda) + ',');

            Console.Write(string.Join(", ", query));

            Console.ReadLine();
        }
    }
}
