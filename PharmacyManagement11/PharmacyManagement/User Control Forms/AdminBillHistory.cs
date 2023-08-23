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
    public partial class AdminBillHistory : UserControl
    {
        public AdminBillHistory()
        {
            InitializeComponent();
        }

        private void AdminBillHistory_Load(object sender, EventArgs e)
        {
            BillOperations bop = new BillOperations();
            adminBillHistoryGridView.DataSource = bop.AdminBillHistory();
            adminBillHistoryGridView.Rows[0].MinimumHeight = 40;
            adminBillHistoryGridView.Columns[1].Visible = adminBillHistoryGridView.Columns[11].Visible = adminBillHistoryGridView.Columns[12].Visible = adminBillHistoryGridView.Columns[13].Visible =
                adminBillHistoryGridView.Columns[14].Visible = adminBillHistoryGridView.Columns[15].Visible = adminBillHistoryGridView.Columns[16].Visible = adminBillHistoryGridView.Columns[17].Visible =
                adminBillHistoryGridView.Columns[18].Visible = adminBillHistoryGridView.Columns[19].Visible = adminBillHistoryGridView.Columns[20].Visible = adminBillHistoryGridView.Columns[21].Visible =
               adminBillHistoryGridView.Columns[22].Visible = adminBillHistoryGridView.Columns[23].Visible = false;
        }
    }
}
