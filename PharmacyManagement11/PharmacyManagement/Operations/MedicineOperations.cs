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
    class MedicineOperations : Medicine
    {
        public List<Medicine> medicines = new List<Medicine>();

        public Medicine medicineInfo(int id)
        {
            string sql = "SELECT * FROM Inventory WHERE MedicineId =" + id;
            SqlDataReader reader = this.GetData(sql);

            if (reader.HasRows)
            {
                reader.Read();
                Medicine medicine = new Medicine();
                medicine.MedicineId = (int)reader["MedicineId"];
                medicine.MedicineName = reader["MedicineName"].ToString();
                medicine.MedicineCategory = reader["Catagory"].ToString();
                medicine.MedicineCompanyName = reader["CompanyName"].ToString();
                medicine.BuyingPrice = (double)reader["BuyingPrice"];
                medicine.SellingPrice = (double)reader["SellingPrice"];
                medicine.InitialQuantity = (int)reader["Quantity"];

                if (reader["Discount"].ToString() == "")
                {
                    medicine.Discount = 0;
                }
                else
                {
                    medicine.Discount = (double)reader["Discount"];
                }

                medicine.ExpiringDate = reader["ExpiringDate"].ToString();

                medicines.Add(medicine);
                return medicine;

            }
            else
                return null;

        }

        public List<string> getMedicineNames(string category)
        {
            string sql = "SELECT * FROM Inventory WHERE Category='" + category + "'";
            SqlDataReader reader = this.GetData(sql);
            List<string> medicineNames = new List<string>();
            while (reader.Read())
            {
                medicineNames.Add(reader["MedicineName"].ToString());
            }
            return medicineNames;
        }
    }
}
