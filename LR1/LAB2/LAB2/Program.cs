using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[1500];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                
                array[i] = rand.Next(1, 200);
            }

            //foreach(int element in array)
            //{
            //    Console.Write(element + " ");
            //}
        }
    }
}
