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
    public partial class AdminIssueUserControl : UserControl
    {
        public AdminIssueUserControl()
        {
            InitializeComponent();
        }

        private void AdminIssueUserControl_Load(object sender, EventArgs e)
        {  
            AdminCreateIssuePanel.Visible = false;
            AdminCheckIssueStatusPanel.Visible = false;
            UpdateGridView();


        }
        void UpdateGridView()
        {
            IssueOperations issueOperations = new IssueOperations();
            if (issueOperations.GetAllIssues() != null)
            { adminAllIssuesDataGridView.DataSource = issueOperations.GetAllIssues();
                adminAllIssuesDataGridView.Columns[0].Visible = adminAllIssuesDataGridView.Columns[1].Visible = adminAllIssuesDataGridView.Columns[2].Visible = false;
            } 
            else adminAllIssuesDataGridView.DataSource = null;
        }

        private void AdminCreateIssueButton_Click(object sender, EventArgs e)
        {
            AdminCreateIssuePanel.Visible = true;
            AdminCheckIssueStatusPanel.Visible = false;
            WorkerDataAccess workerAccess = new WorkerDataAccess();
            adminIssueAssignByLabel.Text = "Admin";
           


        }

        private void issueSubmitButton_Click(object sender, EventArgs e)
        {
            workerIssueDataAccess wid = new workerIssueDataAccess();

            if (adminIssueNamesComboBox.Text == "")
            {
                MessageBox.Show("Please choose a recipent name");
            }
            else if (adminIssueRichTextBox1.Text == "")
            {

                MessageBox.Show("Can not send a blank message");

            }
            else if (adminIssueNamesComboBox.Text == adminIssueAssignByLabel.Text)
            {

                MessageBox.Show("Please choose a recipent name");

            }
            else
            {
                bool check = wid.CreateIssues("Admin", adminIssueNamesComboBox.Text, adminIssueRichTextBox1.Text, issuedateTimePicker.Text, "TO DO");
                if (check == true)
                {
                    MessageBox.Show(" Issue sent succesfully");
                    adminIssueNamesComboBox.Text = string.Empty;
                    adminIssueRichTextBox1.Text = string.Empty;
                    UpdateGridView();
                }
                else
                {
                    MessageBox.Show(" Issue could not sent for unknown reason");
                }
            }
        }

        private void AdminCreateIssuePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminIssueNamesComboBox_Click(object sender, EventArgs e)
        {
            WorkerDataAccess workerAccess = new WorkerDataAccess();
            adminIssueNamesComboBox.DataSource = workerAccess.GetWorkerNames();
        }

        private void adminAllIssuesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void adminIssueAssignByLabel_Click(object sender, EventArgs e)
        {

        }

        private void workerIssueStatusButton_Click(object sender, EventArgs e)
        {
            IssueCompletedLabel.Text = IssueCreatedLabel.Text = IssueAssignedToLabel.Text =issueFinderTextBox.Text= "";
            
            AdminCheckIssueStatusPanel.Visible = true;
            AdminCreateIssuePanel.Visible = false;
        }

        private void IssueStatusFindButton_Click(object sender, EventArgs e)
        {
            IssueOperations issueOperations = new IssueOperations();
            if (issueFinderTextBox.Text=="")
            { MessageBox.Show("Please Enter A Name"); }


           else
            {  if (issueOperations.GetIssuesAssignedBy(issueFinderTextBox.Text) == 0 && issueOperations.GetIssuesAssignedTo(issueFinderTextBox.Text) == 0 && issueOperations.GetIssuesCompleted(issueFinderTextBox.Text) == 0)
                { MessageBox.Show("Result Not Found"); }
                else
                {
                    IssueCreatedLabel.Text = "Issue Created : " + Convert.ToString(issueOperations.GetIssuesAssignedBy(issueFinderTextBox.Text));
                    IssueAssignedToLabel.Text = "Issue Assigned : " + Convert.ToString(issueOperations.GetIssuesAssignedTo(issueFinderTextBox.Text));
                    IssueCompletedLabel.Text = "Issue Completed : " + Convert.ToString(issueOperations.GetIssuesCompleted(issueFinderTextBox.Text));
                    issueFinderTextBox.Text = "";
                }  

            }
        }
        private void issueFinderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WorkerDataAccess workerAccess = new WorkerDataAccess();
            adminIssueNamesComboBox.DataSource = workerAccess.GetWorkerNames();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void workerNamesToFindComboBox_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
