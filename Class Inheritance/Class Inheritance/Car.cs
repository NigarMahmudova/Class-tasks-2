using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Inheritance
{
    internal class Car: Vehicle
    {
        public double FuelCapacity;
        public double CurrentFuel;

        public void AddFuel(double fuel)
        {
            double capacity = CurrentFuel + fuel;
            if (capacity <= FuelCapacity)
            {
                CurrentFuel += fuel;
            }
        }
    }
}
