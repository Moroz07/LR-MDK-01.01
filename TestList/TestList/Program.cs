using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Text = new List<string>();
            Text.Add("CASE");
            Text.Add("Battle");
            Text.Add("Top");
            Text.Add("Do dep");
            Text.Add("Nikita");

            Console.WriteLine("Введите текст: ");
            string input = Console.ReadLine();
            //Console.WriteLine(input);

            List<string> list = new List<string>();

            for(int i = 0; i <Text.Count; i++)
            {
                if (Text[i].Contains(input))
                {
                    list.Add(Text[i]);
                }
            }

            foreach(string element in list)
            {
                Console.WriteLine(element);
            }
            
        }
    }
}
