using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFileStorage
{
    public partial class MainForm : Form
    {
        private FileUserStorage authorization = new FileUserStorage();
        public MainForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            List<User> iden = authorization.Load();
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            User user = new User(login, password);

            if(Contains(iden, user))
            {
                MessageBox.Show("Вы вошли в систему!");
            }
            else
            {
                MessageBox.Show("Проверьте логин или пароль");
            }


            //foreach (User u in iden)
            //{
            //    if (user.Login == u.Login)
            //    {
            //        if (user.Password == u.Password)
            //        {
            //            MessageBox.Show("Вы вошли в систему!");
            //            break;
            //        }


                //    }
                //    else
                //    {
                //        MessageBox.Show("Проверьте логин");

                //    }
                //}


        }
        private bool Contains(List<User> users, User user)
        {
            foreach (User u in users)
            {
                if (user.Login == u.Login && user.Password == u.Password)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
