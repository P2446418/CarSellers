using System;
using CarSellersClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarSellersTesting
{
    [TestClass]
    public class OrderLineTest
    {
        // global test variables
        string OrderID = "1";
        string StaffID = "1";

        [TestMethod]
        public void InstanceOk()
        {
            // check that instance is ok
            clsOrderLine AnOrderLine = new clsOrderLine();
            Assert.IsNotNull(AnOrderLine);
        }

        [TestMethod]
        public void OrderLineIDPropertyOK()
        {
            // test orderlineID property
            clsOrderLine new_order = new clsOrderLine();
            int TestData = 1;
            new_order.orderLineID = TestData;
            Assert.AreEqual(new_order.orderLineID, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            // test OrderID property
            clsOrderLine new_order = new clsOrderLine();
            int TestData = 1;
            new_order.orderID = TestData;
            Assert.AreEqual(new_order.orderID, TestData);
        }

        [TestMethod]
        public void StaffIDPropertyOK()
        {
            // test staff ID property
            clsOrderLine new_order = new clsOrderLine();
            int TestData = 1;
            new_order.staffID = TestData;
            Assert.AreEqual(new_order.staffID, TestData);
        }
        // test order complete property
        [TestMethod]
        public void OrderCompletePropertyOK()
        {
            clsOrderLine new_order = new clsOrderLine();
            bool TestData = true;
            new_order.orderComplete = TestData;
            Assert.AreEqual(new_order.orderComplete, TestData);
        }

        // test find method
        [TestMethod]
        public void FindMethodOk()
        {
            clsOrderLine new_orderline = new clsOrderLine();
            Boolean Found = false;
            Int32 orderLineID = 1;
            Found = new_orderline.Find(orderLineID);
            Assert.IsTrue(Found);
        }
        // test order line id found
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
        // test OrderID found
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
        // test staff ID found
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
        // test order complete found
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
        // test valid method works
        [TestMethod]
        public void ValidMethodOk()
        {
            clsOrderLine new_orderline = new clsOrderLine();
            string Error = "";

            Error = new_orderline.Valid(OrderID, StaffID);

            Assert.AreEqual(Error, "");
        }
        // test one less than minimum acceptable value
        [TestMethod]
        public void OrderIDMinLessOne()
        {
            clsOrderLine new_orderline = new clsOrderLine();
            string Error = "";
            string OrderID = "0";
            Error = new_orderline.Valid(OrderID, StaffID);

            Assert.AreNotEqual(Error, "");
        }
        // test min value
        [TestMethod]
        public void OrderIDMin()
        {
            clsOrderLine new_orderline = new clsOrderLine();
            string Error = "";
            string OrderID = "1";
            Error = new_orderline.Valid(OrderID, StaffID);

            Assert.AreEqual(Error, "");
        }
        // test max value less one
        [TestMethod]
        public void OrderIDMaxLessOne()
        {
            clsOrderLine new_orderline = new clsOrderLine();
            string Error = "";
            int OrderIDTemp = int.MaxValue - 1;
            string OrderID = OrderIDTemp.ToString();
            Error = new_orderline.Valid(OrderID, StaffID);

            Assert.AreEqual(Error, "");
        }
        // test max value
        [TestMethod]
        public void OrderIDMax()
        {
            clsOrderLine new_orderline = new clsOrderLine();
            string Error = "";
            int OrderIDTemp = int.MaxValue;
            string OrderID = OrderIDTemp.ToString();
            Error = new_orderline.Valid(OrderID, StaffID);

            Assert.AreEqual(Error, "");
        }
        // test max plus one
        [TestMethod]
        public void OrderIDMaxPlusOne()
        {
            clsOrderLine new_orderline = new clsOrderLine();
            string Error = "";
            string OrderID = int.MaxValue + 1.ToString();
            Error = new_orderline.Valid(OrderID, StaffID);

            Assert.AreNotEqual(Error, "");
        }
        // test min less one
        [TestMethod]
        public void StaffIDMinLessOne()
        {
            clsOrderLine new_orderline = new clsOrderLine();
            string Error = "";
            string StaffID = "0";
            Error = new_orderline.Valid(OrderID, StaffID);

            Assert.AreNotEqual(Error, "");
        }
        // test min staff id value
        [TestMethod]
        public void StaffIDMin()
        {
            clsOrderLine new_orderline = new clsOrderLine();
            string Error = "";
            string StaffID = "1";
            Error = new_orderline.Valid(OrderID, StaffID);

            Assert.AreEqual(Error, "");
        }
        // test staff id max less one
        [TestMethod]
        public void StaffIDMaxLessOne()
        {
            clsOrderLine new_orderline = new clsOrderLine();
            string Error = "";
            string StaffID = "99";
            Error = new_orderline.Valid(OrderID, StaffID);

            Assert.AreEqual(Error, "");
        }
        // test max staff id value
        [TestMethod]
        public void StaffIDMax()
        {
            clsOrderLine new_orderline = new clsOrderLine();
            string Error = "";
            string StaffID = "100";
            Error = new_orderline.Valid(OrderID, StaffID);

            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffIDMaxPlusOne()
        {
            clsOrderLine new_orderline = new clsOrderLine();
            string Error = "";
            string StaffID = "101";
            Error = new_orderline.Valid(OrderID, StaffID);

            Assert.AreNotEqual(Error, "");
        }
    }
}
