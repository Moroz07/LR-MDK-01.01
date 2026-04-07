using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OffsetLib
{
    public class Bike
    {
        private string name_;
        private int price_;
        private string manufacturer_;

        public Bike (string name, int price, string manufacturer)
        {
          name_ = name;
          price_ = price;
          manufacturer_ = manufacturer;
        }

        public string GetName()
        {
            return name_;
        }

        public int GetPrice()
        {
            return price_;
        }

        public string GetManufacturer()
        {
            return manufacturer_;
        }

    }
}
