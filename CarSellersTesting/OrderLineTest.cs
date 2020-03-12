using System;
using CarSellersClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarSellersTesting
{
    [TestClass]
    public class OrderLineTest
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Assert.IsNotNull(AnOrderLine);
        }

        [TestMethod]
        public void OrderLineIDPropertyOK()
        {
            clsOrderLine new_order = new clsOrderLine();
            int TestData = 1;
            new_order.orderLineID = TestData;
            Assert.AreEqual(new_order.orderLineID, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrderLine new_order = new clsOrderLine();
            int TestData = 1;
            new_order.orderID = TestData;
            Assert.AreEqual(new_order.orderID, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            clsOrderLine new_order = new clsOrderLine();
            int TestData = 1;
            new_order.staffID = TestData;
            Assert.AreEqual(new_order.staffID, TestData);
        }

        [TestMethod]
        public void OrderCompletePropertyOK()
        {
            clsOrderLine new_order = new clsOrderLine();
            bool TestData = true;
            new_order.orderComplete = TestData;
            Assert.AreEqual(new_order.orderComplete, TestData);
        }
    }
}
