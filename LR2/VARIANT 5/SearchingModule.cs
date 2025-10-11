using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VARIANT_5
{
    public class SearchingModule
    {
        static public int FindIndexGenre(string userQuery, string[] genres)
        {
            for (int index = 0; index < genres.Length; ++index)
            {
                string valueGenre = genres[index].ToLower();
                if (valueGenre == userQuery.ToLower())
                {
                    return index;
                }
            }

            return -1;
        }



        static public (List<string>, List<int>) FindAllGamesByCenre(int indexGenre,
                                                                 List<string>[] allBooks,
                                                                 List<int>[] counts)
        {
            List<string> gamesByGenre = new List<string>();
            List<int> countsByGenre = new List<int>();

            gamesByGenre = allBooks[indexGenre];
            countsByGenre = counts[indexGenre];

            return (gamesByGenre, countsByGenre);
        }
    }
}
