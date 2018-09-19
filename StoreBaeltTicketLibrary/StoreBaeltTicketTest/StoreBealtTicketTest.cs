using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using TicketLibrary;

namespace StoreBaeltTicketTest
{
    [TestClass]
    public class StoreBealtTicketTest
    {
        [TestMethod]
        public void WeekendSaleTest()
        {
            //Arrange
            var car = new StoreBaeltTicketLibrary.StoreBaeltTicketLibrary();

            //Act
            double price = 192;
            car.Date = DateTime.Today.AddDays(3);

            //Assert
            Assert.AreEqual(price,car.Price());

        }

        [TestMethod]
        public void FullPriceTest()
        {
            //Arrange
            var car = new StoreBaeltTicketLibrary.StoreBaeltTicketLibrary();

            //Act
            double price = 240;
            car.Date = DateTime.Today;

            //Assert
            Assert.AreEqual(price, car.Price());

        }

        [TestMethod]
        public void WeekendSaleDiscountTest()
        {
            //Arrange
            var car = new StoreBaeltTicketLibrary.StoreBaeltTicketLibrary();

            //Act
            double price = 192*0.95; //182.4 is not close enough
            car.Date = DateTime.Today.AddDays(3);

            //Assert
            Assert.AreEqual(price, car.DiscountPrice());

        }
    }
}
