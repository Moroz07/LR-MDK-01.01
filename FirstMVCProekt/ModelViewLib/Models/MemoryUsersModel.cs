using ModelViewLib.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.Models
{
     public class MemoryUsersModel : IUserModels
    {

        private List<User> allusers_ = new List<User>();

        public MemoryUsersModel()
        {
            allusers_.Add(new User("Nikitos", "123321","Nikita Andrianov" ));
            allusers_.Add(new User("Vlados", "qwerty222", "Vladislav Smirnov"));
            allusers_.Add(new User("Kirill Sigma", "SuperKrytoiKirill", "Kirill Shamarin"));
            allusers_.Add(new User("Tem4ik", "Pumba321", "Artem Morozov"));
        }
        public List<User> Load()
        {

            return allusers_;
        }

        public bool Register(User user)
        {
            int count = allusers_.Count;
            allusers_.Add(user);
            if (allusers_.Count > count)
            {
                return true;
            }
                return false;
                
        }

        
    }
}
