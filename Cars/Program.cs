using System;
using System.Collections.Generic;

namespace CarTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new PassengerСar(9, 33, 21, 70, 5, 3),
                //new PassengerСar(averageFuelConsumption: 9, fuelCapacity: 33, currentFuel: 21, speed: 70, maxPassengersValue: 5, currentPassengersValue: 3),
                
                new Truck(20, 450, 380, 90, 5000, 3500),
                //new Truck(averageFuelConsumption: 20, fuelCapacity: 450, currentFuel: 380, speed: 90, totalCapacity: 5000, currentWeight: 3500),
                
                new SportCar(18, 60, 35, 100)
                //new SportCar(averageFuelConsumption: 18, fuelCapacity: 60, currentFuel: 35, speed: 100)
            };

            foreach (Car car in cars)
            {
                car.DisplayCurrentFuelRange();
            }
        }
    }
}
