using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VARIANT_5
{
    public class AnalysisDataModule
    {
        static public void SortGames(List<string> games, List<int> counts)
        {
            for (int i = 0; i < counts.Count; ++i)
            {
                for (int j = 0; j < counts.Count - 1; ++j)
                {
                    bool condition = counts[j + 1] > counts[j];
                    if (condition)
                    {
                        int temp_counts = counts[j];
                        counts[j] = counts[j + 1];
                        counts[j + 1] = temp_counts;

                        string temp_books = games[j];
                        games[j] = games[j + 1];
                        games[j + 1] = temp_books;
                    }
                }
            }
        }

        static public double CalculateAverage(List<int> counts)
        {
            int sum = 0;
            foreach (int count in counts)
            {
                sum += count;
            }

            return sum / counts.Count;
        }

    }
}
