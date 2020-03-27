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


        //constructor
        public clsCustomer()
		{
			name = "";
		}

        //get set methods (WIP)
		public void setName(String newName)
		{
			name = newName;
		}

		public String getName() { return name; }

        //find method

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

        //validation method
        //just simple sanitation and filtering, returns error message if any
        public String Valid(String CName, String CSurname, String CDOB, String CNumber, String CEmail)
        {
            String Error = "";
            //mName
            Error = ValidateNames(CName, "FirstName");
            //mSurname
            Error += ValidateNames(CSurname, "SurName");
            //mDob, check for datetime format
            Error += ValidateDateTime(CDOB);
            //mNumber, check if actual number, no letters
            Error += ValidateNumber(CNumber);
            //mEmail, check if email format
            Error += ValidateEmail(CEmail);
            return Error;
        }

        public String ValidateNames(String nameString, String field)
        {
            String error = "";

            if ((nameString.Length == 0) || (nameString == null))
            {
                error += field + " cannot be null\n";
            }
            if (nameString.Length > 25)
            {
                error += field + " cannot be more than 25 characters\n";
            }

            Regex NameCheck = new Regex("[a-zA-z- '-]");
            if (!(NameCheck.IsMatch(nameString)))
            {
                error += "Name contains invalid characters, numbers or symbols\n";
            }

            return error;
        }

        public String ValidateDateTime(String date)
        {
            //Customer SQL table is using Date data type, so format required is YYYY/MM/DD
            //C# datetime uses DD/MM/YY HH/MM/SS
            //can be parsed in different format
            String error = "";
            try
            {
                //parse
                DateTime tempDate = DateTime.Parse(date);
                String correctFormat = tempDate.ToString();

                //check if correct format, length etc.
                if (date != correctFormat) { error += "[!] Date is not in correct format\n"; }
            }
            catch
            {
                error += "[!] Date contains invalid characters and or symbols\n";
            }

            return error;
        }

        public String ValidateNumber(String NumberString)
        {
            String error = "";
            try
            {
                String tempString = NumberString.Replace(" ", "1");
                int testNumber = Convert.ToInt32(tempString);
            }
            catch (OverflowException e)
            {
                error += "[!] Phone number is too long\n";
            }
            catch
            {
                error += "[!] Phone number cannot contain letters or invalid characters\n";
            }
            return error;
        }

        public String ValidateEmail(String emailString)
        {
            String error = "";

            if (emailString.Contains(" "))
            {
                error += "[!] Email cannot contain spaces\n";
            }

            //just use regex * @ * . *
            //"^[a-zA-Z0-9]@[a-zA-Z0-9].[a-zA-Z-.]$"
            Regex EmailCheck = new Regex("[a-zA-Z0-9]@[a-zA-Z0-9].[a-zA-Z-.]");
            if (!(EmailCheck.IsMatch(emailString)))
            {
                error += "[!] Email is not correct format\n";
            }

            return error;
        }

	}
}