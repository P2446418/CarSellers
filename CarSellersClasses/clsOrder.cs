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

        public string Valid(string dateOrdered, string numberPlate, string customerID, string quantity, string price)
        {
            String Error = "";
            DateTime DateTemp;
            int CustomerIDTemp;
            int QuantityTemp;
            double PriceTemp;
            try
            {
                DateTemp = Convert.ToDateTime(dateOrdered);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }


            try
            {
                CustomerIDTemp = Convert.ToInt32(customerID);
                if (CustomerIDTemp < 1)
                {
                    Error = Error + "Customer ID cannot be less than 1 : ";
                }
                if (CustomerIDTemp > Int32.MaxValue)
                {
                    Error = Error + "Customer ID cannot be larger than max integer value : ";
                }
            }
            catch
            {
                Error = Error + "Customer ID is not a valid integer : ";
            }

            try
            {
                QuantityTemp = Convert.ToInt32(quantity);
                if (QuantityTemp < 1)
                {
                    Error = Error + "Quantity cannot be less than 1 : ";
                }
                if (QuantityTemp > 10)
                {
                    Error = Error + "Quantity cannot be larger than 10 : ";
                }
            }
            catch
            {
                Error = Error + "Quantity is not a valid integer : ";
            }

            try
            {
                PriceTemp = Convert.ToDouble(price);
                if(PriceTemp < 1)
                {
                    Error = Error + "The price cannot be less than 1 : ";
                }
                if(PriceTemp > 50000)
                {
                    Error = Error + "The price cannot be greater than 50000";
                }
            }
            catch
            {
                Error = Error + "Price is not a valid double value : ";
            }

            if (numberPlate.Length < 2)
            {
                Error = Error + "The number plate cannot be less than 2 characters : ";
            }
            if (numberPlate.Length > 7)
            {
                Error = Error + "The number plate cannot be longer than 7 characters : ";
            }


            return Error;
        }
    }
}