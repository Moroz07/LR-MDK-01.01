using ModelViewLib.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.Models
{
    public interface IUserModels
    {
        List<User> Load();
        bool Register(User user);
        void RemoveUsers(List<User> users);
    }
}
