using System;
using System.CodeDom;
using System.Collections.Generic;
using CarSellersClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarSellersTesting
{

    [TestClass]
    public class stockCollectionTesting
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsStockCollection AllStock = new CarSellersClasses.clsStockCollection();

            Assert.IsNotNull(AllStock);
               
        }
        [TestMethod]
        public void stockListOk()
        {
            clsStockCollection allStock = new clsStockCollection();

            List<clsStock> testList = new List<clsStock>();

            clsStock testStock = new clsStock();

            testStock.numberPlate = "numPl4te";
            testStock.productionDate = DateTime.Now.Date;
            testStock.mileage = 20000;
            testStock.price = 5000;
            testStock.sold = false;
            testStock.modelName = "model";

            testList.Add(testStock);

            allStock.stockList = testList;

            Assert.AreEqual(allStock.stockList, testList);
        }

        [TestMethod]
        public void thisStockPropertyOk()
        {
            clsStockCollection allStock = new clsStockCollection();

            clsStock testStock = new clsStock();

            testStock.numberPlate = "numPl4te";
            testStock.productionDate = DateTime.Now.Date;
            testStock.mileage = 20000;
            testStock.price = 5000;
            testStock.sold = false;
            testStock.modelName = "model";

            allStock.thisStock = testStock;

            Assert.AreEqual(allStock.thisStock, testStock);
        }
        [TestMethod]
        public void listAndCountOk()
        {
            clsStockCollection allStock = new clsStockCollection();

            List<clsStock> testList = new List<clsStock>();

            clsStock testStock = new clsStock();

            testStock.numberPlate = "numPl4te";
            testStock.productionDate = DateTime.Now.Date;
            testStock.mileage = 20000;
            testStock.price = 5000;
            testStock.sold = false;
            testStock.modelName = "model";

            testList.Add(testStock);

            allStock.stockList = testList;

            Assert.AreEqual(allStock.Count, testList.Count);
        }

    }
}
