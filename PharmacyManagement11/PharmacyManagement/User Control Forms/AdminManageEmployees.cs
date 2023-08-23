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
    public partial class AdminManageEmployees : UserControl
    {
        public AdminManageEmployees()
        {
            InitializeComponent();
        }

        private void AdminManageEmployees_Load(object sender, EventArgs e)
        {
            UpdateGridView();
            addWorkerPanel.Visible = removeEmployeePanel.Visible =updateSalaryPanel.Visible=false;
           

        }

        void UpdateGridView()
        {
            AdminDataAccess adminDataAccess = new AdminDataAccess();
            if (adminDataAccess.GetWorkers() != null)
            {
                workerInfoDataGridView.DataSource = adminDataAccess.GetWorkers();
                workerInfoDataGridView.Rows[0].MinimumHeight = 30;
                workerInfoDataGridView.Columns[0].Visible = workerInfoDataGridView.Columns[1].Visible = workerInfoDataGridView.Columns[2].Visible =
                  workerInfoDataGridView.Columns[3].Visible = workerInfoDataGridView.Columns[5].Visible = 
                workerInfoDataGridView.Columns[13].Visible = workerInfoDataGridView.Columns[14].Visible = false;



            }
           else workerInfoDataGridView.DataSource = null;


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addEmployeesButton_Click(object sender, EventArgs e)
        {

            addWorkerPanel.Visible = true;
            removeEmployeePanel.Visible = false;
            updateSalaryPanel.Visible = false;
            workerNameTextBox.Text = workerPasswordTextBox.Text = "";

        }

        private void addMedicinePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addEmployeePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void chooseEmpTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void doctorConfirmAddButton_Click(object sender, EventArgs e)
        {
            

        }

        private void workerConfirmAddButton_Click(object sender, EventArgs e)
        {   
          
        }

        private void workerPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmAddWorkerButton_Click(object sender, EventArgs e)
        {
            if (workerNameTextBox.Text == "")
            { MessageBox.Show("Enter Worker Name "); }
            else if (workerPasswordTextBox.Text == "")
            { MessageBox.Show("Enter A Temporary Password "); }

            else
            {
                AdminDataAccess adminDataAccess = new AdminDataAccess();
                if (adminDataAccess.InsertWorkerIntoWorkerInfo(workerNameTextBox.Text,workerPasswordTextBox.Text))
                {
                   
                   MessageBox.Show("Worker Inserted Successfully ");
                        removeEmployeePanel.Visible = false;
                        addWorkerPanel.Visible = false;
                        UpdateGridView();
                }
                 else MessageBox.Show("Could Not Insert Worker");

            }

        }

        private void confirmRemoveButton_Click(object sender, EventArgs e)
        {
            AdminDataAccess adminDataAccess = new AdminDataAccess();

            {
                if (removeEmployeeIdTextBox.Text == "")
                { MessageBox.Show("Please Enter An ID"); }

                {
                    if (adminDataAccess.removeWorkerFromWorkerInfo(Convert.ToInt32(removeEmployeeIdTextBox.Text)))

                    {
                        UpdateGridView();
                        MessageBox.Show("Worker Removed");

                        removeEmployeePanel.Visible = false;
                        addWorkerPanel.Visible = false;
                        updateSalaryPanel.Visible = false;

                    }
                    else MessageBox.Show("Worker Did Not Remove");
                }
            }
        }



        private void RemoveEmployeesButton_Click(object sender, EventArgs e)
        {
            removeEmployeePanel.Visible = true;
            updateSalaryPanel.Visible = false;
            addWorkerPanel.Visible = false;
            removeEmployeeIdTextBox.Text = "";
        }

        private void workerInfoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateSalaryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void confirmUpdateSalaryButton_Click(object sender, EventArgs e)
        {
            AdminDataAccess adminDataAccess = new AdminDataAccess();
            if(salaryUpdateIdTextBox.Text=="")
            { MessageBox.Show("Please Enter An ID"); }

           else  if (salaryUpdateNewSalaryTextBox.Text == "")
            { MessageBox.Show("Please Enter A New Salary"); }
            else
            {
                if(adminDataAccess.UpdateWorkerSalary(Convert.ToInt32(salaryUpdateIdTextBox.Text), Convert.ToDouble(salaryUpdateNewSalaryTextBox.Text)))
                {
                    MessageBox.Show("Salary Updated Successfully");
                    UpdateGridView();
                    removeEmployeePanel.Visible = false;
                    addWorkerPanel.Visible = false;
                    updateSalaryPanel.Visible = false;
                }
                else MessageBox.Show("Salary Did Not Update");
                

            }

        }

        private void updateSalaryButton_Click(object sender, EventArgs e)
        {
            removeEmployeePanel.Visible = false;
            updateSalaryPanel.Visible = true;
            addWorkerPanel.Visible = false;
            salaryUpdateIdTextBox.Text = salaryUpdateNewSalaryTextBox.Text ="";
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
