using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace DemoLib.Models
{
    public class ProductsModel : IProductsModel
    {
        private List<Product> data_ = new List<Product>();

        public ProductsModel()
        {
            data_.Add(new Product { Name = "Женские босоножки «Черный кофе» со скульптурным каблуком", Category = "Кроссовки", Count = 10, Price = 1600.0, Supplier = "Топ-Топ", Parts = " 87% кожа, 11% текстиль, 2% синтетика" ,
                ImagePath = "..\\..\\..\\Images\\IMG_WS_185528.png"
            });
            data_.Add(new Product { Name = "Черные туфли в классическом стиле", Category = "Туфли", Count = 3, Price = 500.0, Supplier = "Барбари", Parts = "натуральная кожа ",
            ImagePath = "..\\..\\..\\Images\\IMG_MSho_190514.png"
            });
            data_.Add(new Product
            {
                Name = "Черные туфли в классическом стиле",
                Category = "Туфли",
                Count = 7,
                Price = 500.0,
                Supplier = "Барбари",
                Parts = "натуральная кожа ",
                ImagePath = ""
            });
        }

        public List<Product> Load()
        {
            return data_;
        }

        public int GetCountProducts()
        {
            return data_.Count;
        }
    }
}
