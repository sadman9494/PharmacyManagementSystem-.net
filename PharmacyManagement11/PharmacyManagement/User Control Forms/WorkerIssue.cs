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
    public partial class WorkerIssue : UserControl
    {
        public int workerId;
        public WorkerIssue()
        {
            InitializeComponent();
        }

        public WorkerIssue(int id)
        {
            InitializeComponent();
            this.workerId = id;
            workerIssueAssignByLabel.Text = Convert.ToString(this.workerId); 
        }

        private void issueAssignByTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WorkerIssue_Load(object sender, EventArgs e)
        {
            WorkerDataAccess workerAccess = new WorkerDataAccess();
            
            workerIssueAssignByLabel.Text = workerAccess.GetWorkerName(this.workerId);
        }

        private void workerIssueComboBox_Click(object sender, EventArgs e)
        {
            WorkerDataAccess workerAccess = new WorkerDataAccess();
            workerIssueComboBox.DataSource = workerAccess.GetWorkerNames();
        }

        private void issueSubmitButton_Click(object sender, EventArgs e)
        {
            workerIssueDataAccess wid = new workerIssueDataAccess();

            if (workerIssueComboBox.Text == "")
            {
                MessageBox.Show("Please choose a recipent name");
            }
            else if (workerIssueRichTextBox1.Text == "")
            {

                MessageBox.Show("Can not send a blank message");

            }
            else if (workerIssueComboBox.Text == workerIssueAssignByLabel.Text)
            {

                MessageBox.Show("Please choose a recipent name");

            }


            else
            {
                bool check = wid.CreateIssues(workerIssueAssignByLabel.Text, workerIssueComboBox.Text, workerIssueRichTextBox1.Text, issuedateTimePicker.Text, "TO DO");
                if ( check == true )
                {
                    MessageBox.Show(" Issue sent succesfully");
                    workerIssueComboBox.Text = string.Empty;
                    workerIssueRichTextBox1.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show(" Issue could not sent for unknown reason");
                }
            }
             

            
        }

        private void workerIssueRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void issueGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
