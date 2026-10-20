using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DemoLib.Models
{
    public class ProductsModel : IProductsModel
    {
        private List<Product> data_ = new List<Product>();
        private List<Order> orders_ = new List<Order>();
        IOrderRepository repository_;


        public ProductsModel(IOrderRepository repository)
        {
            repository_ = repository;

            data_.Add(new Product
            {
                Name = "Женские босоножки «Черный кофе» со скульптурным каблуком",
                Category = "Кроссовки",
                Count = 10,
                Price = 1600.0,
                Supplier = "Топ-Топ",
                Parts = " 87% кожа, 11% текстиль, 2% синтетика",
                ImagePath = "..\\..\\..\\Images\\IMG_WS_185528.png"
            });
            data_.Add(new Product
            {
                Name = "Черные туфли в классическом стиле",
                Category = "Туфли",
                Count = 3,
                Price = 500.0,
                Supplier = "Барбари",
                Parts = "натуральная кожа ",
                ImagePath = "..\\..\\..\\Images\\IMG_MSho_190514.png"
            });
            data_.Add(new Product
            {
                Name = "Кеды",
                Category = "Туфли",
                Count = 7,
                Price = 600.0,
                Supplier = "Барбари",
                Parts = "натуральная кожа ",
                ImagePath = ""
            });

            orders_ = repository_.Load();

            //Order order_1 = new Order();

            //order_1.Items = new List<OrderItem>();
            //order_1.Items.Add(new OrderItem
            //{
            //    ProductItem = "Женские босоножки «Черный кофе» со скульптурным каблуком",
            //    Count = 10,
            //    SaleDate = new System.DateTime(2026, 8, 10)
            //});
            //Order order_2 = new Order();

            //order_2.Items = new List<OrderItem>();
            //order_2.Items.Add(new OrderItem
            //{
            //    ProductItem = "Черные туфли в классическом стиле",
            //    Count = 10,
            //    SaleDate = new System.DateTime(2026, 9, 10)
            //});
            //Order order_3 = new Order();

            //order_3.Items = new List<OrderItem>();
            //order_3.Items.Add(new OrderItem
            //{
            //    ProductItem = "Кеды",
            //    Count = 10,
            //    SaleDate = new System.DateTime(2026, 10, 10)
            //});
            //orders_.Add(order_1);
            //orders_.Add(order_2);
            //orders_.Add(order_3);

            UpdatePrices(orders_);
        }


        public void UpdateListModel(List<Product> Artem)
        {
            data_ = Artem;
        }
        public List<Product> Load()
        {
            return data_;
        }
        public List<Order> LoadOrders()
        {
            return orders_;
        }

        public int GetCountProducts()
        {
            return data_.Count;
        }

        public void UpdatePrices(List<Order> orders)
        {
            DateTime current = DateTime.Now; // 10.10.2026

            DateTime prevMontsDate = current.AddMonths(-1); // 10.09.2026
            DateTime start = new DateTime(prevMontsDate.Year, prevMontsDate.Month, 1); // 01.09.2026
            DateTime end = new DateTime(prevMontsDate.Year, prevMontsDate.Month + 1, 1).AddDays(-1); // 30.09.2026

            List<Product> discountProducts = data_
                .Where(product => !orders
                    .SelectMany(order => order.Items)
                    .Any(item => item.ProductItem == product.Name
                    && item.SaleDate >= start
                    && item.SaleDate <= end))
                .ToList();

            foreach (Product product in discountProducts)
            {
                product.Price = product.Price * 0.75;
            }
        }
    }
}
