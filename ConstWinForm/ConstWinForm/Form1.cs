using System.Collections.Generic;
using System.Windows.Forms;

namespace ConstWinForm
{
    public partial class MainForm: Form
    {
        private List<Student> ListStudent_ = new List<Student>();
        public MainForm()
        {
            InitializeComponent();

            ListStudent_.Add(new Student("Владислав", 17, 4.56, 15, @"D:\\П-30 2026\\фотки\\boy.jpg"));
            ListStudent_.Add(new Student("Никитос", 18, 4.44, 23, @"D:\\П-30 2026\\фотки\\Sigma.jpg"));
            ListStudent_.Add(new Student("Кирилл", 18, 4.52, 39, @"D:\\П-30 2026\\фотки\\Gigachad.jpg"));

            NameBox.DataSource = ListStudent_;
            NameBox.DisplayMember = "Name";

            

        }

        private void NameBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Student s1 = NameBox.SelectedItem as Student;
            AgeLabel.Text = s1.Age.ToString();
            AvgBallLabel.Text = s1.AvgBall.ToString();
            NumberTicketLabel.Text = s1.NumberTicket.ToString();
            ImageBox.Load(s1.Photo);
            
        }

        private void AgeLabel_Click(object sender, System.EventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AvgBallLabel_Click(object sender, System.EventArgs e)
        {

        }

        private void NumberTicketLabel_Click(object sender, System.EventArgs e)
        {

        }
    }
}
