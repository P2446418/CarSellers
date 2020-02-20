﻿using System;
using CarSellersClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarSellersTesting
{
    [TestClass]
    public class CustomerTesting
    {

        #region InstanceTests
        [TestMethod]
        public void InstanceOk()
        {
            clsCustomer newCustomer = new clsCustomer();
            Assert.IsNotNull(newCustomer);
        }
        #endregion

        #region PropertyOkTests

        [TestMethod]
        public void NamePropertyOK()
        {
            clsCustomer newCustomer = new clsCustomer();
            String newName = "bob";
            newCustomer.setName(newName);
            Assert.AreEqual(newCustomer.getName(), newName);
        }

        [TestMethod]
        public void SurnamePropertyOk()
        {
            clsCustomer newCustomer = new clsCustomer();
            String surname = "smith";
            newCustomer.surname = surname;
            Assert.AreEqual(newCustomer.surname, surname);
        }

        [TestMethod]
        public void DOBPropertyOk()
        {
            clsCustomer newCustomer = new clsCustomer();
            DateTime current = DateTime.Now;
            newCustomer.DOB = current;
            Assert.AreEqual(newCustomer.DOB, current);
        }

        [TestMethod]
        public void EmailPropertyOk()
        {
            clsCustomer newCustomer = new clsCustomer();
            string email = "bobsmith@example.com";
            newCustomer.email = email;
            Assert.AreEqual(newCustomer.email, email);
        }

        [TestMethod]
        public void AddressPropertyOk()
        {
            clsCustomer newCustomer = new clsCustomer();
            string address = "123 example street";
            newCustomer.Address = address;
            Assert.AreEqual(newCustomer.Address, address);
        }

        [TestMethod]
        public void DeletePropertyOk()
        {
            clsCustomer newCustomer = new clsCustomer();
            Boolean delete = false;
            newCustomer.toDelete = delete;
            Assert.AreEqual(newCustomer.toDelete, delete);
        }

        #endregion

        #region FindMethodTests

        [TestMethod]
        public void FindMethodOk()
        {
            clsCustomer newCustomer = new clsCustomer();
            Boolean found = false;
            Int32 CustomerNo = 1;
            found = newCustomer.Find(CustomerNo);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestAddressNoFound()
        {
            clsCustomer newCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1;
            found = newCustomer.Find(CustomerNo);
            if (newCustomer.CustomerID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsCustomer newCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1;
            found = newCustomer.Find(CustomerNo);
            if (newCustomer.DOB != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        #endregion

    }
}
