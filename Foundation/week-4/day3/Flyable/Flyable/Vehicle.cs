using System;
using System.Collections.Generic;
using System.Text;

namespace Flyable
{
    public abstract class Vehicle
    {

        private string name;
        private string size;
        private int timeForTakeOff;

        public string Name { get => name; set => name = value; }
        public string Size { get => size; set => size = value; }
        public int TimeForTakeOff { get => timeForTakeOff; set => timeForTakeOff = value; }

    }
}
