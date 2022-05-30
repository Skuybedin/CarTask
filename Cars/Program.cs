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
                new Truck(20, 450, 380, 90, 5000, 3500),
                new SportCar(18, 60, 35, 100)
            };

            foreach (Car car in cars)
            {
                car.DisplayCurrentFuelRange();
            }
        }
    }
}
