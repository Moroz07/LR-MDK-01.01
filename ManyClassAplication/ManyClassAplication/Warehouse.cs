using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ManyClassAplication
{
    class Warehouse
    {
        private int id_;
        private string location_;
        private Dictionary<Goods, int> products_ = new Dictionary<Goods, int>();

        public void SetId(int id)
        {
            id_ = id;
        }
        public void SetLocation(string location)
        {
            location_ = location;
        }
        public void SetProductQuantity(Goods product, int quantity)
        {
            products_.Add(product, quantity);
        }
        public void GetProductQuantity()
        {
            foreach (Goods product in products_.Keys)
            {
                Console.WriteLine(product.GetName() + " - " + products_[product]);
            }
        }
        public void CalculateMoney()
        {
            double sum = 0;
            foreach (Goods product in products_.Keys)
            {
                sum += product.GetPrice() * products_[product];
            }
            Console.WriteLine(sum);
        }
    }
}
