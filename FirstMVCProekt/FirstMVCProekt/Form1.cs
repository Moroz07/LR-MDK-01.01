using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelViewLib.Presenter;
using ModelViewLib.Models;
using ModelViewLib.ModelViews;



namespace FirstMVCProekt
{
    public partial class Form1: Form
    {
        private UserPresenter presenter_;
        public Form1()
        {
            InitializeComponent();

            presenter_ = new UserPresenter(new MemoryUsersModel(), usersTableView1);
          
        }

        private void RemoveToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить пользователей?",
                                 "Внимание!",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)
                                 == DialogResult.Yes)
            {
                List<User> selectedUsers = usersTableView1.GetSelectedUser();
                presenter_.RemoveUsers(selectedUsers);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddUserForm addUser = new AddUserForm();
            
            if (addUser.ShowDialog() == DialogResult.Yes)
            {
                presenter_.Adduser(addUser.user);
            }
        }

        
    }
}
