using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NFS_Console
{
    class Program
    {
        static public void PrintModel(Car car)
        {
            Console.WriteLine(car.GetModel());
        }

        static public void Race(List <Car> cars)
        {
            int time = 0;
            int finish = 80;
            while (true)
            {
                
                foreach (Car auto in cars)
                {
                    double speed = (auto.GetSpeed() / 50) * time;
                    for (int i = 1; i <= speed; i++)
                    {
                        Console.Write(" ");
                        if (speed >= finish)
                        {
                            Console.Clear();
                            Console.WriteLine("Машина победитель: " + auto.GetModel());
                            return;
                        }
                    }
                    Console.WriteLine(auto.GetModel());
                    Console.WriteLine("--------------------------------------------------------------------------------");

                }
                time++;
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
        static void Main(string[] args)
        {
            Car auto = new Car();
            auto.SetModel("Lada");
            auto.SetSpeed(270);

            Car merc = new Car();
            merc.SetModel("Mercedes");
            merc.SetSpeed(320);

            Car audi = new Car();
            audi.SetModel("Audi");
            audi.SetSpeed(300);

            Car ford = new Car();
            ford.SetModel("Ford");
            ford.SetSpeed(350);

            Car tesla = new Car();
            tesla.SetModel("Tesla");
            tesla.SetSpeed(275);


            List<Car> cars = new List<Car>();
            cars.Add(auto);
            cars.Add(merc);
            cars.Add(audi);
            cars.Add(ford);
            cars.Add(tesla);
            Race(cars);
        }
    }
}
