using System;
using System.Collections.Generic;
using System.Text;

namespace FuelStation
{
    class Cars
    {
        public int amountOfFuel;
        public int tankCapacity;

        public Cars()
        {
            amountOfFuel = 0;
            tankCapacity = 100;
        }

        public void CarIsRunning(int distance)
        {
            amountOfFuel -= distance;
            tankCapacity += distance;
        }
    }
}


