using System;
using System.Collections.Generic;

namespace CarSellersClasses
{
    public class clsStockCollection
    {
        clsStock mThisStock = new clsStock();
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
        public clsStock thisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@numberPlate", mThisStock.numberPlate);
            DB.AddParameter("@productionDate", mThisStock.productionDate);
            DB.AddParameter("@mileage", mThisStock.mileage);
            DB.AddParameter("@price", mThisStock.price);
            DB.AddParameter("@sold", mThisStock.sold);
            DB.AddParameter("@modelName", mThisStock.modelName);

            return DB.Execute("sproc_stockTable_insert");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@numberPlate", mThisStock.numberPlate);

            DB.Execute("sproc_stockTable_delete");

        }
    }
}