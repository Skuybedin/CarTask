using System;

namespace CarTask
{
    public class PassengerСar : Car
    {
        public int MaxPassengersValue { get; protected set; }
        public int CurrentPassengersValue { get; protected set; }

        protected const double fuelRangeDecreaseByPerson = 0.06;

        public PassengerСar(double averageFuelConsumption, double fuelCapacity, double currentFuel, double speed,
        int maxPassengersValue, int currentPassengersValue) : base(CarTypes.B, averageFuelConsumption, fuelCapacity, currentFuel, speed)
        {
            if (currentPassengersValue > maxPassengersValue) throw new ArgumentException($"Число пассажиров не может быть больше {maxPassengersValue}");

            MaxPassengersValue = maxPassengersValue;
            CurrentPassengersValue = currentPassengersValue;
        }

        protected override double FuelCalcRange(double fuel) => base.FuelCalcRange(fuel) * (1 - fuelRangeDecreaseByPerson * CurrentPassengersValue);
    }
}
