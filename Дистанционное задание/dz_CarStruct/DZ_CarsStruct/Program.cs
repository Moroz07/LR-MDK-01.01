
using System;
using System.Collections.Generic;

namespace DZ_CarsStruct
{
    internal class Program
    {
        static void Main()
        {
            List< Automobile > cars = new List< Automobile >();
            Random random = new Random();
            for(int i = 0; i<100; i++)
            {
                Automobile car;
                car.Name = "Автомобиль номер " + (i + 1);
                car.Price = random.Next(50000, 200001);
                car.Speed = random.Next(20, 301);
                cars.Add(car);
                
            }
           
            Automobile.TopCarsSpeed(cars);


        }
    }
}
