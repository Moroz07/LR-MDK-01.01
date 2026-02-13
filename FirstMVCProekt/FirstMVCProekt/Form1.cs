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



namespace FirstMVCProekt
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            UsersTableView usersTable = new UsersTableView();
            Controls.Add(usersTable);
            usersTable.Dock = DockStyle.Top;

            UserPresenter userPresenter = new UserPresenter(new MemoryUsersModel(), usersTable);
        }
    }
}
