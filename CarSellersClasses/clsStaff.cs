using System;
using System.Text.RegularExpressions;

namespace CarSellersClasses
{
    public class clsStaff
    {

        #region ClassFields

        private int mStaffID;
        public int StaffID
        {
            get { return mStaffID; }
            set { mStaffID = value; }
        }

        private String mFirstName;
        public String FirstName
        {
            get { return mFirstName; }
            set { mFirstName = value; }
        }

        private String mSurname;
        public String Surname
        {
            get { return mSurname; }
            set { mSurname = value; }
        }

        private String mMobileNumber;
        public String MobileNumber
        {
            get { return mMobileNumber; }
            set { mMobileNumber = value; }
        }

        private DateTime mDOB;
        public DateTime DOB
        {
            get { return mDOB; }
            set { mDOB = value; }
        }

        private String mPosition;
        public String Position
        {
            get { return mPosition; }
            set { mPosition = value; }
        }

        private bool mInOffice;
        public bool InOffice
        {
            get { return mInOffice; }
            set { mInOffice = value; }
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
        public bool Find(int StaffNo)
        {
            //create an instance of the data connection
            clsDataConnection Database = new clsDataConnection();

            //add the parameter for the customer ID to search for
            Database.AddParameter("@StaffId", StaffNo);

            //execute stored proc
            Database.Execute("sproc_StaffTable_FilterByID");

            //if one record is found then retrieve it
            if (Database.Count == 1)
            {
                mStaffID = Convert.ToInt32(Database.DataTable.Rows[0]["StaffId"]);
                mFirstName = Convert.ToString(Database.DataTable.Rows[0]["FirstName"]);
                mSurname = Convert.ToString(Database.DataTable.Rows[0]["Surname"]);
                mDOB = DateTime.Parse(Convert.ToString(Database.DataTable.Rows[0]["DOB"]));
                mMobileNumber = Convert.ToString(Database.DataTable.Rows[0]["MobileNumber"]);
                mInOffice = Convert.ToBoolean(Database.DataTable.Rows[0]["InOffice"]);
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
        public String Valid(String SFirstName, String SSurname, String SDOB, String SPhoneNumber, String SPosition, bool SInOffice)
        {
            String Error = "";
            //mName, check for symbols and length
            Error = ValidateNames(SFirstName, "FirstName");
            //mSurname, check for symbols and length
            Error += ValidateNames(SSurname, "Surname");
            //mDob, check for datetime format and if it's valid for SQL
            Error += ValidateDateTime(SDOB);
            //mMobileNumber, check if actual number, no letters
            Error += ValidateMobileNumber(SPhoneNumber);
            //mPosition, check for symbols and length
            Error += ValidateNames(SPosition, "Position");
            //mInOffice, check if actual number, only
            return Error;
        }

        public String ValidateNames(String FirstNameString, String field)
        {
            String error = "";
            //check for blanks
            if ((FirstNameString.Length == 0) || (FirstNameString == null))
            {
                return "[!] " + field + " cannot be null\n";
            }
            //check for out of boundary
            if (FirstNameString.Length > 25)
            {
                return "[!] " + field + " cannot be more than 25 characters\n";
            }
            //regex check to look for invalid characters
            Regex FirstNameCheck = new Regex("[a-zA-z- '-]");
            if (!(FirstNameCheck.IsMatch(FirstNameString)))
            {
                error += "[!] " + field + " contains invalid characters, numbers or symbols\n";
            }

            return error;
        }

        public String ValidateDateTime(String date)
        {
            //Customer SQL table is using Date data type, so format required is YYYY/MM/DD
            //C# datetime uses DD/MM/YY HH/MM/SS and can be parsed as different formats
            String error = "";
            try
            {
                //parse string into datetime and back
                DateTime tempDate = DateTime.Parse(date);

                if (tempDate > DateTime.Now) { return "[!] Date is in the future"; }

                String correctFormat = tempDate.ToString("YYYY-MM-DD 00:00:00");

                //check if correct format, length etc.
                if (date != correctFormat) { error += "[!] Date is not in correct format\n"; }
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

        public String ValidateMobileNumber(String MobileNumberString)
        {
            String error = "";
            //check for blank input
            if (MobileNumberString == "" || MobileNumberString == null)
            {
                return "[!] Phone number cannot be left blank\n";
            }
            try
            {
                //convert NumberString into integer
                String tempString = MobileNumberString.Replace(" ", "1");
                int testMobileNumber = Convert.ToInt32(tempString);
            }
            catch (OverflowException e) //if number exceeds integer size limit
            {
                error += "[!] Mobile number is too long\n";
            }
            catch //if number cannot be parsed as an integer
            {
                error += "[!] Mobile number cannot contain letters or invalid characters\n";
            }
            return error;
        }

    }
}