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
    public partial class WorkerProfile : UserControl
    {
        public int workerProfileId;
        Worker worker = new Worker();
        public WorkerProfile()
        {
            InitializeComponent();  
        }

        public WorkerProfile(int id)
        {   InitializeComponent();
            this.workerProfileId = id;
        }
        public int WorkerProfileID
        {
            set { this.workerProfileId = value; }
            get { return workerProfileId; }
        }

        private void WorkerProfile_Load(object sender, EventArgs e)
        { 
            UpdateWorkerInfoPanel.Visible =false;
            updateProfileRefreshButton.Enabled = false;
            WorkerOperations wop = new WorkerOperations();
            wpLabel.Text = Convert.ToString(this.workerProfileId);
            workerPerformancePanel.Visible = false;

            //WorkerOperations workerOperations = new WorkerOperations();
            if (wop.GetWorkerBillInfo(this.workerProfileId) !=null)
            {
                workerSaleInfoDataGridView.DataSource = wop.GetWorkerBillInfo(this.workerProfileId);
                workerSaleInfoDataGridView.Columns[4].Visible = workerSaleInfoDataGridView.Columns[5].Visible = workerSaleInfoDataGridView.Columns[6].Visible =
                workerSaleInfoDataGridView.Columns[7].Visible = workerSaleInfoDataGridView.Columns[8].Visible = workerSaleInfoDataGridView.Columns[9].Visible =
                workerSaleInfoDataGridView.Columns[10].Visible = workerSaleInfoDataGridView.Columns[11].Visible = workerSaleInfoDataGridView.Columns[12].Visible =
                workerSaleInfoDataGridView.Columns[13].Visible = workerSaleInfoDataGridView.Columns[14].Visible = false;
            }
            else workerSaleInfoDataGridView.DataSource =null;


            worker = wop.insertWorkerInfo(this.WorkerProfileID);
            if (worker != null)
            {
                profileIdLabel.Text = "ID :  " + worker.WorkerId;
                profileMobileNoLabel.Text = "Mobile No :  " + worker.WorkerMobileNo;
                profileAgeLabel.Text = "Age :  " + worker.WorkerAge;
                profileEmailLabel.Text = "Email :  " + worker.WorkerEmail;
                profileSalaryLabel.Text = "Salary :  " + worker.WorkerSalary;
                profileGenderLabel.Text = "Gender :  " + worker.WorkerGender;
                profileNameLabel.Text = "Name :  " + worker.WorkerName;
                profileAddressLabel.Text = "Address :  " + worker.WorkerAddress;

            }
            else MessageBox.Show("Can't Load Info");
        }
        private void workerProfileUpdateButton_Click(object sender, EventArgs e)
        {
            UpdateWorkerInfoPanel.Visible = true;
            updateInfoAddressTextBox.Text = updateInfoAgeTextbox.Text = updateInfoConfirmPassTextBox.Text = updateInfoNameTextBox.Text = updateInfoPreviousPassTextBox.Text = updateInfoNewPassBox.Text =
                            updateInfoMobileTextBox.Text = updateInfoEmailTextBox.Text = "";
           updateInfoMaleRadioButton.Checked= updateInfoFemaleRadioButton.Checked = false;
            workerProfileUpdateButton.Enabled = false;
          
        }

        private void ConfirmUpdateButton_Click(object sender, EventArgs e)
        {
            UpdateWorkerInfoPanel.Visible = true;
            workerProfileUpdateButton.Enabled = true;
            updateProfileRefreshButton.Enabled = false;
            bool check = false;
            WorkerDataAccess workerDataAccess = new WorkerDataAccess();
            WorkerOperations wop = new WorkerOperations();
            if (updateInfoAddressTextBox.Text != "")
            {
                if (workerDataAccess.UpdateAddress(updateInfoAddressTextBox.Text, this.workerProfileId))
                { check = true; }
                else check = false;

            }

            if (updateInfoEmailTextBox.Text != "")
            {
                if (workerDataAccess.UpdateEmail(updateInfoEmailTextBox.Text, this.workerProfileId))
                { check = true; }
                else check = false;
            }

            if (updateInfoMobileTextBox.Text != "")
            {
                if (workerDataAccess.UpdateMobileNo(updateInfoMobileTextBox.Text, this.workerProfileId))
                { check = true; }
                else check = false;
            }

            if (updateInfoNameTextBox.Text != "")
            {
                if (workerDataAccess.UpdateName(updateInfoNameTextBox.Text, this.workerProfileId))
                { check = true; }
                else check = false;
            }
            if (updateInfoAgeTextbox.Text != "")
            {
                if (workerDataAccess.UpdateAge(Convert.ToInt32(updateInfoAgeTextbox.Text), this.workerProfileId))
                { check = true; }
                else check = false;
            }
            if (updateInfoMaleRadioButton.Checked == true || updateInfoFemaleRadioButton.Checked == true)
            {
                if (updateInfoMaleRadioButton.Checked)
                {
                    if (workerDataAccess.UpdateGender("Male", this.workerProfileId))
                    { check = true; }
                    else check = false;
                }

                else if (updateInfoFemaleRadioButton.Checked)
                {
                    if (workerDataAccess.UpdateGender("Female", this.workerProfileId))
                    { check = true; }
                    else check = false;
                }

            }
            if(updateInfoPreviousPassTextBox.Text != "")
             
            {
                WorkerOperations workerOperations = new WorkerOperations();
                Worker worker = new Worker();
                worker= workerOperations.insertWorkerInfo(this.workerProfileId);
                if(updateInfoPreviousPassTextBox.Text== worker.WorkerPassword)
                {
                    if (updateInfoNewPassBox.Text == updateInfoConfirmPassTextBox.Text)
                    {
                        if (workerDataAccess.UpdatePassword(updateInfoConfirmPassTextBox.Text, this.workerProfileId))
                        {
                            MessageBox.Show("Password Updated Successfully");
                            check = true;
                        }
                        else MessageBox.Show("Password Did Not Update");
                    }
                    else MessageBox.Show("New And Confirm Passwords Do not Match");
                }
                else MessageBox.Show("Previous Password Not Matched");
            }
           

            if (updateInfoPreviousPassTextBox.Text == "" && (updateInfoConfirmPassTextBox.Text != "" || updateInfoConfirmPassTextBox.Text != ""))
            {
                MessageBox.Show("Please Enter Previous Password");
            }

            if (check)
            { MessageBox.Show("Information Updated");
                UpdateWorkerInfoPanel.Visible = false;
                updateProfileRefreshButton.Enabled = true;
            }
            else MessageBox.Show("Please Enter Values To Update"); 
            
            }

        private void workerProfileFormExit_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void updateProfileRefreshButton_Click(object sender, EventArgs e)
        {
            workerProfileUpdateButton.Enabled = true;
            WorkerOperations wop = new WorkerOperations();
            wpLabel.Text = Convert.ToString(this.workerProfileId);

            worker = wop.insertWorkerInfo(this.WorkerProfileID);
            if (worker != null)
            {
                profileIdLabel.Text = "ID :  " + worker.WorkerId;
                profileMobileNoLabel.Text = "Mobile No :  " + worker.WorkerMobileNo;
                profileAgeLabel.Text = "Age :  " + worker.WorkerAge;
                profileEmailLabel.Text = "Email :  " + worker.WorkerEmail;
                profileSalaryLabel.Text = "Salary :  " + worker.WorkerSalary;
                profileGenderLabel.Text = "Gender :  " + worker.WorkerGender;
                profileNameLabel.Text = "Name :  " + worker.WorkerName;
                profileAddressLabel.Text = "Address :  " + worker.WorkerAddress;

            }
            else MessageBox.Show("Can't Load Info");
        }

        private void workerProfilePanel_Load(object sender, EventArgs e)
        {

        }

        private void workerProfilePanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void profileMobileNoLabel_Click(object sender, EventArgs e)
        {

        }

        private void profileEmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void updateInfoMaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MyProfileLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void totalSoldProductsLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalProfitAndUnitCalculationButton_Click(object sender, EventArgs e)
        {
            workerPerformancePanel.Visible = true;
            totalUnitsSoldLabel.Text = totalProfitMadeLabel.Text =totalBillsMade.Text= "0";
            for (int i=0;i<workerSaleInfoDataGridView.Rows.Count; i++)
            {
                totalProfitMadeLabel.Text = Convert.ToString(double.Parse(totalProfitMadeLabel.Text) + double.Parse(workerSaleInfoDataGridView.Rows[i].Cells[1].Value.ToString()));
            }

            for (int i = 0; i < workerSaleInfoDataGridView.Rows.Count; i++)
            {
            totalUnitsSoldLabel.Text = Convert.ToString(double.Parse(totalUnitsSoldLabel.Text) + double.Parse(workerSaleInfoDataGridView.Rows[i].Cells[3].Value.ToString()));
            }

            for (int i = 0; i < workerSaleInfoDataGridView.Rows.Count; i++)
            {
                totalBillsMade.Text = Convert.ToString(i+1);
            }
        }

        private void totalProfitMadeLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void wpLabel_Click(object sender, EventArgs e)
        {

        }

        private void workerPerformancePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancelUpdateButton_Click(object sender, EventArgs e)
        {
            UpdateWorkerInfoPanel.Visible = false;
            workerProfileUpdateButton.Enabled = true;
            updateProfileRefreshButton.Enabled = true;
        }
    }
}
