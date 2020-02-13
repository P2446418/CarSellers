using System;
using CarSellersClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarSellersTesting
{

    [TestClass]
    public class StockTesting
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsStock stock = new clsStock();
            Assert.IsNotNull(stock);
        }

        [TestMethod]
        public void NumberPlatePropertyOk()
        {
            clsStock stock = new clsStock();
            string testData = "REG54";
            stock.numberPlate = testData;
            Assert.AreEqual(stock.numberPlate, testData);
        }

        [TestMethod]
        public void ProdutionYearPropertyOk()
        {
            clsStock stock = new clsStock();
            DateTime testData = DateTime.Now.Date;
            stock.productionYear = testData;
            Assert.AreEqual(stock.productionYear, testData);
        }

        [TestMethod]
        public void MileagePropertyOk()
        {
            clsStock stock = new clsStock();
            int testData = 50000;
            stock.mileage = testData;
            Assert.AreEqual(stock.mileage, testData);
        }

        [TestMethod]
        public void PricePropertyOk()
        {
            clsStock stock = new clsStock();
            double testData = 5522.99;
            stock.price = testData;
            Assert.AreEqual(stock.price, testData);
        }

        [TestMethod]
        public void SoldPropertyOk()
        {
            clsStock stock = new clsStock();
            bool testData = true;
            stock.sold = testData;
            Assert.AreEqual(stock.sold, testData);
        }

        [TestMethod]
        public void ModelNamePropertyOk()
        {
            clsStock stock = new clsStock();
            string testData = "x 5";
            stock.modelName = testData;
            Assert.AreEqual(stock.modelName, testData);
        }

    }
}
