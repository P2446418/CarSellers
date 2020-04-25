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
            newCustomer.name = newName;
            Assert.AreEqual(newCustomer.name, newName);
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


    }

    [TestClass]
    public class CustomerValidationTesting
    {
        #region ValidationTests

        //test data
        String TName = "bob";
        String TSurname = "smith";
        String TDOB = "2020-04-25"; //DateTime.Now.ToString();
        String TNumber = "1234567890";
        String TEmail = "bob@example.com";
        String TAddress = "123 example lane";


        [TestMethod]
        public void ValidMethodOk()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            error = newCustomer.Valid(TName, TSurname, TDOB, TNumber, TEmail, TAddress);
            Assert.AreEqual(error, "");
        }

        #region TNameValidationTests

        [TestMethod]
        public void NameZeroLength()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            error = newCustomer.Valid("", TSurname, TDOB, TNumber, TEmail, TAddress);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameOneLength()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            error = newCustomer.Valid("a", TSurname, TDOB, TNumber, TEmail, TAddress);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameOneLessThanMaxLength()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            error = newCustomer.Valid("aaaaaaaaaaaaaaaaaaaaaaaa", TSurname, TDOB, TNumber, TEmail, TAddress);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameMaxLength()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            error = newCustomer.Valid("aaaaaaaaaaaaaaaaaaaaaaaaa", TSurname, TDOB, TNumber, TEmail, TAddress);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NameOneMoreThanMaxLength()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            error = newCustomer.Valid("aaaaaaaaaaaaaaaaaaaaaaaaaa", TSurname, TDOB, TNumber, TEmail, TAddress);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameExtremeLength()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            String ExtremeLengthName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            error = newCustomer.Valid(ExtremeLengthName, TSurname, TDOB, TNumber, TEmail, TAddress);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameNumbersCheck()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            error = newCustomer.Valid("0123456789", TSurname, TDOB, TNumber, TEmail, TAddress);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameInvalidSymbolsCheck()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            String NewName = "¬!£$%^&*()_+=}{[]@'~#:;?/><,.|";
            error = newCustomer.Valid(NewName, TSurname, TDOB, TNumber, TEmail, TAddress);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NameValidSymbolsCheck()
        {
            clsCustomer newCustomer = new clsCustomer();
            String error = "";
            String NewName = "abcdefghijklmnopYZ-'";
            error = newCustomer.Valid(NewName, TSurname, TDOB, TNumber, TEmail, TAddress);
            Assert.AreEqual(error, "");
        }

        #endregion

        #region DateValidationTests

        [TestMethod]
        public void DateTimeLettersCheck()
        {
            //test date time with letters in it
            clsCustomer newCustomer = new clsCustomer();
            String testDate = "a1/03/20";
            String error = newCustomer.ValidateDateTime(testDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateTimeSymbolsCheck()
        {
            //test date time with invalid symbols in it
            clsCustomer newCustomer = new clsCustomer();
            String testDate = "01/3$6/20";
            String error = newCustomer.ValidateDateTime(testDate);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void DateTimeValidCheck()
        {
            //test valid date time examples
            clsCustomer newCustomer = new clsCustomer();
            String error = newCustomer.ValidateDateTime(TDOB);
            Assert.AreEqual(error, "");
        }

        #endregion

        #region NumberValidationTests

        [TestMethod]
        public void NumberLettersCheck()
        {
            //test number with letters in it, spaces don't matter
            clsCustomer newCustomer = new clsCustomer();
            String testNumber = "0123a456789";
            String error = newCustomer.ValidateNumber(testNumber);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NumberSymbolsCheck()
        {
            //test number with symbols in it
            clsCustomer newCustomer = new clsCustomer();
            String testNumber = "012345678*90";
            String error = newCustomer.ValidateNumber(testNumber);
            Assert.AreNotEqual(error, "");
        }

        [TestMethod]
        public void NumberValidTest()
        {
            //test valid numbers
            clsCustomer newCustomer = new clsCustomer();
            String testNumber = "1234 5678";
            String error = newCustomer.ValidateNumber(testNumber);
            Assert.AreEqual(error, "");
        }

        [TestMethod]
        public void NumberLengthTest()
        {
            //test boundaries (WIP)
            //is phone number stored as int32 or int64, or string?
        }

        #endregion

        #region EmailValidationTests

        [TestMethod]
        public void EmailInvalidTests()
        {
            //examples of invalid emails
            clsCustomer newCustomer = new clsCustomer();
            String[] invalidEmails = new string[3] 
            {
                "bob@example",
                "@examples.com",
                "clearly not"
            };
            bool outcome = false;
            foreach (String email in invalidEmails)
            {
                outcome |= !(newCustomer.ValidateEmail(email) == "");
            }
            Assert.AreNotEqual(outcome, false);
        }

        [TestMethod]
        public void EmailValidTests()
        {
            //examples of valid emails
            clsCustomer newCustomer = new clsCustomer();
            String[] validEmails = new string[3]
            {
                "bob@example.com",
                "reallylongname@test.ac.uk",
                "gotanumberinthisname123@emailplace.co.uk"
            };
            bool outcome = false;
            foreach (String email in validEmails)
            {
                outcome |= !(newCustomer.ValidateEmail(email) == "");
            }
            Assert.AreEqual(outcome, false);
        }

        #endregion


        #endregion

    }

    [TestClass]
    public class CustomerCollectionTesting
    {
        [TestMethod]
        public void CollectionInstanceOk()
        {
            clsCustomer newCustomer = new clsCustomer();
            clsCustomerCollection collection = new clsCustomerCollection();
            collection.setCustomer(newCustomer);
            Assert.AreEqual(newCustomer, collection.getCustomer());
        }
    }
}
