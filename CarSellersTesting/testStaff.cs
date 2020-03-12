using System;
using CarSellersClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarSellersTesting
{
    [TestClass]
    public class testStaff
    {
        [TestMethod]
        public void TestFirstNameFound()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            string FirstName = "Jeff";
            Found = aStaff.Find(FirstName);
            if (aStaff.FirstName != "Jeff")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void InstanceOK()
        {
            clsStaff aStaff = new clsStaff();
            Assert.IsNotNull(aStaff);
        }

        //[TestMethod]
        //public void DOBStaffOK()
        //{
           // clsStaff aStaff = new clsStaff();
           // DateTime TestData = DateTime(01,01,1980);
           // aStaff.DOB = TestData;
           // Assert.AreEqual(aStaff.DOB, TestData);
        //}

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

        [TestMethod]
        public void StaffPositionOK()
        {
            clsStaff aStaff = new clsStaff();
            string TestData = "Sales";
            aStaff.Position = TestData;
            Assert.AreEqual(aStaff.Position, TestData);
        }

        [TestMethod]
        public void InOfficeOK()
        {
            clsStaff aStaff = new clsStaff();
            Boolean TestData = true;
            aStaff.InOffice = TestData;
            Assert.AreEqual(aStaff.InOffice, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            string FirstName = "Jeff";
            Found = aStaff.Find(FirstName);
            Assert.IsTrue(Found);
        }

    }
}
