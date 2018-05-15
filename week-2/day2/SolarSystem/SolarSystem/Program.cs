using System;
using System.Collections.Generic;
using System.Text;

namespace SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune" };
            planetList = PutSaturn(planetList);
            foreach (var xitem in planetList)
            {
                Console.Write(xitem+ ", ");
            }
            // Saturn is missing from the planetList
            // Insert it into the correct position
            // Create a method called PutSaturn() which has list parameter and returns the correct list of planets as a string.


            Console.ReadLine();
            // Expected output: "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus", "Neptune", "Saturn"
        }
        public static List<string> PutSaturn(List<string> inputPlanets)
        {
            inputPlanets.Insert(7, "Saturn");
            return inputPlanets;
        }
    }
}
