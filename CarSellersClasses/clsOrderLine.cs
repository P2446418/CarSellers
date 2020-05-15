using System;

namespace CarSellersClasses
{
    public class clsOrderLine
    {
        // private property vars
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
        // test validity of properties
        public string Valid(string orderID, string staffID)
        {
            int OrderIDTemp;
            int StaffIDTemp;
            String Error = "";
            try
            {
                OrderIDTemp = Convert.ToInt32(orderID);
                if(OrderIDTemp < 1)
                {
                    Error = Error + "The Order ID cannot be less than 1 : ";
                }
                if(OrderIDTemp > int.MaxValue)
                {
                    Error = Error + "The Order ID cannot be greater than the max integer value : ";
                }
            }
            catch
            {
                Error = Error + "The Order ID is not a valid integer : ";
            }

            try
            {
                StaffIDTemp = Convert.ToInt32(staffID);
                if (StaffIDTemp < 1)
                {
                    Error = Error + "The Staff ID cannot be less than 1 : ";
                }
                if (StaffIDTemp > 100)
                {
                    Error = Error + "The Staff ID cannot be greater than 100 : ";
                }
            }
            catch
            {
                Error = Error + "The Staff ID is not a valid integer : ";
            }


            return Error;
        }
    }
}