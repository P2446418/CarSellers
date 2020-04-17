using System;
using CarSellersClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarSellersTesting
{
    [TestClass]
    public class OrderTest
    {
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
    }
}
