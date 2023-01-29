using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_task_varislik
{
    class Phone: Product
    {
        public Phone(string name, double price):base(name, price)
        {

        }

        public double Camera;
    }
}
