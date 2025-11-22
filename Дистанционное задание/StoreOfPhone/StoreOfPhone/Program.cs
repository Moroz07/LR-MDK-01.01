using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreOfPhone
{
    class Program
    {

        

        static void Main(string[] args)
        {
            List<Phone> sales = new List<Phone>();

            Phone redmi1 = new Phone();

            redmi1.name = "Redmi note 13 pro+ 5g";
            redmi1.price = 32000;
            redmi1.SellData = new DateTime(2025, 11, 10);
            redmi1.count = 6;

            Phone samsung2 = new Phone();

            samsung2.name = "Samsung Galaxy S24 FE";
            samsung2.price = 50000;
            samsung2.SellData = new DateTime(2025, 11, 7);
            samsung2.count = 1;

            Phone pova3 = new Phone();

            pova3.name = "Tecno Pova 5";
            pova3.price = 17000;
            pova3.SellData = new DateTime(2025, 11, 5);
            pova3.count = 4;

            Phone redmi4 = new Phone();

            redmi4.name = "Realme note 50";
            redmi4.price = 10000;
            redmi4.SellData = new DateTime(2025, 11, 12);
            redmi4.count = 1;

            Phone redmi5 = new Phone();

            redmi5.name = "Redmi 9A";
            redmi5.price = 7500;
            redmi5.SellData = new DateTime(2025, 11, 6);
            redmi5.count = 14;

            Phone samsung6 = new Phone();

            samsung6.name = "Samsung galaxy s25 ultra";
            samsung6.price = 95000;
            samsung6.SellData = new DateTime(2025, 11, 3);
            samsung6.count = 5;

            Phone tecno7 = new Phone();

            tecno7.name = "Tecno Spark 20c ";
            tecno7.price = 15000;
            tecno7.SellData = new DateTime(2025, 11, 11);
            tecno7.count = 5;

            Phone iphone8 = new Phone();

            iphone8.name = "Iphone 15 Pro Max";
            iphone8.price = 76000;
            iphone8.SellData = new DateTime(2025, 11, 4);
            iphone8.count = 1;

            Phone Google9 = new Phone();

            Google9.name = "Google pixel 7A";
            Google9.price = 62000;
            Google9.SellData = new DateTime(2025, 11, 1);
            Google9.count = 3;

            Phone redmi10 = new Phone();

            redmi10.name = "Redmi Note 12 PRO";
            redmi10.price = 24000;
            redmi10.SellData = new DateTime(2025, 11, 10);
            redmi10.count = 3;

            Phone samsung11 = new Phone();

            samsung11.name = "Samsung galaxy s25 ultra";
            samsung11.price = 95000;
            samsung11.SellData = new DateTime(2025, 11, 5);
            samsung11.count = 3;

            sales.Add(redmi1);
            sales.Add(samsung2);
            sales.Add(pova3);
            sales.Add(redmi4);
            sales.Add(redmi5);
            sales.Add(samsung6);
            sales.Add(tecno7);
            sales.Add(iphone8);
            sales.Add(Google9);
            sales.Add(redmi10);
            sales.Add(samsung11);

            double TotalAmount = Function.AmountSale(sales);
            Console.WriteLine(TotalAmount);
            var (phoneTopSell, phoneMinSell) = Function.TopSalePhone(sales);
            Console.WriteLine("Самый продаваемый телефон: " + phoneTopSell);
            Console.WriteLine("Самый непродаваемый телефон: " + phoneMinSell);
            Function.TopTwoPhone(sales);
        }
    }
}
