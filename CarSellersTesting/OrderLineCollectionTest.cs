using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarSellersClasses;
using System.Collections.Generic;

namespace CarSellersTesting
{
    [TestClass]
    public class OrderLineCollectionTest
    {
        [TestMethod]
        public void InstanceOk()
        {
            // create instance to test
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            // test that instance exists
            Assert.IsNotNull(AllOrderLines);
        }

        [TestMethod]
        public void OrderLineListOK()
        {
            // create class instance
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            // create test list of objects
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            // create test data
            clsOrderLine TestItem = new clsOrderLine();
            // set prooperties
            TestItem.orderLineID = 1;
            TestItem.orderID = 1;
            TestItem.staffID = 1;
            TestItem.orderComplete = true;
            // add item to test list
            TestList.Add(TestItem);
            // assign data to property
            AllOrderLine.OrderLineList = TestList;
            // test that the two values are equal
            Assert.AreEqual(AllOrderLine.OrderLineList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            // create class instance
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            // create test data
            clsOrderLine TestItem = new clsOrderLine();
            // set properties
            TestItem.orderLineID = 1;
            TestItem.orderID = 1;
            TestItem.staffID = 1;
            TestItem.orderComplete = true;
            // Assign data to property
            AllOrderLine.ThisOrderLine = TestItem;
            // test that the two values are equal
            Assert.AreEqual(AllOrderLine.ThisOrderLine, TestItem);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            //create instance of class
            clsOrderLineCollection AllOrderLine = new clsOrderLineCollection();
            // create test list
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            // create test data item
            clsOrderLine TestItem = new clsOrderLine();
            // set data properties
            TestItem.orderLineID = 1;
            TestItem.orderID = 1;
            TestItem.staffID = 1;
            TestItem.orderComplete = true;
            // add item to test list
            TestList.Add(TestItem);
            // assign data to property
            AllOrderLine.OrderLineList = TestList;
            // test that values are the same
            Assert.AreEqual(AllOrderLine.Count, TestList.Count);
        }
    }
}
