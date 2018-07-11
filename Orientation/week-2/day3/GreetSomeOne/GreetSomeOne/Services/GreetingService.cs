using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreetSomeOne.Services
{
    public class GreetingService : IGreet
    {
        public string Name { get; set; }

        public void SetName(string inputName)
        {
            Name = inputName;
        }

        public string GetName()
        {
            return Name;
        }
    }
}
