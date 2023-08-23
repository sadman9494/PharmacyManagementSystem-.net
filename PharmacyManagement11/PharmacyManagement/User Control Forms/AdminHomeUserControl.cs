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
    public partial class AdminHomeUserControl : UserControl
    {
        int id;
        int index1, index2 = 0;
        double LargestTotalprofit , LargestMedicineProfit = int.MinValue;
        string Medname; 
        public AdminHomeUserControl()
        {
            InitializeComponent();
        }

        private void AdminHomeUserControl_Load(object sender, EventArgs e)
        {  
           
            BillDataAccess billDataAccess = new BillDataAccess();
            MedicineAccess medicineAccess = new MedicineAccess();
            AdminDataAccess adminDataAccess = new AdminDataAccess();
            List<Worker> workers = billDataAccess.GetAllWorkerSaleInfo(billDataAccess.GetSalesmanID());
            List<Medicine> medicines = medicineAccess.GetAllMedicineSaleInfo(medicineAccess.GetMedicineNames());
            while (index1 < workers.Count)
            {
                if (LargestTotalprofit < workers[index1].TotalProfitMade)
                {
                    LargestTotalprofit = workers[index1].TotalProfitMade;
                    id = workers[index1].WorkerId;
                }
                index1++;
            }

            while (index2 < medicines.Count)
            {
                if (LargestMedicineProfit < medicines[index2].ProfitOrLoss)
                {
                    LargestMedicineProfit = medicines[index2].ProfitOrLoss;
                    Medname  = medicines[index2].MedicineName;
                }
                index2++;
            }


            WorkerDataAccess workerDataAccess = new WorkerDataAccess();
            string name = workerDataAccess.GetWorkerName(id);

            topSalesmanLabel.Text  =  name + "   [Profit : " + Convert.ToString(LargestTotalprofit)+ " ]";
            todaySalesLabel.Text = Convert.ToString(billDataAccess.CalculateSaleByDate(DateTime.Now.ToString("M/dd/yyyy")))+" Units";
            totalWorkerLabel.Text = Convert.ToString(adminDataAccess.calculateTotalWorkers());
            totalProfitLabel.Text = Convert.ToString(billDataAccess.CalculateTotalProfit());
            topSoldMedicineLabel.Text = Medname + " [Profit: " + Convert.ToString(LargestMedicineProfit)+ "]";
            yesterdaySalesLabel.Text = Convert.ToString(billDataAccess.CalculateSaleByDate(DateTime.Today.AddDays(-1).ToString("M/dd/yyyy"))) + " Units";

        }

        private void topSalesmanLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
