using System;
using System.Collections.Generic;

namespace CarSellersClasses
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        public List<clsOrder> OrderList
        {
            get
            {
                // return private data
                return mOrderList;
            }
            set
            {
                // set private data
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                // return list count
                return mOrderList.Count;
            }
            set
            {

            }
        }
        public clsOrder ThisOrder { get; set; }

        // class constructor
        public clsOrderCollection()
        {
            // index variable
            Int32 Index = 0;
            // var for record count
            Int32 RecordCount = 0;
            // data connection object
            clsDataConnection DB = new clsDataConnection();
            // execute stored procedure
            DB.Execute("dbo.sproc_OrderTable_SelectAll");
            // get record count
            RecordCount = DB.Count;
            // while there are records
            while (Index < RecordCount)
            {
                // create blank Order
                clsOrder AnOrder = new clsOrder();
                // read fields from current record
                AnOrder.orderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.numberPlate = Convert.ToString(DB.DataTable.Rows[Index]["numberPlate"]);
                AnOrder.customerID = Convert.ToInt32(DB.DataTable.Rows[Index]["customerID"]);
                AnOrder.quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["quantity"]);
                AnOrder.price = Convert.ToDouble(DB.DataTable.Rows[Index]["price"]);
                AnOrder.dateOrdered = Convert.ToDateTime(DB.DataTable.Rows[Index]["dateOrdered"]);
                // add record to private list
                mOrderList.Add(AnOrder);
                // point to next record
                Index++;
            }
        }
    }
}