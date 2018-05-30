using System;
using System.Collections.Generic;
using System.Text;

namespace Flyable
{
    class Helicopter : Vehicle, IFlyable
    {
        public string Fly()
        {
            throw new NotImplementedException();
        }

        public string Land()
        {
            throw new NotImplementedException();
        }

        public int TakeOff()
        {
            throw new NotImplementedException();
        }
    }
}
