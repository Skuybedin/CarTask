using System;

namespace CarTask
{
    public enum CarTypes
    {
        A,
        B,
        C,
        D,
        E
    }

    public abstract class Car
    {
        public CarTypes CarType { get; protected set; }
        public double AverageFuelConsumption { get; protected set; }
        public double FuelCapacity { get; protected set; }
        public double CurrentFuel { get; protected set; }
        public double Speed { get; protected set; }

        public Car(CarTypes carType, double averageFuelConsumption, double fuelCapacity, double currentFuel, double speed)
        {
            if (averageFuelConsumption < 0 || fuelCapacity < 0 || currentFuel < 0 || speed < 0) throw new ArgumentException("Значения не могут быть меньше 0");
            if (currentFuel > fuelCapacity) throw new ArgumentException($"Текущий запас топлива не может быть больше ёмкости бака");

            CarType = carType;
            AverageFuelConsumption = averageFuelConsumption;
            FuelCapacity = fuelCapacity;
            CurrentFuel = currentFuel;
            Speed = speed;
        }

        protected virtual double FuelCalcRange(double fuel) => fuel / AverageFuelConsumption;
        public double CoverDistanceCalcTime(double distance) => distance / Speed;
        public double FullFuelCalcRange() => FuelCalcRange(FuelCapacity);
        public double CurrentFuelCalcRange() => FuelCalcRange(CurrentFuel);
        public void DisplayCurrentFuelRange() => Console.WriteLine(String.Format("Текущий запас хода: {0:0.00}км", CurrentFuelCalcRange() * 100));
    }
}
