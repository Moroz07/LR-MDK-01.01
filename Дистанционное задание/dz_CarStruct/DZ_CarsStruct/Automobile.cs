using System;
using System.Collections.Generic;


namespace DZ_CarsStruct
{
    public struct Automobile
    {
        public string Name;
        public int Speed;
        public int Price;


        public static void TopCarsSpeed (List <Automobile> cars)
        {
            List <Automobile> CopyAuto = new List <Automobile> (cars);
            for(int i = 0; i < CopyAuto.Count-1; i++)
            {
                for(int j = i+1; j < CopyAuto.Count;j++)
                {
                    if (CopyAuto[j].Speed > CopyAuto[i].Speed)
                    {
                        Automobile value = CopyAuto[i];
                        CopyAuto[i] = CopyAuto[j];
                        CopyAuto[j] = value;

                    }
                }
            }
            Console.WriteLine("10 лучших машин по максимальной скорости");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{CopyAuto[i].Name},{CopyAuto[i].Price},{CopyAuto[i].Speed}");
                ;
            }
        }
    }


}
