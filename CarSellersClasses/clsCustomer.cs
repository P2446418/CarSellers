using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CarSellersClasses
{

    public class clsCustomer
    {
        #region ClassFields

        private int mCustomerID;
        public int CustomerID
        {
            get { return mCustomerID; }
            set { mCustomerID = value; }
        }

        private String mName;
        public String name
        {
            get { return mName; }
            set { mName = value; }
        }

        private String mSurname;
		public String surname
        {
            get { return mSurname; }
            set { mSurname = value; }
        }

        private DateTime mDOB;
		public DateTime DOB
        {
            get { return mDOB; }
            set { mDOB = value; }
        }

        private int mNumber;
        public int PhoneNumber
        {
            get { return mNumber; }
            set { mNumber = value; }
        }

        private String mEmail;
		public String email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }

        private String mAddress;
		public String Address
        {
            get { return mAddress; }
            set { mAddress = value; }
        }

        private Boolean mDelete;
		public Boolean toDelete
        {
            get { return mDelete; }
            set { mDelete = value; }
        }

        #endregion

        //find method
        //currently uses the filterById procedure, not sure if that will change in future
        public bool Find(int CustomerNo)
        {
            //create an instance of the data connection
            clsDataConnection Database = new clsDataConnection();

            //add the parameter for the customer ID to search for
            Database.AddParameter("@CustomerId", CustomerNo);

            //execute stored proc
            Database.Execute("sproc_CustomerTable_FilterByID");

            //if one record is found then retrieve it
            if (Database.Count == 1)
            {
                mCustomerID = Convert.ToInt32(Database.DataTable.Rows[0]["CustomerId"]);
                mName = Convert.ToString(Database.DataTable.Rows[0]["FirstName"]);
                mSurname = Convert.ToString(Database.DataTable.Rows[0]["SurName"]);
                mDOB = DateTime.Parse(Convert.ToString(Database.DataTable.Rows[0]["DateOfBirth"]));
                mNumber = Convert.ToInt32(Database.DataTable.Rows[0]["PhoneNumber"]);
                mEmail = Convert.ToString(Database.DataTable.Rows[0]["Email"]);
                mAddress = Convert.ToString(Database.DataTable.Rows[0]["Address"]);
                mDelete = Convert.ToBoolean(Database.DataTable.Rows[0]["toDelete"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        //Main validation method and sub-validation methods
        //just simple sanitation and filtering, returns error message if any
        public String Valid(String CName, String CSurname, String CDOB, String CNumber, String CEmail, String CAddress)
        {
            String Error = "";
            //mName, check for symbols and length
            Error = ValidateNames(CName, "FirstName");
            //mSurname, check for symbols and length
            Error += ValidateNames(CSurname, "SurName");
            //mDob, check for datetime format and if it's valid for SQL
            Error += ValidateDateTime(CDOB);
            //mNumber, check if actual number, no letters
            Error += ValidateNumber(CNumber);
            //mEmail, check if email format, no spaces or invalid chars
            Error += ValidateEmail(CEmail);
            //mAddress, check if valid address, symbols and length
            Error += ValidateAddress(CAddress);
            return Error;
        }

        public String ValidateNames(String nameString, String field)
        {
            String error = "";
            //check for blanks
            if ((nameString.Length == 0) || (nameString == null))
            {
                return "[!] " + field + " cannot be null\n";
            }
            //check for out of boundary
            if (nameString.Length > 25)
            {
                return "[!] " + field + " cannot be more than 25 characters\n";
            }
            //regex check to look for invalid characters
            Regex NameCheck = new Regex("[a-zA-z- '-]");
            if (!(NameCheck.IsMatch(nameString)))
            {
                error += "[!] " + field + " contains invalid characters, numbers or symbols\n";
            }

            return error;
        }

        public String ValidateDateTime(String date)
        {
            //Customer SQL table is using Date data type, so format required is yyyy-MM-dd 00:00:00
            //C# datetime uses DD/MM/YY HH/MM/SS and can be parsed as different formats
            String error = "";
            try
            {
                //parse string into datetime and back
                DateTime tempDate = DateTime.Parse(date);

                if (tempDate > DateTime.Now) { return "[!] Date is in the future"; }

                String correctFormat = tempDate.ToString("yyyy-MM-dd 00:00:00");

                //check if correct format, length etc.
                if ((date + " 00:00:00") != correctFormat) { error += "[!] Date is not in correct format\n"; }
            }
            catch //date is not valid date
            {
                if (date == "" || date == null)
                {
                    return "[!] Date of birth cannot be left blank\n";
                }
                else
                {
                    error += "[!] Date contains invalid characters and or symbols\n";
                }
            }

            return error;
        }

        public String ValidateNumber(String NumberString)
        {
            String error = "";
            //check for blank input
            if (NumberString == "" || NumberString == null)
            {
                return "[!] Phone number cannot be left blank\n";
            }
            try
            {
                //convert NumberString into integer
                String tempString = NumberString.Replace(" ", "1");
                int testNumber = Convert.ToInt32(tempString);
            }
            catch (OverflowException e) //if number exceeds integer size limit
            {
                error += "[!] Phone number is too long\n";
            }
            catch //if number cannot be parsed as an integer
            {
                error += "[!] Phone number cannot contain letters or invalid characters\n";
            }
            return error;
        }

        public String ValidateEmail(String emailString)
        {
            String error = "";
            //check for blanks
            if (emailString == "" || emailString == null)
            {
                error += "[!] Email cannot be left blank\n";
                return error;
            }
            //emails cannot contain spaces
            if (emailString.Contains(" "))
            {
                error += "[!] Email cannot contain spaces\n";
                return error;
            }

            //just use regex * @ * . *
            //using regex pattern "[a-zA-Z0-9]@[a-zA-Z0-9].[a-zA-Z-.]" to check for email format
            Regex EmailCheck = new Regex("[a-zA-Z0-9]@[a-zA-Z0-9].[a-zA-Z-.]");
            if (!(EmailCheck.IsMatch(emailString)))
            {
                error += "[!] Email is not correct format\n";
            }

            return error;
        }

        public String ValidateAddress(String addressString)
        {
            String error = "";
            //check for blanks and length
            if (addressString == "" || addressString == null)
            {
                return "[!] Address cannot be left blank\n";
            }
            if (addressString.Length > 50)
            {
                return "[!] Address is too long";
            }

            //using same regex pattern as nameValidation
            Regex NameCheck = new Regex("[a-zA-z- '-]");
            if (!(NameCheck.IsMatch(addressString)))
            {
                return "[!] address contains invalid symbols\n";
            }

            return error;
        }

	}
}