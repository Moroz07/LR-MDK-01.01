using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VARIANT_5
{
    class Program
    {
        static void Print(List<string> games)
        {
            Console.WriteLine(String.Join(", ", games));
        }

        static void Prints(List<int> count)
        {
            Console.WriteLine(String.Join(", ", count));
        }

        static void Main()
        {
            string[] genres = new string[] { "Экшн", "Стратегия", "Шутер" };
            var (games, counts) = InputModule.InputGamesByCenre();

            string userQuery = InputModule.InputUserQuery();

            int indexGenre = SearchingModule.FindIndexGenre(userQuery, genres);
            if (indexGenre < 0)
            {
                Console.WriteLine("Указан несуществующий жанр");
                return;
            }

            var (gamesUserGenre, countsUserGenre) = SearchingModule.FindAllGamesByCenre(indexGenre, games, counts);

            AnalysisDataModule.SortGames(gamesUserGenre, countsUserGenre);
            Print(gamesUserGenre);
            Prints(countsUserGenre);


        }
    }
}
