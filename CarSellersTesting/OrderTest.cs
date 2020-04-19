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

        [TestMethod]
        public void InstanceOk()
        {
            clsOrder anOrder = new clsOrder();
            Assert.IsNotNull(anOrder);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrder new_order = new clsOrder();
            int TestData = 1;
            new_order.orderID = TestData;
            Assert.AreEqual(new_order.orderID, TestData);
        }

        [TestMethod]
        public void DateOrderedPropertyOK()
        {
            clsOrder new_order = new clsOrder();
            DateTime test_data = DateTime.Now.Date;
            new_order.dateOrdered = test_data;
            Assert.AreEqual(new_order.dateOrdered, test_data);

        }

        [TestMethod]
        public void NumberPlatePropertyOK()
        {
            clsOrder new_order = new clsOrder();
            String test_data = "YS12ASK";
            new_order.numberPlate = test_data;
            Assert.AreEqual(new_order.numberPlate, test_data);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsOrder new_order = new clsOrder();
            int test_data = 2;
            new_order.customerID = test_data;
            Assert.AreEqual(new_order.customerID, test_data);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            clsOrder new_order = new clsOrder();
            int test_data = 3;
            new_order.quantity = test_data;
            Assert.AreEqual(new_order.quantity, test_data);
        }

        [TestMethod]
        public void PricePropertyOK()
        {
            clsOrder new_order = new clsOrder();
            double test_data = 15000.00;
            new_order.price = test_data;
            Assert.AreEqual(new_order.price, test_data);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsOrder new_order = new clsOrder();
            Boolean Found = false;
            Int32 orderID = 1;
            Found = new_order.Find(orderID);
            Assert.IsTrue(Found);
        }

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

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";

            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }

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

        [TestMethod]
        public void dateOrderedInvalidData()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string DateOrdered = "This is not a date!";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void numberPlateMinLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string NumberPlate = "";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void numberPlateMin()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string NumberPlate = "F1";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void numberPlateMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string NumberPlate = "F1A";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void numberPlateMaxLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string NumberPlate = "F1ABCD";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void numberPlateMax()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string NumberPlate = "F1ABCDE";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void numberPlateMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string NumberPlate = "F1ABCDEF";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void customerIDMinLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerID = "0";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void customerIDMin()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerID = "1";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void customerIDMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerID = "12";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void customerIDMaxLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerID = "2147483646";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void customerIDMax()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerID = "2147483647";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void customerIDMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string CustomerID = "2147483648";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void quantityMinLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Quantity = "0";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void quantityMin()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Quantity = "1";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void quantityMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Quantity = "2";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void quantityMaxLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Quantity = "9";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void quantityMax()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Quantity = "10";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void quantityMaxPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Quantity = "11";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void quantityMid()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Quantity = "5";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Price = "0";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Price = "1";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Price = "2";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Price = "25000";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Price = "49999";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            clsOrder anOrder = new clsOrder();
            String Error = "";
            string Price = "50000";
            Error = anOrder.Valid(DateOrdered, NumberPlate, CustomerID, Quantity, Price);
            Assert.AreEqual(Error, "");
        }

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
