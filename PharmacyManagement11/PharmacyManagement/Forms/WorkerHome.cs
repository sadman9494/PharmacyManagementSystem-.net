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
    public partial class WorkerHome : Form 
    {
    
        Worker worker = new Worker();
        public int workerHomeformID;

        public int WorkerHomeFormID
        {
            set { this.workerHomeformID = value; }
            get { return workerHomeformID; }
        }

        public WorkerHome()
        {
            InitializeComponent();
        }

        private void WorkerHome_Load(object sender, EventArgs e)
        {
            WorkerHomeUserControl workerHomeUserControl = new WorkerHomeUserControl();
            homeIdLabel.Text = Convert.ToString(this.workerHomeformID);
            workerHomeUserControl.homeId =this.workerHomeformID;
            WorkerHomePanel.Controls.Clear();
            WorkerHomePanel.Controls.Add(workerHomeUserControl);
        }

        private void WorkerHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
        }


       
        private void myProfileButton_Click(object sender, EventArgs e)
        {
            WorkerProfile workerProfile = new WorkerProfile();
            workerProfile.workerProfileId = this.WorkerHomeFormID;
            WorkerHomePanel.Controls.Clear();
            WorkerHomePanel.Controls.Add(workerProfile);
            
        }

        private void profileLoadButton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { }

        private void createBillButton_Click(object sender, EventArgs e)
        {
            MedicineBill medicineBills = new MedicineBill(this.WorkerHomeFormID);
            WorkerHomePanel.Controls.Clear();
            WorkerHomePanel.Controls.Add(medicineBills);

        }

        private void label1_Click(object sender, EventArgs e)
        {  }

        private void workerLogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void workerProfilePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void workerProfileUpdateButton_Click(object sender, EventArgs e)
        {
            //UpdateWorkerInfoPanel.Show();
        }

        private void profileMobileNoLabel_Click(object sender, EventArgs e)
        {

        }

        private void workerProfileFormExit_Click(object sender, EventArgs e)
        { // workerProfilePanel.Visible=false;
        }

        private void profileEmailLabel_Click(object sender, EventArgs e)
        {

        }

        private void homeIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void profileGenderLabel_Click(object sender, EventArgs e)
        {

        }

        private void updateInfoNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmUpdateButton_Click(object sender, EventArgs e)
        {
            bool check=false;
            
            WorkerDataAccess workerDataAccess = new WorkerDataAccess();
            WorkerOperations wop = new WorkerOperations();
         

        }

        private void profileAddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void updateInfoPreviousPassTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateInfoAgeTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void inventoryButton_Click(object sender, EventArgs e)
        { 
            WorkerInventory workerInventory = new WorkerInventory();
            workerInventory.workerInventoryId = this.WorkerHomeFormID;
            WorkerHomePanel.Controls.Clear();
            WorkerHomePanel.Controls.Add(workerInventory);
        }

        private void WorkerHomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void workerHomeSidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void InventoryCloseButton_Click(object sender, EventArgs e)
        {
            WorkerHomeUserControl workerHomeUserControl = new WorkerHomeUserControl();
            homeIdLabel.Text = Convert.ToString(this.workerHomeformID);
            workerHomeUserControl.homeId = this.workerHomeformID;
            WorkerHomePanel.Controls.Clear();
            WorkerHomePanel.Controls.Add(workerHomeUserControl); 
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void issueButton_Click(object sender, EventArgs e)
        {
            WorkerIssue workerIssues = new WorkerIssue(this.workerHomeformID);
            WorkerHomePanel.Controls.Clear();
            WorkerHomePanel.Controls.Add(workerIssues);

        }

        private void myIssueButton_Click(object sender, EventArgs e)
        {
            MyIssue myIssue = new MyIssue(this.workerHomeformID);
            WorkerHomePanel.Controls.Clear();
            WorkerHomePanel.Controls.Add(myIssue);
        }

        private void billHistoryButton_Click(object sender, EventArgs e)
        {
            BillHistory billHistory = new BillHistory();
            WorkerHomePanel.Controls.Clear();
            WorkerHomePanel.Controls.Add(billHistory);


        }
    }
}
