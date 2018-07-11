using DIWshopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIWshopApp.Services
{
    public class CounterService : ICounter
    {
        private Number storedValue;

        public CounterService()
        {
            storedValue = new Number() { MyNumber = 0 };
        }

        public int GetNumber()
        {
            return storedValue.MyNumber;
        }

        public void Increase()
        {
            storedValue.MyNumber++;
        }
    }
}
