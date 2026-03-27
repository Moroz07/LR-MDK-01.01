using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace DBTestWinForm
{
    public partial class AddForm: Form
    {
        PgUsersLoader loader_;
        private bool editmode_ = false;

        public AddForm(PgUsersLoader loader)
        {
            InitializeComponent();
            loader_ = loader;
            AcceptButton.Enabled = false;
        }

       public void SetUser(User u)
        {
            LoginTextBox.Text = u.Login;
            PasswordTextBox.Text = u.Password;
            NameTextBox.Text = u.Name;
            AgeNumericUpDown.Value = u.Age;
            LoginTextBox.Enabled = false;
            editmode_ = true;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (editmode_)
            {
                EditUserOK();
            }
            else
            {
                AddUserOK();
            }
            Close();

        }

        

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (editmode_)
            {
                EditUserOK();
            }
            else
            {
                AddUserAccept();
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            
                AcceptButton.Enabled = true;
           
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            
                AcceptButton.Enabled = true;
          
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            
                AcceptButton.Enabled = true;
         
        }

        private void AgeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
           
                AcceptButton.Enabled = true;
          
        }

        public void EditUserOK()
        {
            User user = new User
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                Age = (int)AgeNumericUpDown.Value,
                Name = NameTextBox.Text,
            };
            loader_.EditUser(user);
            this.Close();
        }

        public void AddUserOK()
        {
            User user = new User
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                Age = (int)AgeNumericUpDown.Value,
                Name = NameTextBox.Text,
            };
            loader_.AddUser(user);
            this.Close();
        }
        public void AddUserAccept()
        {
            User user = new User
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                Age = (int)AgeNumericUpDown.Value,
                Name = NameTextBox.Text,
            };
            loader_.AddUser(user);
            LoginTextBox.Clear();
            PasswordTextBox.Clear();
            AgeNumericUpDown.Value = 18;
            NameTextBox.Clear();

            AcceptButton.Enabled = false;
        }
    }
}
