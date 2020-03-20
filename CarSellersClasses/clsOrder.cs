using System;

namespace CarSellersClasses
{
    public class clsOrder

    {
        private int mOrderID;
        private DateTime mDateOrdered;
        private string mNumberPlate;
        public int orderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        } //done
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
        public int customerID; //tested
        public int quantity; //tested
        public double price; //tested
        public DateTime dateOrdered
        {
            get
            {
                return mDateOrdered;
            }
            set
            {
                mDateOrdered = value;
            }
        }
        public bool Find(int orderID)
        {
            mOrderID = 15;
            mDateOrdered = Convert.ToDateTime("12/03/2020");
            mNumberPlate = "AB12 DEF";
            return true;
        }
    }
}