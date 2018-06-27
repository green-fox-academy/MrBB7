using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeOne.Services
{
    public interface IGreet
    {
        string GetName();
        void SetName(string inputName);
    }
}
