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
    public partial class AddEditForm : Form
    {
        PgCarsLoader loader_;
        private bool editmode_ = false;
        public AddEditForm(PgCarsLoader loader)
        {
            InitializeComponent();
            loader_ = loader;
            AcceptButton.Enabled = false;
        }

        public void SetCar(Car u)
        {
            MarkTextBox.Text = u.Mark;
            ModelTextBox.Text = u.Model;
            PriceTextBox.Text = Convert.ToString(u.Price);
            YearNumericUpDown.Value = u.Year;
            ModelTextBox.Enabled = false;
            editmode_ = true;
        }

        public void AddCarOK()
        {
            Car car = new Car
            {
                Mark = MarkTextBox.Text,
                Model = ModelTextBox.Text,
                Year = (int)YearNumericUpDown.Value,
                Price = Convert.ToInt32(PriceTextBox.Text)
            };
            loader_.AddCar(car);
            this.Close();
        }

        public void AddCarAccept()
        {
            Car car = new Car
            {
                Mark = MarkTextBox.Text,
                Model = ModelTextBox.Text,
                Year = (int)YearNumericUpDown.Value,
                Price = Convert.ToInt32(PriceTextBox.Text)
            };
            loader_.AddCar(car);
            MarkTextBox.Clear();
            ModelTextBox.Clear();
            YearNumericUpDown.Value = 1970;
            PriceTextBox.Clear();

            AcceptButton.Enabled = false;
        }

        public void EditCarOK()
        {
            Car car = new Car
            {
                Mark = MarkTextBox.Text,
                Model = ModelTextBox.Text,
                Year = (int)YearNumericUpDown.Value,
                Price = Convert.ToInt32(PriceTextBox.Text)
            };
            loader_.EditCar(car);
            this.Close();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (editmode_)
            {
                EditCarOK();
            }
            else
            {
                AddCarOK();
            }
            Close();

        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (editmode_)
            {
                EditCarOK();
            }
            else
            {
                AddCarAccept();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MarkTextBox_TextChanged(object sender, EventArgs e)
        {
            AcceptButton.Enabled = true;
        }

        private void ModelTextBox_TextChanged(object sender, EventArgs e)
        {
            AcceptButton.Enabled = true;
        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            AcceptButton.Enabled = true;
        }

        private void YearNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            AcceptButton.Enabled = true;
        }
    }
}
