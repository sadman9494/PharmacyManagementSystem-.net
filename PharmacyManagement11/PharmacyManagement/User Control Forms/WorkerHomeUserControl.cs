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
    public partial class WorkerHomeUserControl : UserControl
    {
        public int homeId;
        double LargestMedicineProfit;
        int index2 = 0;
        public WorkerHomeUserControl(int id)
        {
            InitializeComponent();
            this.homeId = id;
        }


        public WorkerHomeUserControl()
        {
            InitializeComponent();
        }

        private void WorkerHomeUserControl_Load(object sender, EventArgs e)
        {
            Worker worker = new Worker();
            WorkerOperations wop = new WorkerOperations();
            worker = wop.insertWorkerInfo(this.homeId);
            HomeNameIDLabel.Text = worker.WorkerName + " [ " + worker.WorkerId + " ] ";
            worker = wop.insertWorkerInfo(this.homeId);
            string Medname = "";
            BillDataAccess billDataAccess = new BillDataAccess();
            MedicineAccess medicineAccess = new MedicineAccess();
            AdminDataAccess adminDataAccess = new AdminDataAccess();
            List<Worker> workers = billDataAccess.GetAllWorkerSaleInfo(billDataAccess.GetSalesmanID());
            List<Medicine> medicines = medicineAccess.GetAllMedicineSaleInfo(medicineAccess.GetMedicineNames());


            while (index2 < medicines.Count)
            {
                if (LargestMedicineProfit < medicines[index2].ProfitOrLoss)
                {
                    LargestMedicineProfit = medicines[index2].ProfitOrLoss;
                    Medname = medicines[index2].MedicineName;
                }
                index2++;
            }
            WorkerDataAccess workerDataAccess = new WorkerDataAccess();
            todaySalesLabel.Text = Convert.ToString(billDataAccess.CalculateSaleByDate(DateTime.Now.ToString("M/dd/yyyy"))) + " Units";
            topSoldMedicineLabel.Text = Medname + " [Profit: " + Convert.ToString(LargestMedicineProfit) + "]";
            yesterdaySalesLabel.Text = Convert.ToString(billDataAccess.CalculateSaleByDate(DateTime.Today.AddDays(-1).ToString("M/dd/yyyy"))) + " Units";



        }
    }
}
