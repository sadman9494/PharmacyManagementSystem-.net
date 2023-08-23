using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace PharmacyManagement
{
    class BillOperations : Bill
    {
        public List<Bill> BillHistory()
        {
            List<Bill> billHistory = new List<Bill>();
            string sql = "SELECT * FROM BillTable";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {

                Bill bill = new Bill();

                bill.BillID = (int)reader["BillID"];
                bill.ProductName = reader["ProductName"].ToString();
                bill.ProductPrice = (double)reader["ProductPrice"];
                bill.ProductQuantity = (int)reader["ProductQuantity"];
                bill.ProfitLoss = (double)reader["ProfitorLoss"];
                bill.BillDate = reader["BillDate"].ToString();
                bill.BillAmount = (double)reader["TotalAmount"];
                bill.CustomerName = reader["CustomerName"].ToString();
                bill.CompanyName = reader["CompanyName"].ToString();
                bill.BillDiscount = (double)reader["Discount"];

                billHistory.Add(bill);

            }
            if (billHistory.Count != 0)
            { return billHistory; }
            else { return null; }
        }

        public List<Bill> AdminBillHistory()
        {
            List<Bill> billHistory = new List<Bill>();
            string sql = "SELECT * FROM BillTable ";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {

                Bill bill = new Bill();

                bill.BillID = (int)reader["BillID"];
                bill.ProductName = reader["ProductName"].ToString();
                bill.ProductPrice = (double)reader["ProductPrice"];
                bill.ProductQuantity = (int)reader["ProductQuantity"];
                bill.ProfitLoss = (double)reader["ProfitorLoss"];
                bill.BillDate = reader["BillDate"].ToString();
                bill.BillAmount = (double)reader["TotalAmount"];
                bill.CustomerName = reader["CustomerName"].ToString();
                bill.CompanyName = reader["CompanyName"].ToString();
                bill.BillDiscount = (double)reader["Discount"];

                billHistory.Add(bill);

            }
            if (billHistory.Count != 0)
            { return billHistory; }
            else { return null; }
        }
    }
}
