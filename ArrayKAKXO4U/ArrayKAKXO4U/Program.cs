using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayKAKXO4U
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int Length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            foreach (int i in array)
            {
                Console.WriteLine(i + "");
            }

        }
    }
}
