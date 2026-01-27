using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NasledWinForms
{
    public partial class MainForm: Form
    {
        private List<HomoSapiens> allpeoples_ = new List<HomoSapiens>();
        
        public MainForm()
        {
            InitializeComponent();
        
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            allpeoples_.Add(new HomoSapiens("Никита Андрианов", 18));
            allpeoples_.Add(new HomoSapiens("Влад Смирнов", 18));
            allpeoples_.Add(new HomoSapiens("Кирюха", 22));
            allpeoples_.Add(new Student(256));


            foreach (HomoSapiens people in allpeoples_)
            {
                HomoSapiensrichTextBox.AppendText(people.ToString() + "\n");
            }

            StudentrichTextBox.Text = string.Join(",", AllStudentInfo());
        }

        public List<string> AllStudentInfo()
        {
            List<string> result = new List<string>();
            foreach (HomoSapiens people in allpeoples_)
            {
                Student st = people as Student;
                if (st != null)
                {
                    result.Add(st.ToString());
                }
                
            }
            return result;
        }

    }
}
