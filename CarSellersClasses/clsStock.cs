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
        private DateTime mProductionDate;
        private string mNumberPlate;
        public int mileage;
        public double price;
        public bool sold;
        public string modelName;

        public bool Find(String we)
        {
            numberPlate = "Num43";
            productionDate = Convert.ToDateTime("29/02/2000");
            return true;
        }
    }
}