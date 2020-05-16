using System;
using CarSellersClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarSellersTesting
{
    [TestClass]
    public class OrderTest
    {
        // good data for test
        string DateOrdered = DateTime.Now.Date.ToString();
        string NumberPlate = "YS09UYM";
        string CustomerID = "1";
        string Quantity = "1";
        string Price = "1";

        // test clsOrder instance works
        [TestMethod]
        public void InstanceOk()
        {
            clsOrder anOrder = new clsOrder();
            Assert.IsNotNull(anOrder);
        }
        // test order id property works
        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrder new_order = new clsOrder();
            int TestData = 1;
            new_order.orderID = TestData;
            Assert.AreEqual(new_order.orderID, TestData);
        }
        // test date ordered prop works
        [TestMethod]
        public void DateOrderedPropertyOK()
        {
            clsOrder new_order = new clsOrder();
            DateTime test_data = DateTime.Now.Date;
            new_order.dateOrdered = test_data;
            Assert.AreEqual(new_order.dateOrdered, test_data);

        }
        // test number plate works
        [TestMethod]
        public void NumberPlatePropertyOK()
        {
            clsOrder new_order = new clsOrder();
            String test_data = "YS12ASK";
            new_order.numberPlate = test_data;
            Assert.AreEqual(new_order.numberPlate, test_data);
        }
        // test customer id works
        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsOrder new_order = new clsOrder();
            int test_data = 2;
            new_order.customerID = test_data;
            Assert.AreEqual(new_order.customerID, test_data);
        }
        //test quantity property works
        [TestMethod]
        public void QuantityPropertyOK()
        {
            clsOrder new_order = new clsOrder();
            int test_data = 3;
            new_order.quantity = test_data;
            Assert.AreEqual(new_order.quantity, test_data);
        }
        // test price works
        [TestMethod]
        public void PricePropertyOK()
        {
            clsOrder new_order = new clsOrder();
            double test_data = 15000.00;
            new_order.price = test_data;
            Assert.AreEqual(new_order.price, test_data);
        }
        // test find method works
        [TestMethod]
        public void FindMethodOk()
        {
            clsOrder new_order = new clsOrder();
            Boolean Found = false;
            Int32 orderID = 1;
            Found = new_order.Find(orderID);
            Assert.IsTrue(Found);
        }
        // test order id found
        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.orderID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        // test order date found
        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.dateOrdered != Convert.ToDateTime("06/02/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        // test number plate found
        [TestMethod]
        public void TestNumberPlateFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.numberPlate !=  "YS09UYM")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        // test customer id found
        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.customerID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        // test quantity found
        [TestMethod]
        public void TestQuantityFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.quantity != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        // test price found
        [TestMethod]
        public void TestPriceFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.price != 5000)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        // test valid method works
        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test extreme min date ordered
        [TestMethod]
        public void dateOrderedExtremeMin()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateOrdered = TestDate.ToString();
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        // test dateordered low min
        [TestMethod]
        public void dateOrderedMinLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateOrdered = TestDate.ToString();
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        // test min date ordered
        [TestMethod]
        public void dateOrderedMin()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateOrdered = TestDate.ToString();
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test date ordered min plus one
        [TestMethod]
        public void dateOrderedMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateOrdered = TestDate.ToString();
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        // test date ordered max extreme
        [TestMethod]
        public void dateOrderedExtremeMax()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateOrdered = TestDate.ToString();
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        // test invalid date
        [TestMethod]
        public void dateOrderedInvalidData()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string DateOrdered = "This is not a date!";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        // test low out of bounds number plate
        [TestMethod]
        public void numberPlateMinLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string NumberPlate = "";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        // test min number plate
        [TestMethod]
        public void numberPlateMin()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string NumberPlate = "F1";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test low number plate val
        [TestMethod]
        public void numberPlateMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string NumberPlate = "F1A";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test number plate upper bound
        [TestMethod]
        public void numberPlateMaxLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string NumberPlate = "F1ABCD";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test max number plate
        [TestMethod]
        public void numberPlateMax()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string NumberPlate = "F1ABCDE";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test upper out of bounds number plate
        [TestMethod]
        public void numberPlateMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string NumberPlate = "F1ABCDEF";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        // test customer id out of bounds low
        [TestMethod]
        public void customerIDMinLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerID = "0";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        // minimum customer id test
        [TestMethod]
        public void customerIDMin()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerID = "1";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test low range customer id
        [TestMethod]
        public void customerIDMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerID = "12";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test high range customer id
        [TestMethod]
        public void customerIDMaxLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerID = "2147483646";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test max customer id
        [TestMethod]
        public void customerIDMax()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerID = "2147483647";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test out of bounds - high customer id
        [TestMethod]
        public void customerIDMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerID = "2147483648";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        // test out of bounds quantity
        [TestMethod]
        public void quantityMinLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Quantity = "0";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        // test min quantity
        [TestMethod]
        public void quantityMin()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Quantity = "1";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test low quantity
        [TestMethod]
        public void quantityMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Quantity = "2";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test high quantity
        [TestMethod]
        public void quantityMaxLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Quantity = "9";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test max quantity
        [TestMethod]
        public void quantityMax()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Quantity = "10";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test high out of bounds quantity
        [TestMethod]
        public void quantityMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Quantity = "11";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        // test mid range quantity
        [TestMethod]
        public void quantityMid()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Quantity = "5";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test low out of bounds price
        [TestMethod]
        public void PriceMinLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Price = "0";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }
        // test min price
        [TestMethod]
        public void PriceMin()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Price = "1";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test low price
        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Price = "2";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test mid range price
        [TestMethod]
        public void PriceMid()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Price = "25000";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test high range price
        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Price = "49999";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test max price
        [TestMethod]
        public void PriceMax()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Price = "50000";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }
        // test high out of bounds price
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Price = "50001";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }


    }
}
