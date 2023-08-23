using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement
{
    class BillDataAccess : DataAccess
    {
       

        public BillDataAccess()
        {
     
        }

       
        public bool InsertBill( int billid, string productName, string productCompanyName, double buyingPrice, double sellingPrice, int quantity, string customerName, double totalamount, int sellerId, string billdate, double discount )
        {
            double ProfitorLoss = totalamount - (buyingPrice * quantity);
            string sql =
    "INSERT INTO BillTable (BillId , ProductName , ProductPrice, ProductQuantity, Discount , CustomerName, TotalAmount , CompanyName, SellerId, BillDate , ProfitorLoss  )" +
    " VALUES ( '" + billid + "' ," +" '" + productName + "' ,'" + sellingPrice + "', '" + quantity + "' , '" + discount + "' ,'" + customerName + "' ,'" + totalamount + "'," +
    " '" + productCompanyName + "', '" + sellerId + "', '" + billdate + "',  '" + ProfitorLoss + "') ";

            if (this.ExecuteQuery(sql) > 0)
                return true;
            else
                return false;
        }


        public List<int> GetSalesmanID()
        {
            List<int> salesmanIDs = new List<int>();
            string sql = "SELECT * FROM BillTable ";

            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {  
                int id;
                id = (int)reader["SellerId"];
                salesmanIDs.Add(id);
            }
            return salesmanIDs;
        }


        public double GetTotalProfitOfASalesman(int id)
        {
            double totalProfitofASalesman = 0;
            string sql = " SELECT * FROM BillTable WHERE SellerId= '" + id + "'";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                totalProfitofASalesman = (double)reader["ProfitorLoss"] + totalProfitofASalesman;
            }
            return totalProfitofASalesman;

        }

         public List<Worker> GetAllWorkerSaleInfo(List<int> ids)
         {
            List<Worker> workers = new List<Worker>();
            for(int i=0; i<ids.Count; i++)
            {
                Worker worker = new Worker();
                worker.WorkerId = ids[i];
                worker.TotalProfitMade = GetTotalProfitOfASalesman(ids[i]);
                workers.Add(worker);

            }
            if (workers != null)
            { return workers; }
            else return null;

         }


        public double CalculateTotalProfit()
        {
            double totalProfit = 0;
            string sql = " SELECT *FROM BillTable ";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                totalProfit = (double)reader["ProfitorLoss"] + totalProfit;
            }
            return totalProfit;

        }

        public double CalculateTotalSellingPrice()
        {
            double sellingPrice = 0;
            string sql = " SELECT *FROM BillTable ";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                sellingPrice = (double)reader["TotalAmount"] + sellingPrice;
            }
            return sellingPrice;
        }

        public int CalculateSaleByDate(string date)
        {
            int todaysSales = 0;
            string sql = " SELECT *FROM BillTable WHERE BillDate ='" + date + "'";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                todaysSales = (int)reader["ProductQuantity"] + todaysSales;
            }
            return todaysSales;
        }




    }

   
}
