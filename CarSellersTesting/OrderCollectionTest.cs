using System;
using CarSellersClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CarSellersTesting
{
    [TestClass]
    public class OrderCollectionTest
    {
        [TestMethod]
        public void InstanceOk()
        {
            // create instance to test
            clsOrderCollection AllOrders = new clsOrderCollection();
            // test that instance exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            // create class instance
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create test list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            // create test data
            clsOrder TestItem = new clsOrder();
            // set prooperties
            TestItem.orderID = 1;
            TestItem.numberPlate = "YS09UYM";
            TestItem.customerID = 1;
            TestItem.price = 5000;
            TestItem.quantity = 1;
            TestItem.dateOrdered = DateTime.Now.Date;
            // add item to test list
            TestList.Add(TestItem);
            // assign data to property
            AllOrders.OrderList = TestList;
            // test that the two values are equal
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            // create class instance
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create test data
            clsOrder TestOrder = new clsOrder();
            // set properties
            TestOrder.orderID = 1;
            TestOrder.numberPlate = "YS09UYM";
            TestOrder.customerID = 1;
            TestOrder.price = 5000;
            TestOrder.quantity = 1;
            TestOrder.dateOrdered = DateTime.Now.Date;
            // Assign data to property
            AllOrders.ThisOrder = TestOrder;
            // test that the two values are equal
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            //create instance of class
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create test list
            List<clsOrder> TestList = new List<clsOrder>();
            // create test data item
            clsOrder TestItem = new clsOrder();
            // set data properties
            TestItem.orderID = 1;
            TestItem.numberPlate = "YS09UYM";
            TestItem.customerID = 1;
            TestItem.price = 5000;
            TestItem.quantity = 1;
            TestItem.dateOrdered = DateTime.Now.Date;
            // add item to test list
            TestList.Add(TestItem);
            // assign data to property
            AllOrders.OrderList = TestList;
            // test that values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
    }
}
