using System;

namespace FuelStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars volvo = new Cars();
            Station mol = new Station(14);
            Console.WriteLine("Station initial gas: " + mol.amountOfFuel);

            mol.RefillCar(volvo);
            Console.WriteLine("Filling up the car");

            Console.WriteLine("The car has " + volvo.amountOfFuel + " gas");
            Console.WriteLine("Station after the first refill: " + mol.amountOfFuel);

            Console.WriteLine("The car is running 50 km");
            volvo.CarIsRunning(50);
            Console.WriteLine("The car has " + volvo.amountOfFuel + " gas after 50 km");
            Console.WriteLine("The car has " + volvo.tankCapacity + " capacity after 50 km");

            mol.RefillCar(volvo);
            Console.WriteLine("The car has " + volvo.amountOfFuel + " gas after refill");
            Console.WriteLine("Station after the second refill: " + mol.amountOfFuel);



            Console.ReadLine();
            ;

        }
    }
}
