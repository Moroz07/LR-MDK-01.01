using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManyClassAplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Goods car1 = new Goods();
            car1.SetName("Mercedes-Benz");
            car1.SetPrice(1200000);
            Goods car2 = new Goods();
            car2.SetName("УАЗ");
            car2.SetPrice(10000000);

            Warehouse storage = new Warehouse();
            storage.SetIdentifier(1);
            storage.SetLocation("Торжок, Студенческая 3.");
            storage.SetProductCount(car1, 2);
            storage.SetProductCount(car2, 5);

           
           Console.WriteLine("Адрес склада: " + storage.GetLocation());
           Console.WriteLine("Идентификатор склада: " + storage.GetIdentifier());
           foreach(Goods car in storage.GetProductCount().Keys)
           {
                
                Console.WriteLine();
           }    
            
        }
    }
}
