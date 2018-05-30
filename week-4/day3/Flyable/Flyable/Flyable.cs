using System;
using System.Collections.Generic;
using System.Text;

namespace Flyable
{
    public interface IFlyable
    {
        string Land();
        string Fly();
        int TakeOff();
    }
}
