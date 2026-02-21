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
        
        

        private User user_;
        public User user
        {
            get { return user_; }
            set { user_ = value; }
        }
        
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text.Trim() != "" && PasswordTextBox.Text.Trim() != "" && NameTextBox.Text.Trim() != "")
            {
                user_ = new User(LoginTextBox.Text, PasswordTextBox.Text, NameTextBox.Text);
                DialogResult = DialogResult.Yes;
                Close();
            }
            else
            {
                MessageBox.Show("Вы не заполнили все поля!", "Ошибка");
                
            }

        }

       

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
