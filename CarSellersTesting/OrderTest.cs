using System;
using CarSellersClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarSellersTesting
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void InstanceOK() { 
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
    }
}
