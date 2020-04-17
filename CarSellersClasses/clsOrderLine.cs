using System;

namespace CarSellersClasses
{
    public class clsOrderLine
    {
        private int mOrderLineID;
        private int mOrderID;
        private int mStaffID;
        private bool mOrderComplete;
        public int orderLineID
        {
            get
            {
                return mOrderLineID;
            }
            set
            {
                mOrderLineID = value;
            }
        }
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
        }
        public int staffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }
        public bool orderComplete
        {
            get
            {
                return mOrderComplete;
            }
            set
            {
                mOrderComplete = value;
            }
        }
        public bool Find(int orderLineID)
        {
            // connect to DB
            clsDataConnection DB = new clsDataConnection();
            // add DB search parameter for Order ID
            DB.AddParameter("@OrderLineID", orderLineID);
            // execute stored procedure
            DB.Execute("dbo.sproc_OrderLineTable_FilterByOrderLineID");
            // if 1 record is found
            if (DB.Count == 1)
            {
                mOrderLineID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mOrderComplete = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderComplete"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}