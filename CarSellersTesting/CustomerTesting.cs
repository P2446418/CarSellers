using System;
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
            Int32 CustomerNo = 7;
            found = newCustomer.Find(CustomerNo);
            Assert.IsTrue(found);
        }



        #endregion

        #region ValidationTests

        //test data
        String TName = "bob";
        String TSurname = "smith";
        String TDOB = "19/03/20";
        String TNumber = "1234567890";
        String TEmail = "bob@example.com";
        

        [TestMethod]
        public void ValidMethodOk()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            error = newCustomer.Valid(TName, TSurname, TDOB, TNumber, TEmail);
            Assert.AreEqual(error, "");
        }

        #region TNameValidationTests

        [TestMethod]
        public void NameZeroLength()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            error = newCustomer.Valid("", TSurname, TDOB, TNumber, TEmail);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameOneLength()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            error = newCustomer.Valid("a", TSurname, TDOB, TNumber, TEmail);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameOneLessThanMaxLength()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            error = newCustomer.Valid("aaaaaaaaaaaaaaaaaaaaaaaa", TSurname, TDOB, TNumber, TEmail);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameMaxLength()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            error = newCustomer.Valid("aaaaaaaaaaaaaaaaaaaaaaaaa", TSurname, TDOB, TNumber, TEmail);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameOneMoreThanMaxLength()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            error = newCustomer.Valid("aaaaaaaaaaaaaaaaaaaaaaaaaa", TSurname, TDOB, TNumber, TEmail);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameExtremeLength()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            String ExtremeLengthName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            error = newCustomer.Valid(ExtremeLengthName, TSurname, TDOB, TNumber, TEmail);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameNumbersCheck()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            error = newCustomer.Valid("0123456789", TSurname, TDOB, TNumber, TEmail);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameInvalidSymbolsCheck()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            String NewName = "¬!£$%^&*()_+=}{[]@'~#:;?/><,.|";
            error = newCustomer.Valid(NewName, TSurname, TDOB, TNumber, TEmail);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameValidSymbolsCheck()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            String NewName = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-'";
            error = newCustomer.Valid(NewName, TSurname, TDOB, TNumber, TEmail);
            Assert.AreEqual(error, "");
        }

        #endregion

        #endregion


    }
}
