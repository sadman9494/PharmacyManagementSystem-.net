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
    public partial class Login : Form
    {
       Worker worker = new Worker(); 

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }






        private void loginButton_Click(object sender, EventArgs e)
        {
            

            if (chooseTypeComboBox.Text == "")
            {
                MessageBox.Show("Please Choose a Type");
            }
            else if (idTextBox.Text == "")
            { MessageBox.Show("Please Enter an ID"); }
            else if (passwordTextBox.Text == "")
            { MessageBox.Show("Please Enter a Password"); }


            else if (chooseTypeComboBox.Text == "Admin") // Admin Login
            {
                string str1 = idTextBox.Text;
                bool check1 = true;

                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] >= 'a' && str1[i] <= 'z' || str1[i] >= 'A' && str1[i] <= 'Z')
                    {
                        check1 = false;
                        break;
                    }
                }

                if (check1 != false && passwordTextBox.Text == "123" && idTextBox.Text == "123")
                {


                    AdminHome adminHome = new AdminHome();
                    adminHome.Show();
                    this.Hide();

                }
                else if (check1 == false)
                {
                    passwordTextBox.Text = ""; idTextBox.Text = ""; MessageBox.Show("Not A proper ID !");
                }

                else {
                   
                    passwordTextBox.Text = ""; idTextBox.Text = "";
                    MessageBox.Show("Incorrect ID or Password"); }

            }

            else  // Worker Login
            {
                string str2 = idTextBox.Text;
                bool check2 = true;

                for (int i = 0; i < str2.Length; i++)
                {
                    if (str2[i] >= 'a' && str2[i] <= 'z' || str2[i] >= 'A' && str2[i] <= 'Z')
                    {
                        check2 = false;
                        break;
                    }
                }

               
                if (check2 == false)
                {
                    passwordTextBox.Text = ""; idTextBox.Text = "";
                    MessageBox.Show("Not A proper ID !");
                }
               

               else 
                   
                { 
                    WorkerDataAccess workerDataAccess = new WorkerDataAccess();
                    WorkerHome workerHome = new WorkerHome(); // regular
                     //user control

                    worker = workerDataAccess.ValidateLogin(Convert.ToInt32(idTextBox.Text), passwordTextBox.Text);
                    if (worker!=null)
                    {
                       
                        WorkerProfile workerProfile = new WorkerProfile(Convert.ToInt32(idTextBox.Text));
                        workerHome.workerHomeformID = Convert.ToInt32(idTextBox.Text); //
                        
                        workerHome.Show();
                        this.Hide();
                       
                    }
                    else
                    {
                        MessageBox.Show("Incorrect ID or Password");
                    }
                }
                 
               

            }
        }

            private void titleLbl_Click(object sender, EventArgs e)
            {

            }

            private void chooseTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
            {


            }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Homepage homepage = new Homepage();
            homepage.Show();
            this.Close();
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

