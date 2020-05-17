using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarSellersClasses
{
    public class clsOrderLineCollection
    {
        List<clsOrderLine> mOrderLineList = new List<clsOrderLine>();
        clsOrderLine mThisOrderLine = new clsOrderLine();
        public List<clsOrderLine> OrderLineList
        {
            get
            {
                // return private data
                return mOrderLineList;
            }
            set
            {
                // set private data
                mOrderLineList = value;
            }
        }
        public int Count
        {
            get
            {
                // return list count
                return mOrderLineList.Count;
            }
            set
            {

            }
        }
        public clsOrderLine ThisOrderLine {
            get
            {
                // return private data
                return mThisOrderLine;
            }
            set
            {
                //set private data
                mThisOrderLine = value;

            }
        }

        // class constructor
        public clsOrderLineCollection()
        {
            // object for data connection
            clsDataConnection DB = new clsDataConnection();
            // execute stored procedure
            DB.Execute("dbo.sproc_OrderLine_SelectAll");
            // populate array list
            PopulateArray(DB);
        }

        public int Add()
        {
            // adds record to database based on mThisOrder
            // connect to database

            clsDataConnection DB = new clsDataConnection();

            // set values
            DB.AddParameter("@OrderID", mThisOrderLine.orderLineID);
            DB.AddParameter("StaffID", mThisOrderLine.staffID);
            DB.AddParameter("@OrderComplete", mThisOrderLine.orderComplete);
            // return primary key of new record
            return DB.Execute("dbo.sproc_OrderLineTable_Insert");
        }

        public void Delete()
        {
            // deletes record pointed to by thisOrderLine
            // connect to database
            clsDataConnection DB = new clsDataConnection();
            // set parameters for stored procedure
            DB.AddParameter("@OrderLineID", mThisOrderLine.orderLineID);
            // execute stored proecdure
            DB.Execute("dbo.sproc_OrderLineTable_Delete");
        }

        public void Update()
        {
            // update existing record based on ThisOrderLine
            // connect to DB
            clsDataConnection DB = new clsDataConnection();
            // set stored procedure parameters
            DB.AddParameter("@OrderLineID", mThisOrderLine.orderLineID);
            DB.AddParameter("@OrderID", mThisOrderLine.orderID);
            DB.AddParameter("@StaffID", mThisOrderLine.staffID);
            DB.AddParameter("@OrderComplete", mThisOrderLine.orderComplete);
            // execute the procedure
            DB.Execute("dbo.sproc_OrderLineTable_Update");
        }

        public void ReportbyOrderID(int OrderID)
        {
            // filters the list based on OrderID
            // connect to DB
            clsDataConnection DB = new clsDataConnection();
            // add parameter to procedure
            DB.AddParameter("@OrderID", OrderID);
            // execute stored procedure
            DB.Execute("dbo.sproc_OrderLineTable_FilterbyOrderID");
            // populate array list with DB data
            PopulateArray(DB);
        }


        public void PopulateArray(clsDataConnection DB)
        {
            // populates array list based on data table in parameter
            // var for index
            Int32 Index = 0;
            // record count var
            Int32 RecordCount;
            // get record count
            RecordCount = DB.Count;
            // clear private list
            mOrderLineList = new List<clsOrderLine>();
            // while there are records to be processed
            while (Index < RecordCount)
            {
                // create blank orderline
                clsOrderLine AnOrderLine = new clsOrderLine();
                // get fields from current record
                AnOrderLine.orderLineID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLineID"]);
                AnOrderLine.orderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrderLine.staffID = Convert.ToInt32(DB.DataTable.Rows[Index]["staffID"]);
                AnOrderLine.orderComplete = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderComplete"]);
                // add record to private data member
                mOrderLineList.Add(AnOrderLine);
                // point to next record
                Index++;
            }
        }
    }
}
