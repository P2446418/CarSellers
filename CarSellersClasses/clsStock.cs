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

        public bool Find(String we)
        {
            numberPlate = "Num43";
            productionDate = Convert.ToDateTime("29/02/2000");
            mileage = 41000;
            price = 50000;
            sold = true;
            return true;
        }
    }
}