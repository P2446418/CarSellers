using System;
using System.Collections.Generic;

namespace CarSellersClasses
{
    public class clsOrderCollection
    {
        // private data member for list
        List<clsOrder> mOrderList = new List<clsOrder>();
        // private data member thisAddress
        clsOrder mThisOrder = new clsOrder();
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
        public clsOrder ThisOrder
        {
            get
            {
                // return private data
                return mThisOrder;
            }
            set
            {
                // set private data
                mThisOrder = value;
            }
        }

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

        public int Add()
        {
            
            // adds record to database based on mThisOrder
            // connect to database
          
            clsDataConnection DB = new clsDataConnection();

            // set values
            DB.AddParameter("@NumberPlate", mThisOrder.numberPlate);
            DB.AddParameter("@CustomerID", mThisOrder.customerID);
            DB.AddParameter("Quantity", mThisOrder.quantity);
            DB.AddParameter("@Price", mThisOrder.price);
            DB.AddParameter("@DateOrdered", mThisOrder.dateOrdered);
            // return primary key of new record
            return DB.Execute("dbo.sproc_OrderTable_Insert");
            
        }

        public void Delete()
        {
            // deletes record pointed to by ThisOrder
            // connect to db
            clsDataConnection DB = new clsDataConnection();
            // set parameters for stored procedure
            DB.AddParameter("@OrderID", mThisOrder.orderID);
            // execute procedure
            DB.Execute("dbo.sproc_OrderTable_Delete");
        }

        public void Update()
        {
            // update an existing record based on ThisOrder value
            // connect to database
            clsDataConnection DB = new clsDataConnection();
            // set parameters for stored procedure
            DB.AddParameter("@OrderID", mThisOrder.orderID);
            DB.AddParameter("@NumberPlate", mThisOrder.numberPlate);
            DB.AddParameter("@CustomerID", mThisOrder.customerID);
            DB.AddParameter("Quantity", mThisOrder.quantity);
            DB.AddParameter("@Price", mThisOrder.price);
            DB.AddParameter("@DateOrdered", mThisOrder.dateOrdered);
            // execute stored procedure
            DB.Execute("dbo.sproc_OrderTable_Update");
            
        }
    }
}