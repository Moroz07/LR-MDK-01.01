using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[3];
            array[0] = "br";
            array[1] = "brr";
            array[2] = "Patapim";

            array[1] = "MC OG";

            foreach (string show in array)
            {
                Console.WriteLine(show);
            }

            string[] massiv = new string[3];
            massiv[0] = array[2];
            massiv[1] = array[1];
            massiv[2] = array[0];

            int[] massa = new int[10000];
            //for (int i = 0; i < massa.Length; i++)
            //{
            //    massa[i] = i + 1;
            //}

            //Console.Write("[");
            //for (int i = 0; i < massa.Length - 1; i++)
            //{
            //    Console.Write(massa[i] + ",");
            //}
            //Console.Write(massa.Length + "]");

            for (int i = 0; i < massa.Length; i++)
            {
                massa[i] = (i + 1) * 2;
            }

            //Console.Write("[");
            //for (int i = 0; i < massa.Length - 1; i++)
            //{
            //    Console.Write(massa[i] + ",");
            //}
            //Console.Write(massa.Length * 2 + "]");

            for (int i = 0; i < massa.Length; i++)
            {
                int l = 0;
                for (int j = 0; j < massa.Length; j++)
                {
                    if (massa[i] + massa[j]==massa.Length-1)
                    {
                        l = massa[i];
                        massa[i] = massa[j];
                        massa[j] = l;
                    }
                }
               
            }


            for (int i = 0; i < massa.Length - 1; i++)
            {
                Console.Write(massa[i] + ",");
            }




        }
    }
}
