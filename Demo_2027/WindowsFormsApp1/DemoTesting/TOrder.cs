using DemoLib;
using DemoLib.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Net.Mail;

namespace DemoTesting
{
    [TestClass]
    public class TOrder
    {
        [TestMethod]
        public void TestTwoMonthsAgo()
        {
            ProductsModel model = new ProductsModel();
            model.LoadOrders().Clear();

            List<Product> data = new List<Product>();

            data.Add(new Product
            {
                Name = "Женские босоножки «Черный кофе» со скульптурным каблуком",
                Category = "Кроссовки",
                Count = 10,
                Price = 1600.0,
                Supplier = "Топ-Топ",
                Parts = " 87% кожа, 11% текстиль, 2% синтетика",
                ImagePath = "..\\..\\..\\Images\\IMG_WS_185528.png"
            });
            data.Add(new Product
            {
                Name = "Черные туфли в классическом стиле",
                Category = "Туфли",
                Count = 3,
                Price = 500.0,
                Supplier = "Барбари",
                Parts = "натуральная кожа",
                ImagePath = "..\\..\\..\\Images\\IMG_MSho_190514.png"
            });
            data.Add(new Product
            {
                Name = "Кеды",
                Category = "Туфли",
                Count = 7,
                Price = 600.0,
                Supplier = "Барбари",
                Parts = "натуральная кожа",
                ImagePath = ""
            });

            model.UpdateListModel(data);

            List<double> expectedPrices = new List<double>();

            expectedPrices.Add(1600.0);
            expectedPrices.Add(500);
            expectedPrices.Add(600);

            Order order_1 = new Order();

            order_1.Items = new List<OrderItem>();
            order_1.Items.Add(new OrderItem
            {
                ProductItem = "Женские босоножки «Черный кофе» со скульптурным каблуком",
                Count = 10,
                SaleDate = new System.DateTime(2026, 8, 10)
            });

            Order order_2 = new Order();

            order_2.Items = new List<OrderItem>();
            order_2.Items.Add(new OrderItem
            {
                ProductItem = "Черные туфли в классическом стиле",
                Count = 10,
                SaleDate = new System.DateTime(2026, 8, 10)
            });
            order_2.Items.Add(new OrderItem
            {
                ProductItem = "Кеды",
                Count = 1,
                SaleDate = new System.DateTime(2026, 8, 10)
            });

            List<Order> allOrder = new List<Order>();

            allOrder.Add(order_1);

            allOrder.Add(order_2);

            model.UpdatePrices(allOrder);

            for (int i = 0; i < data.Count; i++)
            {
                Assert.AreNotEqual(expectedPrices[i], data[i].Price);
            }
        }

