using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShow
{
    internal class StorageMovie : IMovie
    {
        public List<Movie> Movie()
        {
            List<Movie> list = new List<Movie>();
            string path = @"C:\\repo\\Морозов\\LR3\\Фильмы\\Фильмы.csv";
            StreamReader info = new StreamReader(path);
            string line;
            while ((line = info.ReadLine()) != null)
            {
                string [] lines = line.Split(';');
                list.Add(new Movie(lines[0], Convert.ToInt32(lines[1]), lines[2], lines[3], Convert.ToDateTime(lines[4]), lines[5]));
            }
            info.Close();
            return list;

        }
    }
}
