using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMovie.Module;

namespace TMovie.Views
{
    internal interface IMovie
    {
        List<Movie> LoadAllMovie();
    }
}
