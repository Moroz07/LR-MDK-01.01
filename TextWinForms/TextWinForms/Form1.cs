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
        private int currentSecond_;
        private int tryNumber_;
        


        public MainForm()
        {
            InitializeComponent();
            Random r = new Random();
            RndNumber_ = r.Next(1, 101);
            timer.Start();
            currentSecond_ = 0;
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentSecond_++;
            CountDownTime.Value = new DateTime(2025, 01, 01, 0, 1, 0).AddSeconds(-currentSecond_);
            if (currentSecond_ >= 60)
            {
                timer.Stop();
                MessageBox.Show("Время вышло, вы проиграли");
                Application.Exit();
            }
            

        }

        

        private void CheckButton_Click(object sender, EventArgs e)
        {

            tryNumber_++;
            int b = Convert.ToInt32(NumberBox.Text);
            if (b == RndNumber_)
            {
                timer.Stop();
                StatisticRichBox.AppendText("Попытка номер: " + tryNumber_ + ". Ваше число: " + NumberBox.Text + "\n"+ "Вы угадали за " + currentSecond_ + " секунд(ы/у)"+ "\n");
                MessageBox.Show("ПОЗДРАВЛЯЕМ!!! Вы угадали число");
            }
            else if (b > RndNumber_)
            {
                StatisticRichBox.AppendText("Попытка номер: " + tryNumber_ + ". Ваше число: " + NumberBox.Text + " .Нужно число меньше" + "\n" );
                MessageBox.Show("Вы не угадали! Загаданное число меньше");
            }
            else if (b < RndNumber_)
            {
                StatisticRichBox.AppendText("Попытка номер: " + tryNumber_ + ". Ваше число: " + NumberBox.Text + " .Нужно число больше" + "\n");
                MessageBox.Show("Вы не угадали! Загаданное число больше");
            }
            

        }

       
    }
}
