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
            storage.SetId(1);
            storage.SetLocation("Торжок, Студенческая 3.");
            storage.SetProductQuantity(car1, 2);
            storage.SetProductQuantity(car2, 5);


            storage.GetProductQuantity();
            storage.CalculateMoney();

            Console.WriteLine();

            Report report = new Report();

            ReportRow row1 = new ReportRow();
            row1.Product = "ШЕРШУЛЯ";
            row1.Quantity = 500;
            row1.Price = 100;

            ReportRow row2 = new ReportRow();
            row2.Product = "КРОШИКИ";
            row2.Quantity = 100;
            row2.Price = 4122;

            ReportRow row3 = new ReportRow();
            row3.Product = "PIB";
            row3.Quantity = 70;
            row3.Price = 812;

            report.AddRecord(row1);
            report.AddRecord(row2);
            report.AddRecord(row3);

            report.ToString();
            Console.WriteLine();

            report.CalculateSum();

        }
    }
}
