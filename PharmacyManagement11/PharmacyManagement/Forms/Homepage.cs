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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Login login = new Login();
        private void homeLoginButton_Click(object sender, EventArgs e)
        {
            
            login.Show();
            this.Hide();
            
        }

        private void homeExitButton_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.OKCancel);
            //if (result == DialogResult.OK)
            //{ Application.Exit(); }
            //else if (result == DialogResult.Cancel)
            //{
            //    return;
            //}
            Application.Exit();  //Remove later
        }

        private void Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

