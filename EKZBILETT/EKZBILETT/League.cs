using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKZBILETT
{
    public class League
    {
        public string name_;
        public List<string> teams_;

        public League(string name, List<string> Teams)
        { 
            name_ = name; 
            teams_ = Teams;
        }
    }
}
