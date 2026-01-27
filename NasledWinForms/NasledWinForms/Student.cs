using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasledWinForms
{
    public class Student:HomoSapiens
    {
        private int numberTicket_;

        public Student (int numberTicket):base ("Артём", 18)
        {
            numberTicket_ = numberTicket;
        }

        public int NumberTicket
        {
            get { return numberTicket_; }
        }

        public override string ToString()
        {
            return base.ToString() + " номер билета: " + numberTicket_;
        }
    }
}
