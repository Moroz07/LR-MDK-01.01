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

            mockRepository.Verify(repo => repo.Load(), Times.AtLeastOnce,
                "Модель должна была запросить заказы у репозитория");
        }

        // ТЕСТ 2: Товар продавался в прошлом месяце -> скидки нет
        [TestMethod]
        public void UpdatePrices_ProductSoldLastMonth_NoDiscount()
        {

            DateTime lastMonth = DateTime.Now.AddMonths(-1);
            var testOrders = new List<Order>
            {
                new Order
                {
                    Items = new List<OrderItem>
                    {
                        new OrderItem { ProductItem = "Кеды", Count = 1, SaleDate = lastMonth }
                    }
                }
            };

            var mockRepository = new Mock<IOrderRepository>();
            mockRepository.Setup(repo => repo.Load()).Returns(testOrders);

            ProductsModel model = new ProductsModel(mockRepository.Object);

            double initialPrice = model.Load()[2].Price;

            model.UpdatePrices(model.LoadOrders());

            Assert.AreEqual(initialPrice, model.Load()[2].Price,
                "Товар продавался в прошлом месяце, скидки быть не должно");
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

            model.UpdatePrices(model.LoadOrders());

            Assert.AreEqual(price1 * 0.75, model.Load()[0].Price, 0.01, "Скидка должна быть применена к Босоножкам");
            Assert.AreEqual(price2 * 0.75, model.Load()[1].Price, 0.01, "Скидка должна быть применена к Туфлям");
        }
    }
}