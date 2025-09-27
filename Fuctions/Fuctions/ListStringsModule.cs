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
            Console.WriteLine();
            return list;
       }

        static public List<int> FindTextInList(string lines, List<string>List)
        {
            List<int> index = new List<int>();
            
            foreach(string s in List)
            {
                int i = 1;
                if (s.Contains(lines))
                {
                    Console.WriteLine(lines + "содержится во" + i + "элементе списка");
                }
                i++;
            }
            return index;
        }


    }
}
