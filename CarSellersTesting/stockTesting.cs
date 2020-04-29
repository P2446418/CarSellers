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

            String numberPlate = "Num43";

            Found = AStock.Find(numberPlate);

            Assert.IsTrue(Found);


        }
        [TestMethod]
        public void TestNumberPlateFound()
        {
            clsStock AStock = new clsStock();

            Boolean Found = false;

            Boolean Ok = true;

            String numberPlate = "Num43";

            Found = AStock.Find(numberPlate);

            if(AStock.numberPlate != "Num43")
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

            String numberPlate = "Num43";

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

            String numberPlate = "Num43";

            Found = AStock.Find(numberPlate);

            if (AStock.numberPlate != "Num43")
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

            String numberPlate = "Num43";

            Found = AStock.Find(numberPlate);

            if (AStock.numberPlate != "Num43")
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

            String numberPlate = "Num43";

            Found = AStock.Find(numberPlate);

            if (AStock.numberPlate != "Num43")
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

            String numberPlate = "Num43";

            Found = AStock.Find(numberPlate);

            if (AStock.numberPlate != "Num43")
            {
                Ok = false;
            }


            Assert.IsTrue(Ok);


        }
    }
}
