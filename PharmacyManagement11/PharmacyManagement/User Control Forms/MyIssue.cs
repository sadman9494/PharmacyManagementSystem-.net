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
    public partial class MyIssue : UserControl
    {
        int myid;
        public MyIssue()
        {
            InitializeComponent();
        }

        public MyIssue(int id)
        {
            InitializeComponent();
            this.myid = id;


        }

        private void MyIssue_Load(object sender, EventArgs e)
        {

            UpdateGridView();
        }

        void UpdateGridView()
        {

            workerIssueDataAccess workerIssue = new workerIssueDataAccess();
            IssueOperations WIO = new IssueOperations();
            string name = (workerIssue.GetName(this.myid).IssueAssignedTo);
            myIssueDataGridView.DataSource = WIO.Getissues(name);
            myIssueDataGridView.Columns[1].Visible = myIssueDataGridView.Columns[2].Visible = myIssueDataGridView.Columns[3].Visible
                = myIssueDataGridView.Columns[5].Visible = myIssueDataGridView.Columns[6].Visible = false;
            IssuePanel.Visible = false;
        }
        private void myIssueDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void myIssueDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
       

            IssuePanel.Visible = true;
            IssueTextBox.Text = myIssueDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            IssueIdLabel.Text = myIssueDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
            assignByLabel.Text = myIssueDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void issueUpdateDoneButton_Click(object sender, EventArgs e)
        {
            IssueOperations issueOperations = new IssueOperations();
            if(issueOperations.UpdateIssueStatus(Convert.ToInt32(IssueIdLabel.Text), "Done"))
            {
                MessageBox.Show("Issue Status Updated");
                UpdateGridView();
            }
            else MessageBox.Show("Issue Status Not Updated");
        }
    }
}
