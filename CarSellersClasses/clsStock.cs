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

            try
            {
                DateTemp = Convert.ToDateTime(productionDate);
                if (DateTemp < DateTime.Now.Date.AddYears(-30))
                {
                    Error = Error + "The car cannot be older than 30 years ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The car cannot be from the future ";
                }
            }
            catch
            {
                Error = Error + "invalid date entered, enter in the format dd/mm/yyyy ";
            }
           
            try
            {
                int mileageTemp = Convert.ToInt32(mileage);
                if (mileageTemp < 0)
                {
                    Error = Error + "The car cannot have a negative mileage ";
                }
                if (mileageTemp > 200000)
                {
                    Error = Error + "The car cannot have more than 200,000 miles travelled ";
                }


                if (mileageTemp < 0)
                {
                    Error = Error + "The car cannot have a negative mileage ";
                }
                if (mileageTemp > 200000)
                {
                    Error = Error + "The car cannot have more than 200,000 miles travelled ";
                }
            }
            catch
            {
                Error = Error + "invalid mileage entered, enter a number only ";
            }

            try
            {
                int priceTemp = Convert.ToInt32(price);
                if (priceTemp < 500)
                {
                    Error = Error + "The car cannot be valued at less than £500 ";
                }
                if (priceTemp > 100000)
                {
                    Error = Error + "The car cannot be valued at more than £100,000 ";
                }
            }
           catch
            {
                Error = Error + "invalid price entered, enter a number only ";
            }

            if (modelName.Length < 1)
            {
                Error = Error + "The model name must be at least one character ";
            }
            
            if (modelName.Length > 20)
            {
                Error = Error + "The model name must be fewer than twenty characters ";
            }
 

                return Error;
            
        }
    }
}