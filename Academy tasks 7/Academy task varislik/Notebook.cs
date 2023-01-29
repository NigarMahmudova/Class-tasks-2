using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_task_varislik
{
    class Notebook: Product
    {
        public Notebook(string name, double price) : base(name, price)
        {

        }
        public double RAM;
        public double Storage;
    }
}
