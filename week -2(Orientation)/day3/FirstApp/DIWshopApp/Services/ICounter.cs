using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIWshopApp.Services
{
    public interface ICounter
    {
        int GetNumber();
        void Increase();
    }
}
