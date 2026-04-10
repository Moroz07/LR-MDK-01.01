using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LrPogrestVariant4
{
    public class Car
    {
        public string mark_;
        public string model_;
        public int year_;
        public int price_;
        [DisplayName("Марка")]
        public string Mark { get { return mark_; } set { mark_ = value; OnPropertyChanged(nameof(Mark)); } }
        [DisplayName("Модель")]
        public string Model { get { return model_; } set { model_ = value; OnPropertyChanged(nameof(Model)); } }
        [DisplayName("Год выпуска")]
        public int Year { get { return year_; } set { year_ = value; OnPropertyChanged(nameof(Year)); } }
        [DisplayName("Цена")]
        public int Price { get { return price_; } set { price_ = value; OnPropertyChanged(nameof(Price)); } }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
