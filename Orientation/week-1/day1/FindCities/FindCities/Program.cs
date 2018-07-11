using System;
using System.Linq;
using System.Collections.Generic;

namespace FindCities
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:

            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var cityFinder = from city in cities
                             where city[0] == 'A' && city[cities.Length - 1] == 'I'
                             select city;

            foreach (var item in cityFinder)
            {
                Console.WriteLine(item);
            }

            var methodSyntCityFinder = cities.Where(city => city[0] == 'A' && city[cities.Length - 1] == 'I').Select(city => city);

            foreach (var item in methodSyntCityFinder)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