        [TestMethod]
        public void TestOneMonth()
        {
            ProductsModel model = new ProductsModel();
            model.LoadOrders().Clear();

            List<Product> data = new List<Product>();

            data.Add(new Product
            {
                Name = "Женские босоножки «Черный кофе» со скульптурным каблуком",
                Category = "Кроссовки",
                Count = 10,
                Price = 1600.0,
                Supplier = "Топ-Топ",
                Parts = " 87% кожа, 11% текстиль, 2% синтетика",
                ImagePath = "..\\..\\..\\Images\\IMG_WS_185528.png"
            });
            data.Add(new Product
            {
                Name = "Черные туфли в классическом стиле",
                Category = "Туфли",
                Count = 3,
                Price = 500.0,
                Supplier = "Барбари",
                Parts = "натуральная кожа",
                ImagePath = "..\\..\\..\\Images\\IMG_MSho_190514.png"
            });
            data.Add(new Product
            {
                Name = "Кеды",
                Category = "Туфли",
                Count = 7,
                Price = 600.0,
                Supplier = "Барбари",
                Parts = "натуральная кожа",
                ImagePath = ""
            });

            model.UpdateListModel(data);

            List<double> expectedPrices = new List<double>();
            expectedPrices.Add(1600.0);
            expectedPrices.Add(500);
            expectedPrices.Add(600);

            Order order_1 = new Order();
            order_1.Items = new List<OrderItem>();
            order_1.Items.Add(new OrderItem
            {
                ProductItem = "Женские босоножки «Черный кофе» со скульптурным каблуком",
                Count = 10,
                SaleDate = new System.DateTime(2026, 9, 10)
            });

            Order order_2 = new Order();
            order_2.Items = new List<OrderItem>();
            order_2.Items.Add(new OrderItem
            {
                ProductItem = "Черные туфли в классическом стиле",
                Count = 10,
                SaleDate = new System.DateTime(2026, 9, 10)
            });
            order_2.Items.Add(new OrderItem
            {
                ProductItem = "Кеды",
                Count = 1,
                SaleDate = new System.DateTime(2026, 9, 10)
            });
            List<Order> allOrder = new List<Order>();
            allOrder.Add(order_1);
            allOrder.Add(order_2);
            model.UpdatePrices(allOrder);
            for (int i = 0; i < data.Count; i++)
            {
                Assert.AreEqual(expectedPrices[i], data[i].Price);
            }
        }
        [TestMethod]
        public void TestThreeDifMonths()
        {
            ProductsModel model = new ProductsModel();
            model.LoadOrders().Clear();

            List<Product> data = new List<Product>();

            data.Add(new Product
            {
                Name = "Женские босоножки «Черный кофе» со скульптурным каблуком",
                Category = "Кроссовки",
                Count = 10,
                Price = 1600.0,
                Supplier = "Топ-Топ",
                Parts = " 87% кожа, 11% текстиль, 2% синтетика",
                ImagePath = "..\\..\\..\\Images\\IMG_WS_185528.png"
            });
            data.Add(new Product
            {
                Name = "Черные туфли в классическом стиле",
                Category = "Туфли",
                Count = 3,
                Price = 500.0,
                Supplier = "Барбари",
                Parts = "натуральная кожа",
                ImagePath = "..\\..\\..\\Images\\IMG_MSho_190514.png"
            });
            data.Add(new Product
            {
                Name = "Кеды",
                Category = "Туфли",
                Count = 7,
                Price = 600.0,
                Supplier = "Барбари",
                Parts = "натуральная кожа",
                ImagePath = ""
            });

            model.UpdateListModel(data);

            List<double> expectedPrices = new List<double>();

            expectedPrices.Add(1200.0);
            expectedPrices.Add(500);
            expectedPrices.Add(450);

            Order order_1 = new Order();

            order_1.Items = new List<OrderItem>();
            order_1.Items.Add(new OrderItem
            {
                ProductItem = "Женские босоножки «Черный кофе» со скульптурным каблуком",
                Count = 10,
                SaleDate = new System.DateTime(2026, 8, 10)
            });

            Order order_2 = new Order();

            order_2.Items = new List<OrderItem>();
            order_2.Items.Add(new OrderItem
            {
                ProductItem = "Черные туфли в классическом стиле",
                Count = 10,
                SaleDate = new System.DateTime(2026, 9, 10)
            });

            Order order_3 = new Order();
            order_3.Items = new List<OrderItem>();

            order_3.Items.Add(new OrderItem
            {
                ProductItem = "Кеды",
                Count = 10,
                SaleDate = new System.DateTime(2026, 10, 10)
            });

            List<Order> allOrder = new List<Order>();

            allOrder.Add(order_1);
            allOrder.Add(order_2);
            allOrder.Add(order_3);

            model.UpdatePrices(allOrder);

            Assert.AreEqual(expectedPrices[0], data[0].Price);
            Assert.AreEqual(expectedPrices[1], data[1].Price);
            Assert.AreEqual(expectedPrices[2], data[2].Price);
        }
        [TestMethod]
        public void TestCalcDiscount()
        {
            ProductsModel model = new ProductsModel();
            model.LoadOrders().Clear();

            List<Product> data = new List<Product>();

            data.Add(new Product
            {
                Name = "Женские босоножки «Черный кофе» со скульптурным каблуком",
                Category = "Кроссовки",
                Count = 10,
                Price = 1600.0,
                Supplier = "Топ-Топ",
                Parts = " 87% кожа, 11% текстиль, 2% синтетика",
                ImagePath = "..\\..\\..\\Images\\IMG_WS_185528.png"
            });
            data.Add(new Product
            {
                Name = "Черные туфли в классическом стиле",
                Category = "Туфли",
                Count = 3,
                Price = 500.0,
                Supplier = "Барбари",
                Parts = "натуральная кожа",
                ImagePath = "..\\..\\..\\Images\\IMG_MSho_190514.png"
            });
            data.Add(new Product
            {
                Name = "Кеды",
                Category = "Туфли",
                Count = 7,
                Price = 600.0,
                Supplier = "Барбари",
                Parts = "натуральная кожа",
                ImagePath = ""
            });

            model.UpdateListModel(data);

            List<double> expectedPrices = new List<double>();

            expectedPrices.Add(1200.0);
            expectedPrices.Add(375);
            expectedPrices.Add(450);

            Order order_1 = new Order();

            order_1.Items = new List<OrderItem>();
            order_1.Items.Add(new OrderItem
            {
                ProductItem = "Женские босоножки «Черный кофе» со скульптурным каблуком",
                Count = 10,
                SaleDate = new System.DateTime(2026, 10, 10)
            });

            Order order_2 = new Order();

            order_2.Items = new List<OrderItem>();
            order_2.Items.Add(new OrderItem
            {
                ProductItem = "Черные туфли в классическом стиле",
                Count = 10,
                SaleDate = new System.DateTime(2026, 10, 10)
            });

            Order order_3 = new Order();
            order_3.Items = new List<OrderItem>();

            order_3.Items.Add(new OrderItem
            {
                ProductItem = "Кеды",
                Count = 10,
                SaleDate = new System.DateTime(2026, 10, 10)
            });

            List<Order> allOrder = new List<Order>();

            allOrder.Add(order_1);
            allOrder.Add(order_2);
            allOrder.Add(order_3);

            model.UpdatePrices(allOrder);

            Assert.AreEqual(expectedPrices[0], data[0].Price);
            Assert.AreEqual(expectedPrices[1], data[1].Price);
            Assert.AreEqual(expectedPrices[2], data[2].Price);
        }
        [TestMethod]
        public void TestSaleOnFirstDayOfLastMonthNoDiscount()
        {
            ProductsModel model = new ProductsModel();
            model.LoadOrders().Clear();

            List<Product> data = new List<Product>();

            data.Add(new Product
            {
                Name = "Женские босоножки «Черный кофе» со скульптурным каблуком",
                Category = "Кроссовки",
                Count = 10,
                Price = 1600.0,
                Supplier = "Топ-Топ",
                Parts = " 87% кожа, 11% текстиль, 2% синтетика",
                ImagePath = "..\\..\\..\\Images\\IMG_WS_185528.png"
            });
            data.Add(new Product
            {
                Name = "Черные туфли в классическом стиле",
                Category = "Туфли",
                Count = 3,
                Price = 500.0,
                Supplier = "Барбари",
                Parts = "натуральная кожа",
                ImagePath = "..\\..\\..\\Images\\IMG_MSho_190514.png"
            });
            data.Add(new Product
            {
                Name = "Кеды",
                Category = "Туфли",
                Count = 7,
                Price = 600.0,
                Supplier = "Барбари",
                Parts = "натуральная кожа",
                ImagePath = ""
            });

            model.UpdateListModel(data);

            List<double> expectedPrices = new List<double>();

            expectedPrices.Add(1600.0);
            expectedPrices.Add(500);

            Order order_1 = new Order();

            order_1.Items = new List<OrderItem>();
            order_1.Items.Add(new OrderItem
            {
                ProductItem = "Женские босоножки «Черный кофе» со скульптурным каблуком",
                Count = 10,
                SaleDate = new System.DateTime(2026, 9, 1)
            });

            Order order_2 = new Order();

            order_2.Items = new List<OrderItem>();
            order_2.Items.Add(new OrderItem
            {
                ProductItem = "Черные туфли в классическом стиле",
                Count = 10,
                SaleDate = new System.DateTime(2026, 9, 30)
            });

          
            List<Order> allOrder = new List<Order>();

            allOrder.Add(order_1);
            allOrder.Add(order_2);           
            model.UpdatePrices(allOrder);

            Assert.AreEqual(expectedPrices[0], data[0].Price);
            Assert.AreEqual(expectedPrices[1], data[1].Price);           
        }
    }
}
