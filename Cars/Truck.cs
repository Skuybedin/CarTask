using System;

namespace CarTask
{
    public class Truck : Car
    {
        public double TotalCapacity { get; protected set; }
        public double CurrentWeight { get; protected set; }

        protected const double fuelRangeDecreaseByWeight = 0.04;
        protected const double weight = 200;

        public Truck(double averageFuelConsumption, double fuelCapacity, double currentFuel, double speed,
        double totalCapacity, double currentWeight) : base(CarTypes.C, averageFuelConsumption, fuelCapacity, currentFuel, speed)
        {
            if (currentWeight > totalCapacity) throw new ArgumentException($"Загруженность не может быть больше {totalCapacity}");

            TotalCapacity = totalCapacity;
            CurrentWeight = currentWeight;
        }

        protected override double FuelCalcRange(double fuel) => base.FuelCalcRange(fuel) * (1 - CurrentWeight * (fuelRangeDecreaseByWeight / weight));
    }
}
