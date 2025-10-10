using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

            foreach (int element in array)
            {
                Console.Write(element + " ");
            }

            int[] number = new int[200];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = i + 1;
            }

            List<int> Numbers = new List<int>();
            for (int j = 0; j < number.Length; j++)
            {
                int index = 0;
                int numbers = number[j];
                for (int i = 0; i < array.Length; i++)
                {
                    if (numbers == array[i])
                    {
                        index++;
                    }
                }
                if (index == 1)
                {
                    Numbers.Add(numbers);
                }
            }
            Console.WriteLine();
            
        }
    }  
}
