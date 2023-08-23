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
    public partial class MedicineBill : UserControl
    {


        DataTable table = new DataTable("table");
        int Index;
        int medicineBillWorkerId;
        public MedicineBill()
        {
            InitializeComponent();
        }
        public MedicineBill(int id)
        {
            InitializeComponent();
            this.medicineBillWorkerId = id;
        }

        void UpdateNetTotal()
        {
            billNetTotalTextBox.Text = "0";

            for (int i = 0; i < billDataGridView.Rows.Count-1; i++)
            {
                billNetTotalTextBox.Text = Convert.ToString(double.Parse(billNetTotalTextBox.Text) + double.Parse(billDataGridView.Rows[i].Cells[6].Value.ToString()));
            }
        }

        public bool validatecustomer(string a)
        {
            string str1 = a;
            //bool check1 = true;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] >= '0' && str1[i] <= '9')
                {
                    return false;
                    break;
                }


            }

            return true;
        }


        private void MedicineBill_Load(object sender, EventArgs e)
        {
            UpdateNetTotal();
            BillDataAccess billDataAccess = new BillDataAccess();
            WorkerDataAccess workerDataAccess = new WorkerDataAccess();

            table.Columns.Add("Bill Id", Type.GetType("System.Int32"));
            table.Columns.Add("Product Name", Type.GetType("System.String"));
            table.Columns.Add("Product Price", Type.GetType("System.Double"));
            table.Columns.Add("Product Quantity", Type.GetType("System.Int32"));
            table.Columns.Add("Product Discount", Type.GetType("System.Double"));
            table.Columns.Add("Company Name", Type.GetType("System.String"));
            table.Columns.Add("Total Amount", Type.GetType("System.Double"));
            table.Columns.Add("Customer Name", Type.GetType("System.String"));
            table.Columns.Add("Seller Id", Type.GetType("System.Int32"));
            table.Columns.Add("Bill Date", Type.GetType("System.String"));

            billSellerIdLabel.Text = Convert.ToString(medicineBillWorkerId);
            billIdTextBox.Text =
            Convert.ToString(this.medicineBillWorkerId) + "0000" + Convert.ToString(workerDataAccess.GetTotalBillsMade(this.medicineBillWorkerId));

            //table.Columns.Add("Purchase Status", Type.GetType("System.String"));
            //table.Columns.Add("Action", Type.GetType(System.Button));
            billDataGridView.DataSource = table;
            billNetTotalTextBox.Text = "0";

        }

        private void billProductLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void billDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void billProductNameTextBox_TextChanged(object sender, EventArgs e)
        {


        }



        private void billLoadProductButton_Click(object sender, EventArgs e)
        {
            MedicineAccess medicineAccess = new MedicineAccess();
            Medicine medicine = new Medicine();
            if (billProductNameTextBox.Text == "" || billProductQuantityTextBox.Text == "")
            { MessageBox.Show("Please Enter Product Name Or Quantity!"); }
            else
            {
                string str2 = billProductQuantityTextBox.Text;
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

                    MessageBox.Show("Please Enter A number in Quantity !");
                    billProductQuantityTextBox.Text = "";
                }
                else {

                    medicine = medicineAccess.addMedicineToGridView(billProductNameTextBox.Text);
                    if (medicine != null)
                    {
                        billProductPriceTextBox.Text = Convert.ToString(medicine.SellingPrice);
                        billDiscountTextBox.Text = Convert.ToString(medicine.Discount);
                        billCompanyNameTextBox.Text = Convert.ToString(medicine.MedicineCompanyName);
                        billProductTotalAmountTextBox.Text = Convert.ToString((Convert.ToInt32(billProductQuantityTextBox.Text) * medicine.SellingPrice) - ((medicine.Discount / 100) * (Convert.ToInt32(billProductQuantityTextBox.Text) * medicine.SellingPrice)));
                        billProfitLabel.Text = Convert.ToString(Convert.ToDouble(billProductTotalAmountTextBox.Text) - Convert.ToInt32(billProductQuantityTextBox.Text) * medicine.BuyingPrice);

                    }
                    else
                        MessageBox.Show("Could not work ");



                }

               
            }
        }

        private void billAddingButton_Click(object sender, EventArgs e)
        {
            
            MedicineAccess medicineAccess = new MedicineAccess();
            
            if(billProductNameTextBox.Text=="")
                { MessageBox.Show("Enter Medicine Name"); }
            else if (billProductQuantityTextBox.Text == "")
            {
                MessageBox.Show("Enter Medicine Quantity");
            }

            else if (billCustomerNameTextBox.Text == "")
            {
                MessageBox.Show("Enter Customer Name");
            }

            else if(validatecustomer(billCustomerNameTextBox.Text)!=true)
            {
                MessageBox.Show("Name Cant't Contain a Number");
            }

            else

            {
                if (medicineAccess.GetMedicineName(billProductNameTextBox.Text))

                {  string str2= billProductQuantityTextBox.Text;
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
                       
                        MessageBox.Show("Please Enter A number in Quantity !");
                        billProductQuantityTextBox.Text = "";
                    }

                    else if (check2==true)
                    { 
                        if(medicineAccess.GetMedicineQuantityByName(billProductNameTextBox.Text) > Convert.ToInt32(billProductQuantityTextBox.Text))
                        {
                            MessageBox.Show("Product Added");

                            billNetTotalTextBox.Text =
                            Convert.ToString(Convert.ToDouble(billNetTotalTextBox.Text) + Convert.ToDouble(billProductTotalAmountTextBox.Text));

                            table.Rows.Add(Convert.ToInt32(billIdTextBox.Text), billProductNameTextBox.Text,
                            Convert.ToDouble(billProductPriceTextBox.Text), Convert.ToInt32(billProductQuantityTextBox.Text), Convert.ToDouble(billDiscountTextBox.Text),
                            billCompanyNameTextBox.Text, Convert.ToDouble(billProductTotalAmountTextBox.Text), billCustomerNameTextBox.Text, billSellerIdLabel.Text,
                            billProductDateTimePicker.Text);

                            billProductNameTextBox.Text = string.Empty;
                            billProductPriceTextBox.Text = string.Empty;
                            billProductQuantityTextBox.Text = string.Empty;
                            billDiscountTextBox.Text = string.Empty;
                            billCompanyNameTextBox.Text = string.Empty;
                            billProductTotalAmountTextBox.Text = string.Empty;
                            UpdateNetTotal();
                        }
                        else MessageBox.Show("Quantity Insufficient");

                    }
                   

                }
                else MessageBox.Show("Product Not Found");
   
            }


 }
    


    

        private void billPaidTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void billProductDeleteButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product Removed");
            Index = billDataGridView.CurrentCell.RowIndex;
            billDataGridView.Rows.RemoveAt(Index);
            UpdateNetTotal();


        }

       private void billConfirmButton_Click(object sender, EventArgs e)
        {
            bool check = false;
            MedicineAccess medicineAccess = new  MedicineAccess();
            BillDataAccess billDataAccess = new BillDataAccess();

            DialogResult result = MessageBox.Show("Are you sure you want to Confirm?", "Confirm", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (billPaidTextBox.Text == billNetTotalTextBox.Text)
                {
                    for (int i = 0; i < billDataGridView.Rows.Count - 1; i++)
                    {
                        Medicine medicine = new Medicine();
                        medicine = medicineAccess.addMedicineToGridView(billDataGridView.Rows[i].Cells[1].Value.ToString());

                        if (billDataAccess.InsertBill(Convert.ToInt32(billIdTextBox.Text), billDataGridView.Rows[i].Cells[1].Value.ToString(),
                             billDataGridView.Rows[i].Cells[5].Value.ToString(), medicine.BuyingPrice, medicine.SellingPrice, Convert.ToInt32(billDataGridView.Rows[i].Cells[3].Value.ToString()),
                             billDataGridView.Rows[i].Cells[7].Value.ToString(), Convert.ToDouble(billDataGridView.Rows[i].Cells[6].Value.ToString()),
                             Convert.ToInt32(billDataGridView.Rows[i].Cells[8].Value.ToString()), billDataGridView.Rows[i].Cells[9].Value.ToString(), medicine.Discount) == true)
                        {
                           if( medicineAccess.UpdateQuantityAfterSelling(billDataGridView.Rows[i].Cells[1].Value.ToString(), medicine.InitialQuantity-Convert.ToInt32(billDataGridView.Rows[i].Cells[3].Value.ToString())))
                                {

                                check = true;
                                 }
                           
                        }
                      

                    }
                }
              
            }
           else if (result == DialogResult.Cancel)
            {
                MessageBox.Show(" Bill Not Confirmed ");
            }
            if(check)
            {
                MessageBox.Show(" Congrats. Bill Confirmed! ");
            }else MessageBox.Show(" Bill Not Confirmed ");


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
