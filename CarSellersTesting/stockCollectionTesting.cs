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
        [TestMethod]
        public void deleteMethodOk()
        {
            clsStockCollection allStock = new clsStockCollection();

            clsStock testStock = new clsStock();

            string primaryKey = "";

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            testStock.numberPlate = finalString;
            testStock.productionDate = DateTime.Now.Date;
            testStock.mileage = 20000;
            testStock.price = 5000;
            testStock.sold = false;
            testStock.modelName = "model";

            allStock.thisStock = testStock;

            primaryKey = allStock.Add().ToString();

            testStock.numberPlate = primaryKey;

            allStock.thisStock.Find(primaryKey);

            allStock.Delete();

            Boolean Found = allStock.thisStock.Find(primaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            clsStockCollection allStock = new clsStockCollection();

            clsStock testStock = new clsStock();

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            string primaryKey = "";


            testStock.numberPlate = finalString;
            testStock.productionDate = DateTime.Now.Date;
            testStock.mileage = 20000;
            testStock.price = 5000;
            testStock.sold = false;
            testStock.modelName = "model";

            allStock.thisStock = testStock;

            primaryKey = allStock.Add().ToString();

            testStock.numberPlate = primaryKey;

            allStock.thisStock.Find(primaryKey);

            Assert.AreEqual(allStock.thisStock, testStock);
        }
        [TestMethod]
        public void updateMethodOk()
        {
            clsStockCollection allStock = new clsStockCollection();

            clsStock testStock = new clsStock();

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            string primaryKey = "";


            testStock.numberPlate = finalString;
            testStock.productionDate = DateTime.Now.Date;
            testStock.mileage = 20000;
            testStock.price = 5000;
            testStock.sold = false;
            testStock.modelName = "model";

            allStock.thisStock = testStock;

            primaryKey = allStock.Add().ToString();

            testStock.numberPlate = primaryKey;

            allStock.thisStock.Find(primaryKey);

            testStock.productionDate = DateTime.Now.Date;
            testStock.mileage = 21000;
            testStock.price = 6000;
            testStock.sold = false;
            testStock.modelName = "modelNew";

            allStock.thisStock = testStock;
            allStock.Update();

            allStock.thisStock.Find(primaryKey);



            Assert.AreEqual(allStock.thisStock, testStock);



        }
    }
}
