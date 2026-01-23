using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstWinForm
{
    class Student
    {
        private string name_;
        private int age_;
        private double avgBall_;
        private int numberTicket_;
        private string photo_;


        public Student(string name, int age, double avgBall, int numberTicket, string photo)
        {
            name_ = name;
            age_ = age;
            avgBall_ = avgBall;
            numberTicket_ = numberTicket;
            photo_ = photo;
        }


        public string Name
        {
            get { return name_; }
        }

        public int Age
        {
            get { return age_; }
        }

        public double AvgBall
        {
            get { return avgBall_; }
        }

        public int NumberTicket
        {
            get { return numberTicket_; }
        }

        public string Photo
        {
            get { return photo_; }
           
        }
    }
}
