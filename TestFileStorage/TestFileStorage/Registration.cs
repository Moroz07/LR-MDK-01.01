using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFileStorage
{
    public partial class Registration: Form
    {
        PgUsersLoader registration_;
        public Registration(PgUsersLoader registration)
        {
            InitializeComponent();
            registration_ = registration;

        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            User user = new User(login, password);
            if (password == null)
            {
                MessageBox.Show("Вы не ввели пароль");
                return;
            }

            if (registration_.UserVerification(login))
            {
                MessageBox.Show("Такой пользователь уже существует");
            }
            else
            {
                if (registration_.UserRegistration(user))
                {
                    MessageBox.Show("Вы успешно зарегистрировались");
                    this.Close();
                }
            }
        }
        
    }
}
