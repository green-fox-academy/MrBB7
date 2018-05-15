using System;
using System.Collections.Generic;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            Console.WriteLine(Sweets(list));
            Console.ReadLine();
            // Accidentally we added "2" and "false" to the list.
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines
            // Create a method called Sweets() which takes the list as a parameter.

            //  Console.WriteLine(Sweets(list));
            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"
        }
        public static string Sweets(List<object> listOfObjects)
        {
            string newdata = "";
            foreach (var item in listOfObjects)
            {
               
                if (item is bool)
                {
                    newdata += "Ice cream, ";
                }
                else if (item is int)
                {
                    newdata += "Croissant, ";
                }
                else
                {
                    newdata += item + ", ";
                }
            }
            newdata = newdata.Substring(0, newdata.Length - 2);
            return newdata;
        }
    }
}
