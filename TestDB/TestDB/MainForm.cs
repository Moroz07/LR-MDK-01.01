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

namespace TestDB
{
    public partial class MainForm: Form
    {
        PGUsersLoader postgres = new PGUsersLoader();
        public MainForm()
        {
            InitializeComponent();
            UsersDataGridView.DataSource = postgres.Load();
            
        }
    }
}
