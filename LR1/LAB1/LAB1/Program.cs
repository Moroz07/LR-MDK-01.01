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
            for(int i = 0; i< Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            
            

        }
    }
}
