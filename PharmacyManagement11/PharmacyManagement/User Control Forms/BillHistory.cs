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
    public partial class BillHistory : UserControl
    {
        public BillHistory()
        {
            InitializeComponent();
        }

        private void BillHistory_Load(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            BillOperations bop = new BillOperations();
            billHistoryGridView.DataSource = bop.BillHistory();
            
            billHistoryGridView.Rows[0].MinimumHeight = 30;
            billHistoryGridView.Columns[1].Visible = billHistoryGridView.Columns[11].Visible = billHistoryGridView.Columns[12].Visible = billHistoryGridView.Columns[13].Visible =
                billHistoryGridView.Columns[14].Visible = billHistoryGridView.Columns[15].Visible = billHistoryGridView.Columns[16].Visible = billHistoryGridView.Columns[17].Visible =
                billHistoryGridView.Columns[18].Visible = billHistoryGridView.Columns[19].Visible = billHistoryGridView.Columns[20].Visible = billHistoryGridView.Columns[21].Visible =
                billHistoryGridView.Columns[22].Visible = billHistoryGridView.Columns[23].Visible = false;

        }
    }
}
