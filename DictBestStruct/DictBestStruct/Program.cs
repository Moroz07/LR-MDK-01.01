using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictBestStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            dict.Add("Шутер", new List<string>() {"Valorant"});
            dict.Add("Приключение", new List<string>() { "ROBLOX(Ведьмак 4)", "The Last Of Us 2" });
            dict.Add("Головоломки", new List<string>() { "Machinarium", "Portal 2", "Patric's Parabox" });

            Console.Write(string.Join(", ",dict.Keys));
        }
    }
}
