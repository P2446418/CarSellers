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


        [TestMethod]
        public void FindMethodOk()
        {
            clsOrderLine new_orderline = new clsOrderLine();
            Boolean Found = false;
            Int32 orderLineID = 1;
            Found = new_orderline.Find(orderLineID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderLineIDFound()
        {
            clsOrderLine new_orderline = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderLineID = 1;
            Found = new_orderline.Find(orderLineID);
            if(new_orderline.orderLineID !=  1)
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrderLine new_orderline = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderLineID = 1;
            Found = new_orderline.Find(orderLineID);
            if (new_orderline.orderID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            clsOrderLine new_orderline = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderLineID = 1;
            Found = new_orderline.Find(orderLineID);
            if (new_orderline.staffID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderCompleteFound()
        {
            clsOrderLine new_orderline = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 orderLineID = 1;
            Found = new_orderline.Find(orderLineID);
            if (new_orderline.orderComplete != true)
            {
                Found = false;
            }
            Assert.IsTrue(Found);
        }
    }
}
