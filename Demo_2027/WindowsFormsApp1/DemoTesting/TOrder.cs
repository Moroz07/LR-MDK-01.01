using DemoLib;
using DemoLib.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DemoTesting
{
    [TestClass]
    public class TOrder
    {
        [TestMethod]
        public void TestTwoMonthsAgo()
        {
            ProductsModel model = new ProductsModel();
            List<Product> data_ = model.Load();

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
                ProductItem = "Женские босоножки «Черный кофе» со скульптурным каблуком",
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

            for (int i = 0; i < data_.Count; i++)
            {
                Assert.AreNotEqual(expectedPrices[i], data_[i].Price );
            }
        }

        [TestMethod]
        public void TestOneMonth()
        {
            ProductsModel model = new ProductsModel();
            List<Product> data_ = model.Load();
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
            for (int i = 0; i < data_.Count; i++)
            {
                Assert.AreEqual(expectedPrices[i], data_[i].Price);
            }
        }
        [TestMethod]
        public void TestThreeDifMonths()
        {
            ProductsModel model = new ProductsModel();
            List<Product> data_ = model.Load();

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

            Assert.AreEqual(expectedPrices[0], data_[0].Price);
            Assert.AreEqual(expectedPrices[1], data_[1].Price);
            Assert.AreEqual(expectedPrices[2], data_[2].Price);
        }
        [TestMethod]
        public void TestCalcDiscount()
        {
            ProductsModel model = new ProductsModel();
            List<Product> data_ = model.Load();

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

            Assert.AreEqual(expectedPrices[0], data_[0].Price);
            Assert.AreEqual(expectedPrices[1], data_[1].Price);
            Assert.AreEqual(expectedPrices[2], data_[2].Price);
        }
        [TestMethod]
        public void TestSaleOnFirstDayOfLastMonthNoDiscount()
        {
            ProductsModel model = new ProductsModel();
            List<Product> data_ = model.Load();

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

            Assert.AreEqual(expectedPrices[0], data_[0].Price);
            Assert.AreEqual(expectedPrices[1], data_[1].Price);           
        }
    }
}
