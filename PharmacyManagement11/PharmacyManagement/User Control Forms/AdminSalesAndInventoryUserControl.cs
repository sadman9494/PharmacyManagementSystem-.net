using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class AdminSalesAndInventoryUserControl : UserControl
    {
        public AdminSalesAndInventoryUserControl()
        {
            InitializeComponent();
        }

        private void AdminSalesAndInventoryUserControl_Load_1(object sender, EventArgs e)
        {
            MedicineAccess medicineAccess = new MedicineAccess();
            BillDataAccess billDataAccess = new BillDataAccess();
            List<string> companyNames = medicineAccess.GetCompanyNames().Distinct().ToList();
            TotalUnitLabel.Text = "Total Unit : " + Convert.ToString(medicineAccess.GetTotalMedicineUnit());
            totalCompanyLabel.Text = "Total Companies : "+ Convert.ToString(companyNames.Count);
            totalNetWorth.Text ="Total Net Worth : "+ Convert.ToString(medicineAccess.CalculateNetWorth());
            totalSellingPriceLabel.Text ="Total Selling Price :"+ Convert.ToString(billDataAccess.CalculateTotalSellingPrice());
            ProfitLabel.Text = "Profit/Loss : "+ Convert.ToString(billDataAccess.CalculateTotalProfit());
            totalUnitsSold.Text = medicineNameLabel.Text = companyNameLabel.Text = remainingUnitsLabel.Text = medicineProfitLabel.Text = "";
            companyNameLabel.Text = companyProfitLabel.Text = "";
            if (medicineAccess.GetMedicines() != null)
            { allMedicineDataGridView.DataSource = medicineAccess.GetMedicines();
                allMedicineDataGridView.Columns[7].Visible = allMedicineDataGridView.Columns[8].Visible =
                allMedicineDataGridView.Columns[9].Visible = allMedicineDataGridView.Columns[11].Visible = false;
            }
               
            else
                allMedicineDataGridView.DataSource = null;
        }

        private void medicineSearchButton_Click(object sender, EventArgs e)
        {
            if (medicineNameTextBox.Text == "")
            {
                MessageBox.Show("Please Enter A medicine Name to Search");
            }
            else
            {
                MedicineAccess medicineAccess = new MedicineAccess();
                Medicine medicine = new Medicine();
                if(medicineAccess.addMedicineToGridView(medicineNameTextBox.Text)!=null)
                {
                    medicine = medicineAccess.addMedicineToGridView(medicineNameTextBox.Text);
                    totalUnitsSold.Text = "Units Sold : " + Convert.ToString(medicineAccess.GetTotalMedicineSoldUnit(medicineNameLabel.Text));
                    medicineNameLabel.Text = "Medicine Name: " + medicine.MedicineName;
                    companyNameLabel.Text = "Company Name :" + medicine.MedicineCompanyName;
                    remainingUnitsLabel.Text = "Remaining Units : " + Convert.ToString(medicine.InitialQuantity - medicineAccess.GetTotalMedicineSoldUnit(medicine.MedicineName));
                    medicineProfitLabel.Text = "Total Profit : " + Convert.ToString(medicineAccess.GetTotalMedicineProfit(medicine.MedicineName));
                    medicineNameTextBox.Text = "";
                }
                else MessageBox.Show("Medicine Not Found");

            }
        }
        private void AdminSalesAndInventoryUserControl_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void medicineNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalUnitLabel_Click(object sender, EventArgs e)
        {

        }

        private void companyNameSearchButton_Click(object sender, EventArgs e)
        {
            MedicineAccess medicineAccess = new MedicineAccess();
            if (companyNameTextBox.Text == "")
            {
                MessageBox.Show("Please Enter A Company Name to Search");
            }
            else
            {

                if (medicineAccess.searchCompany(companyNameTextBox.Text))
                {
                    companyNameLabel.Text = "Name : " + companyNameTextBox.Text;
                    companyProfitLabel.Text = "Profit : " + Convert.ToString(medicineAccess.GetCompanyProfit(companyNameTextBox.Text));
                    companyNameTextBox.Text = "";
                }
                else MessageBox.Show("Company Doesn't Exist");


            }
        }
    }
}
