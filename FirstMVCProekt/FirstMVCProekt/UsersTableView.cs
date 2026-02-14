using ModelViewLib.Models;
using ModelViewLib.ModelViews;
using ModelViewLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstMVCProekt
{
    class UsersTableView : DataGridView, IUsersView
    {

        public List<User> GetSelectedUser()
        {
            List<User> result = new List<User>();
            foreach(var row in SelectedRows)
            {
                result.Add(row as User);
            }
            return result;
        }
        public void ShowUsers(List<User> allUsers)
        {
          DataSource = allUsers;
        }
    }
}
