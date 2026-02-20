using ModelViewLib.Models;
using ModelViewLib.ModelViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstMVCProekt
{
    public partial class AddUserForm: Form
    {
        MemoryUsersModel usersModels_;

        private User user_;
        private User user
        {
            get { return user_; }
            set { user_ = value; }
        }
        
        public AddUserForm()
        {
            InitializeComponent();
            usersModels_ = new MemoryUsersModel();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            List<User> Allusers = new List<User>();
            user = new User(LoginTextBox.Text, NameTextBox.Text, PasswordTextBox.Text);
            usersModels_.Adduser(user);
            
        }
    }
}
