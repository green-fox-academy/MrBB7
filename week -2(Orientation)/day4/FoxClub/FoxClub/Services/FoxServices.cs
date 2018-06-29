using FoxClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public class FoxServices : IFox
    {
        List<Fox> foxPack = new List<Fox>();
        Fox thisFox = new Fox() { Tricks = new List<string>() };


        public string GetName()
        {
            return thisFox.Name;
        }

        public void SetName(string inputName)
        {
            thisFox.Name = inputName;
        }

        public string GetDrink()
        {
            return thisFox.Drink;
        }

        public string GetFood()
        {
            return thisFox.Food;
        }

        public List<string> GetTricks()
        {
            return thisFox.Tricks;
        }

        public void SetDrink(string drink)
        {
            thisFox.Drink = drink;
        }

        public void SetFood(string food)
        {
            thisFox.Food = food;
        }

        public void SetTricks(string trick)
        {
            thisFox.Tricks.Add(trick);
        }
    }
}
