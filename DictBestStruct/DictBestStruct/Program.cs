using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictBestStruct
{
    class Program
    {
        static public void ShowCountElement(Dictionary<string, List <string>> dict)
        {
            Console.WriteLine("Укажите жанр игры(Шутер, Приключение, Головоломки): ");
            string userQuery = Console.ReadLine();
            if (dict.ContainsKey(userQuery))
            {
                List<string> value = dict[userQuery];
                Console.WriteLine("Число элементов: " + value.Count);
                Console.Write(string.Join(", ", value));
            }
            else Console.WriteLine("Ай-яй-яй, такого жанра нету балбес(дурак)!");
            
        }
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            dict.Add("Шутер", new List<string>() {"Valorant"});
            dict.Add("Приключение", new List<string>() { "ROBLOX(Ведьмак 4)", "The Last Of Us 2" });
            dict.Add("Головоломки", new List<string>() { "Machinarium", "Portal 2", "Patric's Parabox" });

            Console.Write(string.Join(", ",dict.Keys));
            Console.WriteLine();

           List <string> value = dict["Головоломки"];
                Console.Write(string.Join(", ", value));
            Console.WriteLine();
            ShowCountElement(dict);
            
        }
    }
}
