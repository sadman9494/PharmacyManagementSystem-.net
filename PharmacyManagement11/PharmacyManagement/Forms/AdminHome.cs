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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

            AdminHomeUserControl adminHomeUserControl = new AdminHomeUserControl();     
            AdminHomePanel.Controls.Clear();
            AdminHomePanel.Controls.Add(adminHomeUserControl);
        }

        private void AdminHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
           
        }

    

       

        private void workerHomeSideBarLabel_Click(object sender, EventArgs e)
        {

        }

        private void WorkerPanelClearButton_Click(object sender, EventArgs e)
        {
            AdminHomeUserControl adminHomeUserControl = new AdminHomeUserControl();
            AdminHomePanel.Controls.Clear();
            AdminHomePanel.Controls.Add(adminHomeUserControl);
        }

        private void workerLogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void manageEmployeeButton_Click(object sender, EventArgs e)
        {
            AdminManageEmployees manageEmployees = new AdminManageEmployees();
            AdminHomePanel.Controls.Clear();
            AdminHomePanel.Controls.Add(manageEmployees);
        }

        private void AdminHomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void adminIssuesButton_Click(object sender, EventArgs e)
        {
   
            AdminIssueUserControl adminIssue = new AdminIssueUserControl();
            AdminHomePanel.Controls.Clear();
            AdminHomePanel.Controls.Add(adminIssue);
        }

        private void billHistoryButton_Click(object sender, EventArgs e)
        {
            AdminBillHistory adminBillHistory = new AdminBillHistory();
            AdminHomePanel.Controls.Clear();
            AdminHomePanel.Controls.Add(adminBillHistory);
        }

        private void salesAndInventoryButton_Click(object sender, EventArgs e)
        {
            AdminSalesAndInventoryUserControl adminSalesAndInventory = new AdminSalesAndInventoryUserControl();
            AdminHomePanel.Controls.Clear();
            AdminHomePanel.Controls.Add(adminSalesAndInventory);
        }
    }
}
