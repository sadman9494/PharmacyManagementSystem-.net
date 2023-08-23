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
    public partial class WorkerInventory : UserControl
    {
        public int workerInventoryId;
        public WorkerInventory()
        {
            InitializeComponent();
        }

        public WorkerInventory(int id)
        {
            InitializeComponent();
            this.workerInventoryId = id;
        }

        private void WorkerInventory_Load(object sender, EventArgs e)
        {
            UpdateGridView();
            MedicineAccess medicineAccess = new MedicineAccess();
            wInLabel.Text = Convert.ToString(this.workerInventoryId);
            addMedicinePanel.Visible = false;
            removeMedicinePanel.Visible = false;
            searchMedicinePanel.Visible = false;
            UpdateMedicineInfoPanel.Visible = false;
            


        }

        void UpdateGridView()
        {
            
            MedicineAccess medicineAccess = new MedicineAccess();
            inventoryDataGridView.DataSource = medicineAccess.GetMedicines();
            inventoryDataGridView.Rows[0].MinimumHeight = 30;
           inventoryDataGridView.Columns[7].Visible = inventoryDataGridView.Columns[8].Visible = inventoryDataGridView.Columns[9].Visible =
                 inventoryDataGridView.Columns[11].Visible = false;
        }
        private void workerInventoryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wpLabel_Click(object sender, EventArgs e)
        {

        }

        private void InventoryCloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addMedicineButton_Click(object sender, EventArgs e)
        {

            searchMedicinePanel.Visible = false;
            addMedicinePanel.Visible = true;
            removeMedicinePanel.Visible = false;
            UpdateMedicineInfoPanel.Visible = false;
            addMedicineNameTextBox.Text= addMedicineCompanyNameTextBox.Text = addMedicineBuyingPriceTextBox.Text = addMedicineSellingPriceTextBox.Text = addCategoryComboBox.Text =
            addMedicineQuantityTextBox.Text = addExpiringDate.Text = addMedicineDiscountTextBox.Text = "";

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void addMedicineConfirmButton_Click(object sender, EventArgs e)
        {
            addMedicinePanel.Visible = true;
            removeMedicinePanel.Visible = false;
            MedicineAccess medicineAccess = new MedicineAccess();
            MedicineOperations medicineOperations = new MedicineOperations();
            if (addMedicineNameTextBox.Text == "")
            {
                MessageBox.Show("Please add a medicine Name");
            }
            else if ( addMedicineCompanyNameTextBox.Text == "")
            {
            
                    MessageBox.Show("Please add a Company Name");
                
            }
            else if (addMedicineBuyingPriceTextBox.Text == "")
            {

                MessageBox.Show("Please add Price");

            }
            else if (addMedicineSellingPriceTextBox.Text == "")
            {

                MessageBox.Show("Please add a selling price");

            }
            else if (addCategoryComboBox.Text == "")
            {

                MessageBox.Show("Please select a catergory");

            }
            else if (addMedicineQuantityTextBox.Text == "")
            {

                MessageBox.Show("Please add a Quantity");

            }
            else if (addExpiringDate.Text == "")
            {

                MessageBox.Show("Please add an expiry date");

            }

            else
            
               
            
            {
                if (addMedicineDiscountTextBox.Text =="")
                {
                    addMedicineDiscountTextBox.Text = "0";
                }

                bool check = medicineAccess.InsertMedicine(addMedicineNameTextBox.Text, addMedicineCompanyNameTextBox.Text, addCategoryComboBox.Text,
                    Convert.ToDouble(addMedicineBuyingPriceTextBox.Text), Convert.ToDouble(addMedicineSellingPriceTextBox.Text), Convert.ToInt32(addMedicineQuantityTextBox.Text), addExpiringDate.Text, Convert.ToDouble(addMedicineDiscountTextBox.Text));
                
                if (check == true)
                {
                    MessageBox.Show("Medicine Inserted Successfully");
                    addMedicinePanel.Visible = false;
                    removeMedicinePanel.Visible = false;
                    UpdateGridView();

                }
                else
                {
                    MessageBox.Show("Medicine Could not Insert");

                } 
            }
        }

        private void removeMedicineButton_Click(object sender, EventArgs e)
        {
            searchMedicinePanel.Visible = false;
            addMedicinePanel.Visible = false;
            removeMedicinePanel.Visible = true;
            UpdateMedicineInfoPanel.Visible = false;
            removeMedicineMedicineNamesComboBox.Text = removeMedicineCategoryComboBox.Text = "";
        }

        private void confirmDeleteMedicineButton_Click(object sender, EventArgs e)
        {
            MedicineOperations medicineOperations = new MedicineOperations();
            MedicineAccess medicineAccess = new MedicineAccess();
           if(removeMedicineCategoryComboBox.Text == "")
            { MessageBox.Show("Please Choose a Category"); }
          else  if (removeMedicineMedicineNamesComboBox.Text == "")
            { MessageBox.Show("Please Choose a Medicine"); }
           else
            {
               if( medicineAccess.DeleteMedicine(removeMedicineMedicineNamesComboBox.Text, removeMedicineCategoryComboBox.Text))
                { MessageBox.Show("Medicine Deleted Successfully");
                    UpdateGridView();}
                else MessageBox.Show("Medicine Not Deleted");
                removeMedicinePanel.Visible = false;
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addMedicineNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void removeMedicineCategoryComboBox_TextChanged(object sender, EventArgs e)
        {
            MedicineOperations medicineOperations = new MedicineOperations();
            MedicineAccess medicineAccess = new MedicineAccess();
            if (medicineOperations.getMedicineNames(removeMedicineCategoryComboBox.Text) != null)
            { removeMedicineMedicineNamesComboBox.DataSource = medicineOperations.getMedicineNames(removeMedicineCategoryComboBox.Text); }
            else
            {  removeMedicineMedicineNamesComboBox.Text = "";
            }



        }
        private void removeMedicineCategoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addMedicineDiscountTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addExpiringDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void searchMedicineButton_Click(object sender, EventArgs e)
        {
            medicineNameLabel.Text = companyNameLabel.Text = priceLabel.Text = categoryLabel.Text = ExpiringDateLabel.Text = remainingUnitsLabel.Text = totalMedicineProfit.Text = ""; 
            searchMedicinePanel.Visible = true;
            addMedicinePanel.Visible = false;
            removeMedicinePanel.Visible = false;
            UpdateMedicineInfoPanel.Visible = false;

        }

        private void medicineSearchButton_Click(object sender, EventArgs e)
        {
            searchMedicinePanel.Visible = true;
            MedicineOperations medicineOperations = new MedicineOperations();
            MedicineAccess medicineAccess = new MedicineAccess();
            Medicine medicine = new Medicine();
            if (searchMedicineTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Medicine Name to Search");
            }
            else
            {
                medicine = medicineAccess.addMedicineToGridView(searchMedicineTextBox.Text);
                medicineNameLabel.Text = "Medicine Name: "+medicine.MedicineName;
                companyNameLabel.Text = "Company Name :"+medicine.MedicineCompanyName;
                priceLabel.Text = "Price: "+Convert.ToString(medicine.SellingPrice);
                categoryLabel.Text = "Category : "+ medicine.MedicineCategory;
                ExpiringDateLabel.Text = "Expiring Date :"+ medicine.ExpiringDate;
                remainingUnitsLabel.Text = "Remaining Units : "+Convert.ToString(medicine.InitialQuantity - medicineAccess.GetTotalMedicineSoldUnit(medicine.MedicineName));
                totalMedicineProfit.Text = "Total Profit : " + Convert.ToString(medicineAccess.GetTotalMedicineProfit(medicine.MedicineName));
            }
        }

        private void searchMedicinePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void removeMedicinePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void medicineInfoUpdateButton_Click(object sender, EventArgs e)
        {
            updateMedicineIdTextBox.Text = updateMedicineQuantityTextBox.Text = updateMedicineExpDateTextBox.Text = updateMedicineDiscountTextBox.Text = 
            updateMedicineSellingPriceTextBox.Text = "";
            searchMedicinePanel.Visible = false;
            addMedicinePanel.Visible = false;
            removeMedicinePanel.Visible = false;
            UpdateMedicineInfoPanel.Visible = true;
        }

        private void confirmUpdateMedInfoButton_Click(object sender, EventArgs e)
        {
            if(updateMedicineIdTextBox.Text=="")
            { MessageBox.Show("Please Enter Medicine ID"); }
           else  if (updateMedicineQuantityTextBox.Text == "" && updateMedicineSellingPriceTextBox.Text=="" && updateMedicineExpDateTextBox.Text=="" && updateMedicineDiscountTextBox.Text=="")
            { MessageBox.Show("Please Enter Any Values To Update"); }
            else
            { bool check = false;
                MedicineAccess medicineAccess = new MedicineAccess();
                if(updateMedicineQuantityTextBox.Text!="")
                {
                    int quantity = medicineAccess.GetQuantity(Convert.ToInt32(updateMedicineIdTextBox.Text));
                    if(medicineAccess.UpdateMedicineQuantity(Convert.ToInt32(updateMedicineIdTextBox.Text), quantity+ Convert.ToInt32(updateMedicineQuantityTextBox.Text)))
                    { check = true; }
                }

              if (updateMedicineSellingPriceTextBox.Text != "")
                {
                    if (medicineAccess.UpdateMedicineSellingPrice(Convert.ToInt32(updateMedicineIdTextBox.Text), Convert.ToDouble(updateMedicineSellingPriceTextBox.Text)))
                    { check = true; }
                }

                if (updateMedicineExpDateTextBox.Text != "")
                {
                    if (medicineAccess.UpdateMedicineExpDate(Convert.ToInt32(updateMedicineIdTextBox.Text), updateMedicineExpDateTextBox.Text))
                    { check = true; }
                }
                if (updateMedicineDiscountTextBox.Text != "")
                {
                    if (medicineAccess.UpdateMedicineDiscount(Convert.ToInt32(updateMedicineIdTextBox.Text), Convert.ToDouble(updateMedicineDiscountTextBox.Text)))
                    { check = true; }
                }

                if(check)
                { MessageBox.Show("Information Updated Successfully");
                    UpdateGridView();
                    UpdateMedicineInfoPanel.Visible = false;
                }
                else MessageBox.Show("Information Did Not Update Properly");

            }
        }

        private void UpdateMedicineInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
