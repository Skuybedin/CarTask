using System;

namespace CarTask
{
    public class SportCar : Car
    {
        public SportCar(double averageFuelConsumption, double fuelCapacity, double currentFuel, double speed) : base(CarTypes.B, averageFuelConsumption, fuelCapacity, currentFuel, speed)
        {

        }
    }
}
