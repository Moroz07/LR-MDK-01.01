using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFileStorage
{
    class FileUserStorage : IUsersInterface
    {
        public List<User> Load()
        {
            List<User> AllUser = new List<User>();
            string path = "info.txt";
            StreamReader info = new StreamReader(path);

            string line;
            while ((line = info.ReadLine()) != null)
            {
                string[] lines = line.Split('-');
                AllUser.Add(new User (lines[0], lines[1]));

            }
            return AllUser;
            
        }
    }
}
