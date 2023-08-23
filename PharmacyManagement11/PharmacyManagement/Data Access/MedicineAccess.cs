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
    class MedicineAccess : DataAccess
    {
        public bool InsertMedicine(string medicineName, string medicineCompanyName, string medicineCategory, double buyingPrice, double sellingPrice, int initialQuantity, string expiringDate, double discount)
        {
            string sql =
"INSERT INTO Inventory ( MedicineName , Category , CompanyName , BuyingPrice, SellingPrice, Quantity , ExpiringDate , Discount) VALUES ( '" + medicineName + "' ," +
" '" + medicineCategory + "' ,'" + medicineCompanyName + "', '" + buyingPrice + "' , '" + sellingPrice + "' ,'" + initialQuantity + "' ,'" + expiringDate + "', '" + discount + "')";

            if (this.ExecuteQuery(sql) > 0)
                return true;
            else
                return false;
        }


        public bool DeleteMedicine(string name, string category)
        {
            string sql = "DELETE FROM Inventory WHERE Category ='" + category + "' AND MedicineName ='" + name + "'";
            if (this.ExecuteQuery(sql) > 0)
                return true;
            else
                return false;
        }

        public bool UpdateMedicineQuantity(int id, int quantity)
        {
            string sql = "UPDATE Inventory SET Quantity='" + quantity + "' WHERE MedicineId= '" + id + "' ";
            if (this.ExecuteQuery(sql) > 0)
                return true;
            else
                return false;
        }

        public int GetQuantity(int id)
        {
            int quantity = 0;
            string sql = " SELECT *FROM Inventory WHERE MedicineId= '" + id + "'";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                quantity = (int)reader["Quantity"];
            }
            return quantity;
        }

        public int GetMedicineQuantityByName(string name)
        {
            int quantity = 0;
            string sql = " SELECT * FROM Inventory WHERE MedicineName= '" + name + "'";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                quantity = (int)reader["Quantity"];
            }
            return quantity;
        }


        public bool GetMedicineName(string name)
        {
            string sql = " SELECT * FROM Inventory WHERE MedicineName= '" + name + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                return true;
            }
            else return false;
        }

        public bool UpdateMedicineSellingPrice(int id, double price)
        {
            string sql = "UPDATE Inventory SET SellingPrice='" + price + "' WHERE MedicineId= '" + id + "' ";
            if (this.ExecuteQuery(sql) > 0)
                return true;
            else
                return false;
        }

        public bool UpdateMedicineExpDate(int id, string expdate)
        {
            string sql = "UPDATE Inventory SET ExpiringDate='" + expdate + "' WHERE MedicineId= '" + id + "' ";
            if (this.ExecuteQuery(sql) > 0)
                return true;
            else
                return false;
        }


        public bool UpdateMedicineDiscount(int id, double discount)
        {
            string sql = "UPDATE Inventory SET Discount ='" + discount + "' WHERE MedicineId= '" + id + "' ";
            if (this.ExecuteQuery(sql) > 0)
                return true;
            else
                return false;
        }

        public List<Medicine> GetMedicines()
        {
            List<Medicine> medicines = new List<Medicine>();
            string sql = "SELECT * FROM Inventory ";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {

                Medicine medicine = new Medicine();

                medicine.MedicineId = (int)reader["MedicineId"];
                medicine.MedicineName = reader["MedicineName"].ToString();
                medicine.MedicineCategory = reader["Category"].ToString();
                medicine.MedicineCompanyName = reader["CompanyName"].ToString();
                medicine.BuyingPrice = (double)reader["BuyingPrice"];
                medicine.SellingPrice = (double)reader["SellingPrice"];
                medicine.InitialQuantity = (int)reader["Quantity"];
                medicine.ExpiringDate = reader["ExpiringDate"].ToString();

                if (reader["Discount"].ToString() == "")
                { medicine.Discount = 0; }
                else { medicine.Discount = (double)reader["Discount"]; }
                if (reader["ProfitOrLoss"].ToString() == "")
                { medicine.ProfitOrLoss = 0; }
                else { medicine.Discount = (double)reader["ProfitOrLoss"]; }

                if (reader["Remaining"].ToString() == "")
                { medicine.RemainingQuantity = 0; }
                else { medicine.Discount = (double)reader["Remaining"]; }
                medicines.Add(medicine);

            }

            return medicines;
        }
        public Medicine addMedicineToGridView(string medicineName)
        {


            string sql = " SELECT *FROM Inventory WHERE MedicineName = '" + medicineName + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                Medicine medicine = new Medicine();

                medicine.MedicineId = (int)reader["MedicineId"];
                medicine.MedicineName = reader["MedicineName"].ToString();
                medicine.MedicineCategory = reader["Category"].ToString();
                medicine.MedicineCompanyName = reader["CompanyName"].ToString();
                medicine.BuyingPrice = (double)reader["BuyingPrice"];
                medicine.SellingPrice = (double)reader["SellingPrice"];

                medicine.ExpiringDate = reader["ExpiringDate"].ToString();

                if (reader["Discount"].ToString() == "")
                { medicine.Discount = 0; }
                else { medicine.Discount = (double)reader["Discount"]; }
                if (reader["ProfitOrLoss"].ToString() == "")
                { medicine.ProfitOrLoss = 0; }
                else { medicine.Discount = (double)reader["ProfitOrLoss"]; }

                if (reader["Remaining"].ToString() == "")
                { medicine.RemainingQuantity = 0; }
                else { medicine.Discount = (double)reader["Remaining"]; }

                medicine.InitialQuantity = (int)reader["Quantity"];

                return medicine;
            }
            else
                return null;


        }

        public int GetTotalMedicineUnit()
        {
            int totalUnit = 0;
            string sql = "Select * from Inventory";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                totalUnit = (int)reader["Quantity"] + totalUnit;
            }
            return totalUnit;
        }

        public double GetTotalMedicineProfit(string name)
        { double totalProfit = 0;
            string sql = " SELECT *FROM BillTable WHERE ProductName= '" + name + "'";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                totalProfit = (double)reader["ProfitorLoss"] + totalProfit;
            }
            return totalProfit;
        }

        public double CalculateNetWorth()
        {
            double netWorth = 0;
            string sql = " SELECT  *  FROM Inventory" ;
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {   
               double buyingPrice = (double)reader["BuyingPrice"];
               int quantity = (int)reader["Quantity"];
                netWorth = (buyingPrice * quantity )+ netWorth;
            }
            return netWorth;

        }

        public List<string> GetCompanyNames()
        {
            List<string> companies = new List<string>();
            string companyName = "";
            string sql = " SELECT * FROM Inventory ";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                companyName = reader["CompanyName"].ToString();

                companies.Add(companyName);
            }
            return companies;

        }

        public double GetCompanyProfit(string name)
        {
            double totalProfit = 0;
            string sql = " SELECT *FROM BillTable WHERE CompanyName = '" + name + "'";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                totalProfit = (double)reader["ProfitorLoss"] + totalProfit;
            }
            return totalProfit;

        }

        public int  GetTotalMedicineSoldUnit(string name)
        {
           int totalsold = 0;
            string sql = " SELECT *FROM BillTable WHERE ProductName = '" + name + "'  ";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                totalsold = (int)reader["ProductQuantity"] + totalsold;
            }
            return totalsold;
        }



        public List<string> GetMedicineNames()
        {
            List<string> medNames = new List<string>();
            string sql = " SELECT *FROM Inventory ";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                string name;
                name = reader["MedicineName"].ToString();
                medNames.Add(name);
            }
            return medNames;
        }

        public List<Medicine> GetAllMedicineSaleInfo(List<string> medNames)
        {
            List<Medicine> medicines = new List<Medicine>();
            for (int i = 0; i < medNames.Count; i++)
            {
                Medicine medicine = new Medicine();

                medicine.MedicineName = medNames[i];
                medicine.ProfitOrLoss = GetTotalMedicineProfit(medNames[i]);
                medicines.Add(medicine);
            }
            if (medicines != null)

            { return medicines; }
            else return null;

        }

        public bool UpdateQuantityAfterSelling(string name ,int quantity)
        {
            string sql = "UPDATE Inventory SET Quantity='" + quantity + "' WHERE MedicineName= '"+name+"' " ;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;

        }

        public bool searchCompany (string name)
        {
            string sql = "Select * from Inventory  WHERE CompanyName= '" + name + "' ";
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            { return true; }
            else return false;
        }

        public List<Medicine> GetBillMedicines (string medicineName)
        {
            List<Medicine> medicines = new List<Medicine>();
            MedicineAccess medicineAccess = new MedicineAccess();
            Medicine medicine = new Medicine();

            if (medicineAccess.addMedicineToGridView(medicineName) != null)
            {
                medicines.Add(medicineAccess.addMedicineToGridView(medicineName));
                return medicines;
            }
            else
                return null;

        }

      
        }






    }

