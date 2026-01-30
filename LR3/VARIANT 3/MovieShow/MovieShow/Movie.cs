using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShow
{
    class Movie
    {
        private string name_;
        private int price_;
        private string director_;
        private string mainActor_;
        private DateTime enddate_;
        private string photo_;

        public Movie(string name,  int price, string director, string mainActor, DateTime enddate )
        {
            name_ = name;
            price_ = price;
            director_ = director;
            mainActor_ = mainActor;
            enddate_ = enddate;
            
        }

        public string Name
        { get { return name_; } }

        public int Price
        { get { return price_; } }

        public string Director
        { get { return director_; } }

        public string MainActor
        { get { return mainActor_; } }
        public DateTime Enddate 
        { get { return enddate_; } }
        public string Photo
        { get { return photo_; } }

        public string GetInfo()
        {
            return $"Название: {name_}\n Цена: {price_}\n Режиссер: {director_}\n Главные роли: {mainActor_} \n Срок завершения проката: {enddate_} ";
        }
    }
}
