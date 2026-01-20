using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextWinForms
{
    public partial class MainForm: Form
    {
        int RndNumber_;
        

        public MainForm()
        {
            InitializeComponent();
            Random r = new Random();
            RndNumber_ = r.Next(1, 101);
            timer1.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        

        private void CheckButton_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(NumberBox.Text);
            if (b == RndNumber_)
            {
                MessageBox.Show("ПОЗДРАВЛЯЕМ!!! Вы угадали число");
            }
            else if (b > RndNumber_)
            {
                MessageBox.Show("Вы не угадали! Ваше число больше");
            }
            else if (b < RndNumber_)
            {
                MessageBox.Show("Вы не угадали! Ваше число меньше");
            }
            
        }
    }
}
