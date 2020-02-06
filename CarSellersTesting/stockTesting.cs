using System;
using CarSellersClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarSellersTesting
{

    [TestClass]
    public class testing
    {
        [TestMethod]
        public void instanceOk()
        {
            clsStock stock = new clsStock();
            Assert.IsNotNull(stock);
        }

        [TestMethod]
        public void activePropertyOk()
        {
            clsStock stock = new clsStock();
            String testData = "REG54";
            stock.numberPlate = testData;
            Assert.AreEqual(stock.numberPlate, testData);
        }
    }
}
