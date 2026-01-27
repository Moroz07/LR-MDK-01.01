using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasledWinForms
{
    public class HomoSapiens
    {
        protected string name_;
        protected int age_;

        public HomoSapiens (string name, int age)
        {
            this.name_ = name;
            this.age_ = age;
        }

        public override string ToString()
        {
            return $"{name_}, {age_} лет";
        }
    }


}
