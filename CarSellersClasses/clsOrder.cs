using System;

namespace CarSellersClasses
{
    public class clsOrder

    {
        private int mOrderID;
        private DateTime mDateOrdered;
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
        public string numberPlate; //tested
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
            return true;
        }
    }
}