using System;

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
       public bool FindOriginal(int CustomerNo)
        {
            mCustomerID = 1;
            mName = "bob";
            mSurname = "Smith";
            mNumber = 12345;
            mEmail = "bobsmith@example.com";
            mAddress = "123 example street";
            mDOB = Convert.ToDateTime("16/09/2015");
            mDelete = false;

            //always return true
            return true;
        }

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

	}
}