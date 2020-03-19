using System;
using System.Linq;

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
            //Error += "\n" + ValidateName(CSurname, "Surname");
            //mDob, check for datetime format
            //mNumber, check if actual number, no letters
            //mEmail, check if email format
            return Error;
        }

        public String ValidateNames(String nameString, String field)
        {
            String outcome = "";
            //check name length
            if (nameString.Length == 0)
            {
                outcome = "[!] " + field + " is 0 length";
            }
            //else if (nameString.Length > 25)
            //{
            //    outcome = "[!] " + field + " is too long";
            //}

            //check for numbers within string

            //check for symbols, exclude ' and - though
            //this is done by checking ascii values 65-90 and 97-122
            // ' has value of 96 and - has value of 45

            Boolean numbers = false;
            Boolean symbols = false;

            foreach (char letter in nameString)
            {
                
                if ((letter >= 48) && (letter <= 57))
                {
                    numbers = true;
                }
                else if (!(letter >= 65) && !(letter <= 90))
                {
                    symbols = true;
                }
                else if (!(letter >= 97) && !(letter <= 122))
                {
                    symbols = true;
                }

                if ((letter == 96) || (letter == 45))
                {
                    symbols = false;
                }

                if (symbols || numbers)
                {
                    break;
                }

            }

            if (numbers == true)
            {
                outcome += "\n[!] " + field + " contains numbers";
            }

            if (symbols == true)
            {
                outcome += "\n[!] " + field + " contains invalid symbols";
            }

            return outcome;
        }



	}
}