using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelViewLib.Models;
using ModelViewLib.ModelViews;
using ModelViewLib.Presenter;

namespace FirstMVCProekt
{
    public partial class AddUserForm: Form
    {
        
        private IUserModels usersModel_;

        private User user_;
        private User user
        {
            get { return user_; }
            set { user_ = value; }
        }
        
        public AddUserForm(IUserModels model)
        {
            InitializeComponent();
            usersModel_ = model;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            List<User> Allusers = new List<User>();
            user = new User(LoginTextBox.Text,  PasswordTextBox.Text, NameTextBox.Text);
            bool result = usersModel_.Adduser(user);
            if (result)
            {
                MessageBox.Show("Пользователь успешно добавлен!", "Успех",
                    MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Такой пользователь уже существует!", "Ошибка",
                    MessageBoxButtons.OK);
                this.Close();
                
            }




        }
    }
}
