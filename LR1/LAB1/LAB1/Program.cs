using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int Length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[Length];
            Console.WriteLine("Заполните его по одному числу: ");
            for(int i = 0; i< Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            //foreach (int element in array)
            //{
            //    Console.WriteLine(element);
            //}

            int max = -1999999999;
            int index = 0;
            for (int i = 0; i < Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                    
                }
            }
            Console.WriteLine("Максимальное число равно: " + max);
            Console.WriteLine("Его индекс: " + index);

        }
    }
}
