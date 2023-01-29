using System;

namespace Class_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Brand = "BMW";
            car1.Model = "M5";
            car1.Mileage = 250;
            car1.FuelCapacity = 59;
            car1.CurrentFuel = 10;
            car1.AddFuel(10);
            Console.WriteLine("CurrentFuel: " + car1.CurrentFuel);
        }
    }
}
