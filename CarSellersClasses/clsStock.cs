using System;
namespace CarSellersClasses
{
    public class clsStock
    {
        public string numberPlate
        {
            get
            {
                return mNumberPlate;
            }

            set
            {
                mNumberPlate = value;
            }
        }

        public DateTime productionDate
        {
            get
            {
                return mProductionDate;
            }
            set
            {
                mProductionDate = value;
            }
        }
        public int mileage
        {
            get
            {
                return mMileage;
            }
            set
            {
                mMileage = value;
            }
        }
        public double price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        public bool sold
        {
            get
            {
                return mSold;
            }
            set
            {
                mSold = value;
            }
        }
        public String modelName
        {
            get
            {
                return mModelName;
            }
            set
            {
                mModelName = value;
            }
        }
        private DateTime mProductionDate;
        private string mNumberPlate;
        private int mMileage;
        private double mPrice;
        private bool mSold;
        private string mModelName;

        public bool Find(String numberPlate)
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@numberPlate", numberPlate);
            DB.Execute("sproc_stockTable_FilterByNumberPlate");
            if (DB.Count == 1)
            {
                mNumberPlate = Convert.ToString(DB.DataTable.Rows[0]["numberPlate"]);
                mProductionDate = Convert.ToDateTime(DB.DataTable.Rows[0]["productionDate"]);
                mMileage = Convert.ToInt32(DB.DataTable.Rows[0]["mileage"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["price"]);
                mSold = Convert.ToBoolean(DB.DataTable.Rows[0]["sold"]);
                mModelName = Convert.ToString(DB.DataTable.Rows[0]["modelName"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(
            string productionDate,
            string mileage,
            string price,
            string sold,
            string modelName)
        {
            string Error = "";
            DateTime DateTemp;

            DateTemp = Convert.ToDateTime(productionDate);
            if (DateTemp < DateTime.Now.Date.AddYears(-30)) 
            {
                Error = Error + "The car may not be older than 30 years";
            }
            if (DateTemp > DateTime.Now.Date)
            {
                Error = Error + "The car cannot be from the future";
            }
            return Error;
        }
    }
}