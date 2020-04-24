using System;
using CarSellersClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CarSellersTesting
{
    [TestClass]
    public class testStaff
    {
        //[TestMethod]
        //public void TestFirstNameFound()
        //{
        //    clsStaff aStaff = new clsStaff();
        //    Boolean Found = false;
        //    Boolean OK = true;
        //    string FirstName = "Jeff";
        //    Found = aStaff.Find(FirstName);
        //    if (aStaff.FirstName != "Jeff")
        //    {
        //        OK = false;
        //    }
        //    Assert.IsTrue(OK);
        //}

        #region InstanceTests
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff aStaff = new clsStaff();
            Assert.IsNotNull(aStaff);
        }
        #endregion

        #region FieldTests
        [TestMethod]
        public void DOBStaffOK()
        {
            clsStaff aStaff = new clsStaff();
            DateTime Current = DateTime.Now;
            aStaff.DOB = Current;
            Assert.AreEqual(aStaff.DOB, Current);
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
            Int64 TestData = 07594273092;
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
        public void DeleteStaffOk()
        {
            clsStaff aStaff = new clsStaff();
            Boolean delete = false;
            aStaff.toDelete = delete;
            Assert.AreEqual(aStaff.toDelete, delete);
        }
        #endregion

        #region FindTests
        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff aStaff = new clsStaff();
            Boolean Found = false;
            int StaffNo = 0;
            Found = aStaff.Find(StaffNo);
            Assert.IsTrue(Found);
        }
        #endregion

        [TestClass]
        public class StaffValidationTesting
        {
            #region ValidationTests

            //test data
            String TFirstName = "John";
            String TSurname = "Smith";
            String TDOB = DateTime.Now.ToString();
            String TMobileNumber = "1234567890";
            String TPosition = "Sales";
            bool TInOffice = true;


            [TestMethod]
            public void ValidMethodOk()
            {
                clsStaff aStaff = new clsStaff();
                String error = "";
                error = aStaff.Valid(TFirstName, TSurname, TDOB, TMobileNumber, TPosition, TInOffice);
                Assert.AreEqual(error, "");
            }

            #region TFirstNameValidationTests

            [TestMethod]
            public void FirstNameZeroLength()
            {
                clsStaff aStaff = new clsStaff();
                String error = "";
                error = aStaff.Valid("", TSurname, TDOB, TMobileNumber, TPosition, TInOffice);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void FirstNameOneLength()
            {
                clsStaff aStaff = new clsStaff();
                String error = "";
                error = aStaff.Valid("a", TSurname, TDOB, TMobileNumber, TPosition, TInOffice);
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void FirstNameOneLessThanMaxLength()
            {
                clsStaff aStaff = new clsStaff();
                String error = "";
                error = aStaff.Valid("aaaaaaaaaaaaaaaaaaaaaaaa", TSurname, TDOB, TMobileNumber, TPosition, TInOffice);
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void FirstNameMaxLength()
            {
                clsStaff aStaff = new clsStaff();
                String error = "";
                error = aStaff.Valid("aaaaaaaaaaaaaaaaaaaaaaaaa", TSurname, TDOB, TMobileNumber, TPosition, TInOffice);
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void FirstNameOneMoreThanMaxLength()
            {
                clsStaff aStaff = new clsStaff();
                String error = "";
                error = aStaff.Valid("aaaaaaaaaaaaaaaaaaaaaaaaaa", TSurname, TDOB, TMobileNumber, TPosition, TInOffice);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void FirstNameExtremeLength()
            {
                clsStaff aStaff = new clsStaff();
                String error = "";
                String ExtremeLengthName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                error = aStaff.Valid(ExtremeLengthName, TSurname, TDOB, TMobileNumber, TPosition, TInOffice);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void FirstNameNumbersCheck()
            {
                clsStaff aStaff = new clsStaff();
                String error = "";
                error = aStaff.Valid("0123456789", TSurname, TDOB, TMobileNumber, TPosition, TInOffice);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void FirstNameInvalidSymbolsCheck()
            {
                clsStaff aStaff = new clsStaff();
                String error = "";
                String NewFirstName = "¬!£$%^&*()_+=}{[]@'~#:;?/><,.|";
                error = aStaff.Valid(NewFirstName, TSurname, TDOB, TMobileNumber, TPosition, TInOffice);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void FirstNameValidSymbolsCheck()
            {
                clsStaff aStaff = new clsStaff();
                String error = "";
                String NewFirstName = "abcdefghijklmnopYZ-'";
                error = aStaff.Valid(NewFirstName, TSurname, TDOB, TMobileNumber, TPosition, TInOffice);
                Assert.AreEqual(error, "");
            }

            #endregion

            #region DateValidationTests

            [TestMethod]
            public void DateTimeLettersCheck()
            {
                //test date time with letters in it
                clsStaff aStaff = new clsStaff();
                String testDate = "a1/03/20";
                String error = aStaff.ValidateDateTime(testDate);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void DateTimeSymbolsCheck()
            {
                //test date time with invalid symbols in it
                clsStaff aStaff = new clsStaff();
                String testDate = "01/3$6/20";
                String error = aStaff.ValidateDateTime(testDate);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void DateTimeValidCheck()
            {
                //test valid date time examples
                clsStaff aStaff = new clsStaff();
                String error = aStaff.ValidateDateTime(TDOB);
                Assert.AreEqual(error, "");
            }

            #endregion

            #region MobileNumberValidationTests

            [TestMethod]
            public void MobileNumberLettersCheck()
            {
                //test number with letters in it, spaces don't matter
                clsStaff aStaff = new clsStaff();
                String testMobileNumber = "0123a456789";
                String error = aStaff.ValidateMobileNumber(testMobileNumber);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void MobileNumberSymbolsCheck()
            {
                //test number with symbols in it
                clsStaff aStaff = new clsStaff();
                String testMobileNumber = "012345678*90";
                String error = aStaff.ValidateMobileNumber(testMobileNumber);
                Assert.AreNotEqual(error, "");
            }

            [TestMethod]
            public void MobileNumberValidTest()
            {
                //test valid numbers
                clsStaff aStaff = new clsStaff();
                String testMobileNumber = "1234 5678";
                String error = aStaff.ValidateMobileNumber(testMobileNumber);
                Assert.AreEqual(error, "");
            }

            [TestMethod]
            public void MobileNumberLengthTest()
            {
                //test boundaries (WIP)
                //is phone number stored as int32 or int64, or string?
            }

            #endregion

            #endregion

        }

        [TestClass]
        public class StaffCollectionTesting
        {
            [TestMethod]
            public void CollectionInstanceOk()
            {
                clsStaff aStaff = new clsStaff();
                clsStaffCollection collection = new clsStaffCollection();
                collection.setStaff(aStaff);
                Assert.AreEqual(aStaff, collection.getStaff());
            }
        }
    }
}
