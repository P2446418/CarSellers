using System;
using System.Collections.Generic;

namespace CarSellersClasses
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();
        public clsStockCollection()
        {
            int index = 0;

            int recordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_stockTable_selectAll");

            recordCount = DB.Count;

            while (index < recordCount)
            {
                clsStock aStock = new clsStock();

                aStock.numberPlate = Convert.ToString(DB.DataTable.Rows[0]["numberPlate"]);
                aStock.productionDate = Convert.ToDateTime(DB.DataTable.Rows[0]["productionDate"]);
                aStock.mileage = Convert.ToInt32(DB.DataTable.Rows[0]["mileage"]);
                aStock.price = Convert.ToInt32(DB.DataTable.Rows[0]["price"]);
                aStock.sold = Convert.ToBoolean(DB.DataTable.Rows[0]["sold"]);
                aStock.modelName = Convert.ToString(DB.DataTable.Rows[0]["modelName"]);

                mStockList.Add(aStock);

                index++;
            }



        }

        public List<clsStock> stockList {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
            }
        public int Count {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }
        public clsStock thisStock { get; set; }
    }
}