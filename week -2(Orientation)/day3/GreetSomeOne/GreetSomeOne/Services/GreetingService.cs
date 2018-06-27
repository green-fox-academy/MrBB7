using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeOne.Services
{
    public class GreetingService : IGreet
    {
        private string name;

        public void SetName(string inputName)
        {
            name = inputName;
        }

        public string GetName()
        {
            return name;
        }
    }
}
