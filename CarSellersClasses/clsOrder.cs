using System;

namespace CarSellersClasses
{
    public class clsOrder

    {
        private int mOrderID;
        private DateTime mDateOrdered;
        private string mNumberPlate;
        private int mCustomerID;
        private int mQuantity;
        private double mPrice;
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
        public int customerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }//tested
        public int quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }//tested
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
        }//tested
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
            // connect to DB
            clsDataConnection DB = new clsDataConnection();
            // add DB search parameter for Order ID
            DB.AddParameter("@OrderID", orderID);
            // execute stored procedure
            DB.Execute("dbo.sproc_OrderTable_FilterByOrderID");
            // if 1 record is found
            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mDateOrdered = Convert.ToDateTime(DB.DataTable.Rows[0]["dateOrdered"]);
                mNumberPlate = Convert.ToString(DB.DataTable.Rows[0]["numberPlate"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["customerID"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["quantity"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["price"]);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}