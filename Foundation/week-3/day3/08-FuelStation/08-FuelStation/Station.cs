using System;
using System.Collections.Generic;
using System.Text;

namespace FuelStation
{
    class Station
    {
        public int amountOfFuel;

        public Station(int amountOfFuel)
        {
            this.amountOfFuel = 500;
        }
        public int RefillCar(Cars car)
        {
            amountOfFuel -= car.tankCapacity;
            car.amountOfFuel += car.tankCapacity;
            car.tankCapacity = 0;
            return car.amountOfFuel;
        }
    }
}
