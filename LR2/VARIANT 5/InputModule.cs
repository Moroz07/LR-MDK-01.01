using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VARIANT_5
{
    public class InputModule
    {
        static public (List<string>[], List<int>[]) InputGamesByCenre()
        {
            List<string>[] gamesByGenre = new List<string>[3] { new List<string>(),
                                                        new List<string>(),
                                                        new List<string>()
    };

            List<int>[] counts = new List<int>[3]{ new List<int>(),
                                           new List<int>(),
                                           new List<int>()
    };

            //Заполняем игры Экшн (Нулевой индекс)
            gamesByGenre[0].Add("Red Dead Redemption 2");
            counts[0].Add(320000);
            gamesByGenre[0].Add("Hollow Knight: Silksong");
            counts[0].Add(350000);
            gamesByGenre[0].Add("Dying Light: The Beast");
            counts[0].Add(220000);

            //Заполняем игры Стратегии (Первый индекс)
            gamesByGenre[1].Add("Dota 2");
            counts[1].Add(780000);
            gamesByGenre[1].Add("Terraria");
            counts[1].Add(300000);
            gamesByGenre[1].Add("Spore");
            counts[1].Add(100000);
            gamesByGenre[1].Add("Fallout");
            counts[1].Add(200000);
            gamesByGenre[1].Add("Civilization 5");
            counts[1].Add(230000);

            /// Заполняем игры Шутер (второй индекс)
            gamesByGenre[2].Add("CS 2");
            counts[2].Add(950000);
            gamesByGenre[2].Add("Мир Танков");
            counts[2].Add(850000);
            gamesByGenre[2].Add("GTA 5");
            counts[2].Add(450000);
            gamesByGenre[2].Add("Far Cry 3");
            counts[2].Add(140000);
            gamesByGenre[2].Add("DOOM");
            counts[2].Add(330000);
            gamesByGenre[2].Add("Half-Life 2");
            counts[2].Add(670000);
            gamesByGenre[2].Add("BioShock");
            counts[2].Add(175000);

            return (gamesByGenre, counts);
        }
    }
}
