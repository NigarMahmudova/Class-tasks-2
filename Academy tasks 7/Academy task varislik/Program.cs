using System;

namespace Academy_task_varislik
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Mehsul 1", 100);
            Phone phone1 = new Phone("Iphone 11", 1200) { Camera = 16 };
            Notebook notebook1 = new Notebook("XPS 15", 2300) { Storage = 512, RAM = 16 };

            notebook1.ShowInfo();
        }
    }
}
