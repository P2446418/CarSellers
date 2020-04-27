﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CarSellersClasses
{
    public class clsOrderLineCollection
    {
        List<clsOrderLine> mOrderLineList = new List<clsOrderLine>();
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
        public clsOrderLine ThisOrderLine { get; set; }

        // class constructor
        public clsOrderLineCollection()
        {
            // index variable
            Int32 Index = 0;
            // var for record count
            Int32 RecordCount = 0;
            // data connection object
            clsDataConnection DB = new clsDataConnection();
            // execute stored procedure
            DB.Execute("dbo.sproc_OrderLine_SelectAll");
            // get record count
            RecordCount = DB.Count;
            // while there are records
            while (Index < RecordCount)
            {
                // create blank Order
                clsOrderLine AnOrderLine = new clsOrderLine();
                // read fields from current record
                AnOrderLine.orderLineID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLineID"]);
                AnOrderLine.orderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrderLine.staffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnOrderLine.orderComplete = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderComplete"]);
                // add record to private list
                mOrderLineList.Add(AnOrderLine);
                // point to next record
                Index++;
            }
        }
    }
}