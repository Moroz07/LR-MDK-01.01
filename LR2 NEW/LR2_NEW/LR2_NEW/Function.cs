using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LR2_NEW
{


    class Function
    {
        //public static double TopSellPhone(List<Phone> salesPhones)
        //{
        //    Console.WriteLine("Введите марку телефона и получите статистику(Samsung, Iphone, Xiaomi): ");
        //    string Company = Console.ReadLine();

        //        foreach (var phone in salesPhones)
        //        {
        //        if (phone.brand == Company)
        //        {
                    
        //        }
        //        else
        //        {
        //            Console.WriteLine("Такого бренда нету в магазине");
        //            break;
        //        }
        //        }
        //    return
            
        //}

        public static List <double> AverageSale(List<Phone> phones)
        {
            List<double> average = new List<double>();
            double count = 0;
            foreach (var phone in phones)
            {
                for(int i=1; phone.week >= i; i++)
                {
                    count += phone.countSell;
                }
                average.Add(count);
            }
            List<double>  Copy = new List<double>(average);

            for (int i = 0; i < Copy.Count - 1; i++)
            {
                for (int j = i + 1; j < Copy.Count; j++)
                {
                    if (Copy[j] > Copy[i])
                    {
                        double value = Copy[i];
                        Copy[i] = Copy[j];
                        Copy[j] = value;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{Copy[i]}");
                
            }
            return average;
        }
    }
}
