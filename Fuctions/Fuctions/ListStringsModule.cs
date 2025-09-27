using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuctions
{
    class ListStringsModule
    {
       static public List<string> FillingTheList()
       {
            Console.WriteLine("Введите количество элементов списка");
            int count = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0; i < count; i++ )
            {
                Console.WriteLine("Введите " + (i+1) + " элемент списка");
                list.Add(Console.ReadLine());
            }
            return list;
       }
    }
}
