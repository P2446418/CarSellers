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

            if (AStock.productionDate != Convert.ToDateTime("29/02/2000"))
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

            Error = AStock.Valid(productionDate, mileage, price, sold, modelName);

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

        }
        [TestMethod]
        public void MileageMinPlusOne()
        {

        }
        [TestMethod]
        public void MileageMin()
        {

        }
        [TestMethod]
        public void MileageExtremeMin()
        {

        }
        [TestMethod]
        public void MileageExtremeMax()
        {

        }
        [TestMethod]
        public void MileageMaxLessOne()
        {

        }
        [TestMethod]
        public void MileageMaxPlusOne()
        {

        }
        [TestMethod]
        public void MileageMax()
        {

        }
        [TestMethod]
        public void MileageMid()
        {

        }
       

         [TestMethod]
        public void priceMinLessOne()
        {

        }
        [TestMethod]
        public void priceMinPlusOne()
        {

        }
        [TestMethod]
        public void priceMin()
        {

        }
        [TestMethod]
        public void priceExtremeMin()
        {

        }
        [TestMethod]
        public void priceExtremeMax()
        {

        }
        [TestMethod]
        public void priceMaxLessOne()
        {

        }
        [TestMethod]
        public void priceMaxPlusOne()
        {

        }
        [TestMethod]
        public void priceMax()
        {

        }
        [TestMethod]
        public void priceMid()
        {

        }

         [TestMethod]
        public void soldMinLessOne()
        {

        }
        [TestMethod]
        public void soldMinPlusOne()
        {

        }
        [TestMethod]
        public void soldMin()
        {

        }
        [TestMethod]
        public void soldExtremeMin()
        {

        }
        [TestMethod]
        public void soldExtremeMax()
        {

        }
        [TestMethod]
        public void soldMaxLessOne()
        {

        }
        [TestMethod]
        public void soldMaxPlusOne()
        {

        }
        [TestMethod]
        public void soldMax()
        {

        }
        [TestMethod]
        public void soldMid()
        {

        }

         [TestMethod]
        public void ModelNameMinLessOne()
        {

        }
        [TestMethod]
        public void ModelNameMinPlusOne()
        {

        }
        [TestMethod]
        public void ModelNameMin()
        {

        }
        [TestMethod]
        public void ModelNameExtremeMin()
        {

        }
        [TestMethod]
        public void ModelNameExtremeMax()
        {

        }
        [TestMethod]
        public void ModelNameMaxLessOne()
        {

        }
        [TestMethod]
        public void ModelNameMaxPlusOne()
        {

        }
        [TestMethod]
        public void ModelNameMax()
        {

        }
        [TestMethod]
        public void ModelNameMid()
        {

        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock AStock= new clsStock();
            String error = "";
            error = AStock.Valid(productionDate, mileage, price, sold,modelName);
            Assert.AreEqual(error, "");
        }
    }
}
