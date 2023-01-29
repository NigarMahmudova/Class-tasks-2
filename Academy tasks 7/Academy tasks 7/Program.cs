using System;

namespace Academy_tasks_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velosiped sayi daxil edin");
            int length = Convert.ToInt32(Console.ReadLine());
            Bicycle[] bicycles = new Bicycle[length];
            for (int i = 0; i < bicycles.Length; i++)
            {
                Console.WriteLine("Brand:");
                string brand = Console.ReadLine();

                Console.WriteLine("Model:");
                string model = Console.ReadLine();

                Bicycle bicycle = new Bicycle(brand, model);
                bicycles[i] = bicycle;
            }

            foreach (var item in bicycles)
            {
                Console.WriteLine("Nece km hereket etdiyini daxil edin...");
                double km = Convert.ToDouble(Console.ReadLine());
                item.Drive(km);
            }


            string input1;
            do
            {
                Console.WriteLine("1. Butun velosipedlere bax");
                Console.WriteLine("2. Velosipedler modeline gore axtaris et");
                Console.WriteLine("0. Menudan cixin");
                Console.WriteLine("Emeliyyati secin:");
                input1 = Console.ReadLine();

                if (input1 == "1")
                {
                    foreach (var item in bicycles)
                    {
                        Console.WriteLine($"Brand: {item.Brand} - Model: {item.Model} - Mileage: {item.Mileage}");
                    }
                }
                else if (input1 == "2")
                {
                    Console.WriteLine("Model daxil edin...");
                    string wantedModel = Console.ReadLine();

                    foreach (var item in bicycles)
                    {
                        if (item.Model.Contains(wantedModel))
                        {
                            Console.WriteLine($"Brand: {item.Brand} - Model: {item.Model} - Mileage: {item.Model}");
                        }
                    }
                }

            } while (input1!="0");

           
        }
    }
}
