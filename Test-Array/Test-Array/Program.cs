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

        }
    }
}
