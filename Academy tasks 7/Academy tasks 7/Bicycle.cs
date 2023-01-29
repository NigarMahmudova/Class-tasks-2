using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_tasks_7
{
    class Bicycle
    {
        public Bicycle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public string Brand;
        public string Model;
        public double Mileage;

        public void Drive (double km)
        {
            Mileage += km;
        }
    }
}
