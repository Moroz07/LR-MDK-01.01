using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuctions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = ListStringsModule.FillingTheList();
            Console.WriteLine("Последний элемент списка: " + list.Last());
            Console.WriteLine("Размер списка: " + list.Count);


        }
    }
}
