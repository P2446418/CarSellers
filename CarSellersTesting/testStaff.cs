using System;
using CarSellersClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarSellersTesting
{
    [TestClass]
    public class testStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff aStaff = new clsStaff();
            Assert.IsNotNull(aStaff);
        }

        [TestMethod]
        public void ActiveStaffOK()
        {
            clsStaff aStaff = new clsStaff();
            Boolean TestData = true;
            aStaff.Active = TestData;
            Assert.AreEqual(aStaff.Active, TestData);
        }

        [TestMethod]
        public void DateAddedStaffOK()
        {
            clsStaff aStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            aStaff.DateAdded = TestData;
            Assert.AreEqual(aStaff.DateAdded, TestData);
        }

        [TestMethod]
        public void StaffFirstNameOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "Jeff";
            aStaff.FirstName = TestData;
            Assert.AreEqual(aStaff.FirstName, TestData);
        }

        [TestMethod]
        public void StaffSurnameOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "Bezos";
            aStaff.Surname = TestData;
            Assert.AreEqual(aStaff.Surname, TestData);
        }

        [TestMethod]
        public void StaffMobileNumberOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "07594273092";
            aStaff.MobileNumber = TestData;
            Assert.AreEqual(aStaff.MobileNumber, TestData);
        }
    }
}
