using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreOfPhone
{
    internal class Function
    {
        static public double AmountSale(List<Phone> SalesPhone)
        {
            DateTime startDate = new DateTime(2025, 11, 1);
            DateTime EndDate = new DateTime(2025, 11, 12);
            double AmountSum = 0;
            foreach (var sale in SalesPhone)
            {
                if ((sale.SellData >= startDate) && (sale.SellData <= EndDate))
                {
                    AmountSum += sale.price * sale.count;
                }
            }

            return AmountSum;
        }

        public static (string, string) TopSalePhone(List<Phone> SalesPhone)
        {
            string phoneTopSell = "";
            string phoneMinSell = "";
            double countPhone = 0;
            double countPhoneMin = int.MaxValue;
            foreach (var phone in SalesPhone)
            {

                if (countPhone < phone.count)
                {
                    countPhone = phone.count;
                    phoneTopSell = phone.name;
                }

                if (countPhoneMin > phone.count)
                {
                    countPhoneMin = phone.count;
                    phoneMinSell = phone.name;
                }


            }
            return (phoneTopSell, phoneMinSell);

        }

        public static void TopTwoPhone(List<Phone> phones)
        {
            string topPhones1 = "";
            string topPhones2 = "";
            double maxProfit1 = 0;
            double maxProfit2 = 0;

            Dictionary<string, double> modelProfit = new Dictionary<string, double>();
            foreach (Phone phone in phones)
            {
                double profit = phone.price * phone.count;
                if (modelProfit.ContainsKey(phone.name))

                {
                    modelProfit[phone.name] += profit;
                }
                else
                {
                    modelProfit.Add(phone.name, profit);
                }

            }

            foreach (string phone in modelProfit.Keys)
            {
                double profit = modelProfit[phone];

                if (profit > maxProfit1)
                {
                    maxProfit2 = maxProfit1;
                    topPhones2 = topPhones1;

                    maxProfit1 = profit;
                    topPhones1 = phone;
                }

                else if (profit > maxProfit2)
                {
                    maxProfit2 = profit;
                    topPhones2 = phone;
                }
            }

            Console.WriteLine("Два самых прибыльных телефона: ");
            Console.WriteLine($"1. " + topPhones1 + " " + maxProfit1);
            Console.WriteLine($"2. " + topPhones2 + " " + maxProfit2);
        }
    }
}
