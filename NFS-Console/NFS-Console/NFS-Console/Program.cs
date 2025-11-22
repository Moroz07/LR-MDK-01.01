using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFS_Console
{
    class Program
    {
        static public void PrintModel(Car car)
        {
            Console.WriteLine(car.GetModel());
        }
        static void Main(string[] args)
        {
            Car auto = new Car();
            auto.SetModel("Lada");
            PrintModel(auto);
            auto.SetSpeed(150);

            Car merc = new Car();
            merc.SetModel("Mercedes");
            merc.SetSpeed(300);
            PrintModel(merc);
        }
    }
}
