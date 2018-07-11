using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Services
{
    public interface IFox
    {
        string GetName();
        void SetName(string inputName);

        string GetFood();
        void SetFood(string food);

        string GetDrink();
        void SetDrink(string drink);

        void SetTricks(string trick);
        List<string> GetTricks();
    }
}
