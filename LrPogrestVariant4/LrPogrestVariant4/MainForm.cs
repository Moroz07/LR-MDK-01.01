using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LrPogrestVariant4
{
    public partial class MainForm : Form
    {
        public PgCarsLoader loader = new PgCarsLoader();
        public MainForm()
        {
            InitializeComponent();
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            BindingList<Car> cars = loader.Load();
            dataGridView.DataSource = cars;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView.SelectedRows[0];
            Car cars = row.DataBoundItem as Car;
            loader.DeleteSelectedUser(cars.Model);
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите учистить всех пользователей?", "Внимание!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                loader.ClearUser();
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            AddEditForm Addform = new AddEditForm(loader);
            Addform.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView.SelectedRows[0];
            Car selectedCar = row.DataBoundItem as Car;
            AddEditForm editform = new AddEditForm(loader);
            editform.SetCar(selectedCar);
            editform.Show();
        }
    }
}
