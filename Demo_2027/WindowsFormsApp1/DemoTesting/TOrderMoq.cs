using DemoLib;
using DemoLib.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace DemoTesting
{
    [TestClass]
    public class TOrderMoq
    {
        // ТЕСТ 1: Проверяем, что модель вызывает метод Load() у репозитория
        [TestMethod]
        public void UpdatePrices_CallsRepository_VerifyCalled()
        {
            var mockRepository = new Mock<IOrderRepository>();     
            mockRepository.Setup(repo => repo.Load()).Returns(new List<Order>());

            ProductsModel model = new ProductsModel(mockRepository.Object);

            mockRepository.Verify(repo => repo.Load(), Times.AtLeastOnce);
        }

        // ТЕСТ 2: Товар продавался в прошлом месяце -> скидки нет
        [TestMethod]
        public void UpdatePrices_ProductSoldLastMonth_NoDiscount()
        {
            DateTime currentMonth = DateTime.Now;
            DateTime lastMonth = DateTime.Now.AddMonths(-1);
            DateTime twoMonthAgo = DateTime.Now.AddMonths(-2);
            List<Order> testOrders = new List<Order>
            {
                new Order
                {
                    Items = new List<OrderItem>
                    {
                        new OrderItem { ProductItem = "Кеды", Count = 1, SaleDate = lastMonth }
                    }
                },
                new Order
                {
                    Items = new List<OrderItem>
                    {
                        new OrderItem { ProductItem = "Черные туфли в классическом стиле", Count = 2, SaleDate = twoMonthAgo }
                    }
                },
                new Order
                {
                    Items = new List<OrderItem>
                    {
                        new OrderItem { ProductItem = "Женские босоножки «Черный кофе» со скульптурным каблуком", Count = 3, SaleDate = twoMonthAgo }
                    }
                },
                new Order
                {
                    Items = new List<OrderItem>
                    {
                        new OrderItem { ProductItem = "Женские босоножки «Черный кофе» со скульптурным каблуком", Count = 4, SaleDate = lastMonth },
                        new OrderItem { ProductItem = "Кеды", Count = 5, SaleDate = currentMonth }
                    }
                }
            };

            var mockRepository = new Mock<IOrderRepository>();
            mockRepository.Setup(repo => repo.Load()).Returns(testOrders);

            ProductsModel model = new ProductsModel(mockRepository.Object);

            List<double> prices = new List<double>();
            prices.Add(600);
            prices.Add(375);
            prices.Add(1600);
            prices.Add(600);

            Assert.AreEqual(prices[0], model.Load()[2].Price);
            Assert.AreEqual(prices[1], model.Load()[1].Price);
            Assert.AreEqual(prices[2], model.Load()[0].Price);
            Assert.AreEqual(prices[2], model.Load()[0].Price);
            Assert.AreEqual(prices[3], model.Load()[2].Price);
        }

        // ТЕСТ 3: Товар не продавался в прошлом месяце -> скидка есть
        [TestMethod]
        public void UpdatePrices_NoOrdersLastMonth_DiscountApplied()
        {
            var mockRepository = new Mock<IOrderRepository>();
            mockRepository.Setup(repo => repo.Load()).Returns(new List<Order>());

            ProductsModel model = new ProductsModel(mockRepository.Object);

            double price1 = 1600.0; // Босоножки
            double price2 = 500.0;  // Туфли

            Assert.AreEqual(price1 * 0.75, model.Load()[0].Price);
            Assert.AreEqual(price2 * 0.75, model.Load()[1].Price);
        }
    }
}