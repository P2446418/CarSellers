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

        [TestMethod]
        public void AddMethodOK()
        {
            //create class instance
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create test data
            clsOrder TestItem = new clsOrder();
            // primary key variable
            Int32 PrimaryKey = 0;
            // set properties
            TestItem.orderID = 1;
            TestItem.numberPlate = "AB09ZXC";
            TestItem.customerID = 5;
            TestItem.price = 5000;
            TestItem.quantity = 1;
            TestItem.dateOrdered = DateTime.Now.Date;
            //set this order to the test data
            AllOrders.ThisOrder = TestItem;
            // add record
            PrimaryKey = AllOrders.Add(); 
            // set primary key of test data
            TestItem.orderID = PrimaryKey;
            // find record
            AllOrders.ThisOrder.Find(PrimaryKey);
            // test values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create class instance
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create test data
            clsOrder TestItem = new clsOrder();
            // primary key variable
            Int32 PrimaryKey = 0;
            // set properties
            TestItem.orderID = 1;
            TestItem.numberPlate = "AB09ZXC";
            TestItem.customerID = 5;
            TestItem.price = 5000;
            TestItem.quantity = 1;
            TestItem.dateOrdered = DateTime.Now.Date;
            //set this order to the test data
            AllOrders.ThisOrder = TestItem;
            // add record
            PrimaryKey = AllOrders.Add();
            // set primary key of test data
            TestItem.orderID = PrimaryKey;
            // find record
            AllOrders.ThisOrder.Find(PrimaryKey);
            // delete record
            AllOrders.Delete();
            // find the record again
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            // test that record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            // create instance of class to test
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create test data
            clsOrder TestItem = new clsOrder();
            // primary key var
            Int32 PrimaryKey = 0;
            // set properties for test data
            TestItem.numberPlate = "AB09ZXC";
            TestItem.customerID = 5;
            TestItem.price = 5000;
            TestItem.quantity = 1;
            TestItem.dateOrdered = DateTime.Now.Date;
            // set ThisAddress to the test data
            AllOrders.ThisOrder = TestItem;
            // add the record
            PrimaryKey = AllOrders.Add();
            // set primary key of test data
            TestItem.orderID = PrimaryKey;
            // modify test data
            TestItem.numberPlate = "AB08EXC";
            TestItem.customerID = 4;
            TestItem.price = 4000;
            TestItem.quantity = 1;
            TestItem.dateOrdered = DateTime.Now.Date;
            // set record based on new test data
            AllOrders.ThisOrder = TestItem;
            // update the record
            AllOrders.Update();
            // find record
            AllOrders.ThisOrder.Find(PrimaryKey);
            // test that ThisOrder matches the test data
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }

        [TestMethod]
        public void ReportByNumberPlateMethodOK()
        {
            // create instance of unfiltered class
            clsOrderCollection AllOrders = new clsOrderCollection();
            // create instance of filtered orders
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            // apply blank string (all records returned)
            FilteredOrders.ReportbyNumberPlate("");
            // test that values are the same
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByNumberPlateNoneFound()
        {
            // create instance of filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            // apply number plate that doesn't exist
            FilteredOrders.ReportbyNumberPlate("xxxxxxx");
            // test that there are no records
            Assert.AreEqual(0, FilteredOrders.Count);
        }


    }
}
