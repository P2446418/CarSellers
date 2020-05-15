using System;
using System.CodeDom;
using CarSellersClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarSellersTesting
{


    [TestClass]
    public class StockTesting
    {

        string productionDate = DateTime.Now.Date.ToString();
        string sold = "true";
        string modelName = "Wrexler";
        string price = "60000";
        string mileage = "5000";

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
        public void ProdutionDatePropertyOk()
        {
            clsStock stock = new clsStock();
            DateTime testData = DateTime.Now.Date;
            stock.productionDate = testData;
            Assert.AreEqual(stock.productionDate, testData);
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

        [TestMethod]
        public void FindMethodOk()
        {
            clsStock AStock = new clsStock();

            Boolean Found = false;

            String numberPlate = "JS47";

            Found = AStock.Find(numberPlate);

            Assert.IsTrue(Found);


        }
        [TestMethod]
        public void TestNumberPlateFound()
        {
            clsStock AStock = new clsStock();

            Boolean Found = false;

            Boolean Ok = true;

            String numberPlate = "JS47";

            Found = AStock.Find(numberPlate);

            if(AStock.numberPlate != "JS47")
            {
                Ok = false;
            }


            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestProductionDateFound()
        {
            clsStock AStock = new clsStock();

            Boolean Found = false;

            Boolean Ok = true;

            String numberPlate = "JS47";

            Found = AStock.Find(numberPlate);

            if (AStock.productionDate != Convert.ToDateTime("29/05/2000"))
            {
                Ok = false;
            }


            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestMileageFound()
        {
            clsStock AStock = new clsStock();

            Boolean Found = false;

            Boolean Ok = true;

            String numberPlate = "JS47";

            Found = AStock.Find(numberPlate);

            if (AStock.mileage != 41000)
            {
                Ok = false;
            }


            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestPriceFound()
        {
            clsStock AStock = new clsStock();

            Boolean Found = false;

            Boolean Ok = true;

            String numberPlate = "JS47";

            Found = AStock.Find(numberPlate);

            if (AStock.price != 50000)
            {
                Ok = false;
            }


            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestSoldFound()
        {
            clsStock AStock = new clsStock();

            Boolean Found = false;

            Boolean Ok = true;

            String numberPlate = "JS47";

            Found = AStock.Find(numberPlate);

            if (AStock.sold != true)
            {
                Ok = false;
            }


            Assert.IsTrue(Ok);


        }
        [TestMethod]
        public void TestModelNameFound()
        {
            clsStock AStock = new clsStock();

            Boolean Found = false;

            Boolean Ok = true;

            String numberPlate = "JS47";

            Found = AStock.Find(numberPlate);

            if (AStock.modelName != "Wrexler 5")
            {
                Ok = false;
            }


            Assert.IsTrue(Ok);


        }
        [TestMethod]

        public void ProductionDateMaxPlusOne()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(1);

            string productionDate = TestDate.ToString();

            Error = AStock.Valid( productionDate, mileage, price, sold, modelName);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void ProductionDateExtremeMin()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-100);

            string productionDate = TestDate.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductionDateMinLessOne()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-31);

            string productionDate = TestDate.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void ProductionDateExtremeMax()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(100);

            string productionDate = TestDate.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductionDateMin()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-30);

            string productionDate = TestDate.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ProductionDateMinPlusOne()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-29);

            string productionDate = TestDate.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductionDateMaxLessOne()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-1);

            string productionDate = TestDate.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductionDateMax()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            string productionDate = TestDate.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductionDateMid()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-15);

            string productionDate = TestDate.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void MileageMinLessOne()
        {

            clsStock AStock = new clsStock();

            String Error = "";

            int testMileage = -1;

            string mileage = testMileage.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void MileageMinPlusOne()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            int testMileage = 1;

            string mileage = testMileage.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MileageMin()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            int testMileage = 0;

            string mileage = testMileage.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MileageExtremeMin()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            int testMileage = -100;

            string mileage = testMileage.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void MileageExtremeMax()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            int testMileage = 2000000;

            string mileage = testMileage.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void MileageMaxLessOne()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            int testMileage = 199000;

            string mileage = testMileage.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MileageMaxPlusOne()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            int testMileage = 200001;

            string mileage = testMileage.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void MileageMax()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            int testMileage = 200000;

            string mileage = testMileage.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MileageMid()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            int testMileage = 100000;

            string mileage = testMileage.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }
       

         [TestMethod]
        public void priceMinLessOne()
        {

            clsStock AStock = new clsStock();

            String Error = "";

            int testPrice = 499;

            string price = testPrice.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void priceMinPlusOne()
        {

            clsStock AStock = new clsStock();

            String Error = "";

            int testPrice = 501;

            string price = testPrice.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void priceMin()
        {

            clsStock AStock = new clsStock();

            String Error = "";

            int testPrice = 500;

            string price = testPrice.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void priceExtremeMin()
        {

            clsStock AStock = new clsStock();

            String Error = "";

            int testPrice = -10000;

            string price = testPrice.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void priceExtremeMax()
        {

            clsStock AStock = new clsStock();

            String Error = "";

            int testPrice = 1000000;

            string price = testPrice.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void priceMaxLessOne()
        {

            clsStock AStock = new clsStock();

            String Error = "";

            int testPrice = 99999;

            string price = testPrice.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void priceMaxPlusOne()
        {

            clsStock AStock = new clsStock();

            String Error = "";

            int testPrice = 100001;

            string price = testPrice.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void priceMax()
        {

            clsStock AStock = new clsStock();

            String Error = "";

            int testPrice = 100000;

            string price = testPrice.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void priceMid()
        {

            clsStock AStock = new clsStock();

            String Error = "";

            int testPrice = 50000;

            string price = testPrice.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }

         [TestMethod]
        public void soldMin()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            bool testSold = false;

            string sold = testSold.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void soldMax()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            bool testSold = true;

            string sold = testSold.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }

         [TestMethod]
        public void ModelNameMinLessOne()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            string testModelName = "";

            string modelName = testModelName.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ModelNameMinPlusOne()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            string testModelName = "aa";

            string modelName = testModelName.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ModelNameMin()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            string testModelName = "a";

            string modelName = testModelName.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }
  
        [TestMethod]
        public void ModelNameMaxLessOne()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            string testModelName = "nineteencharacterss";

            string modelName = testModelName.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ModelNameMaxPlusOne()
        {
            clsStock AStock = new clsStock();

            String Error = "twentyonecharactersss";

            string testModelName = "";

            string modelName = testModelName.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ModelNameMax()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            string testModelName = "twentycharacterssss";

            string modelName = testModelName.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ModelNameMid()
        {
            clsStock AStock = new clsStock();

            String Error = "";

            string testModelName = "tencharact";

            string modelName = testModelName.ToString();

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock AStock= new clsStock();
            String error = "";
            error = AStock.Valid(productionDate, mileage, price, sold,modelName);
            Assert.AreEqual(error, "");
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

    }
}
