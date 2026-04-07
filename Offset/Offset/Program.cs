using OffsetLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Offset
{
    class Program
    {
        public static List<Bike> FindBike(List<Bike> allBike, int x)
        {
            List<Bike> bike = new List<Bike>();
            foreach (Bike b in allBike)
            {
                if (b.GetPrice() < x)
                {
                    bike.Add(b);
                }
            }
            return bike;
           
        }

        static void Main(string[] args)
        {
            Bike Voshod = new Bike("Восход", 150000, "Россия");
            Console.WriteLine("Название мотоцикла: " + Voshod.GetName() + " Цена: " + Voshod.GetPrice() + " Производитель: " + Voshod.GetManufacturer());
            List<Bike> AllBike = new List<Bike>();
            AllBike.Add(new Bike("Иж", 100000, "Россия"));
            AllBike.Add(new Bike("БМВ", 250000, "Германия"));
            AllBike.Add(new Bike("Урал", 175000, "Россия"));

            Console.WriteLine("Второй байк списка: " + AllBike[1].GetName() + " " +  AllBike[1].GetPrice() + AllBike[1].GetManufacturer());

            //Не первышает х, найти все мото(функция)
            List<Bike> bikk = FindBike(AllBike, 180000);
            Console.WriteLine("Байки ниже указанной цены: ");
            for (int i = 0; i < bikk.Count; i++)
            {
                Console.WriteLine(bikk[i].GetName());
            }    

        }

        
    }
}
