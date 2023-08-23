using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace PharmacyManagement
{
    class WorkerOperations : Worker
    {
        protected List<Worker> workers = new List<Worker>();

        public Worker insertWorkerInfo(int id)
        {
            string sql = "SELECT * FROM WorkerInfo WHERE ID=" + id;

            SqlDataReader reader1 = this.GetData(sql);
            if (reader1.HasRows)
            {
                reader1.Read();
                Worker worker = new Worker();
                worker.WorkerId = (int)reader1["ID"];
                worker.WorkerPassword = reader1["Password"].ToString();

                if (reader1["Address"].ToString() == "")
                { worker.WorkerAddress = "---"; }
                else { worker.WorkerAddress = reader1["Address"].ToString(); }


                if (reader1["WorkerName"].ToString() == "")
                { worker.WorkerName = "---"; }
                else { worker.WorkerName = reader1["WorkerName"].ToString(); }

                if (reader1["Gender"].ToString() == "")
                { worker.WorkerGender = "---"; }
                else { worker.WorkerGender = reader1["Gender"].ToString(); }

                if (reader1["Email"].ToString() == "")
                { worker.WorkerEmail = "---"; }
                else { worker.WorkerEmail = reader1["Email"].ToString(); }


                if (reader1["WorkerMobileNo"].ToString() == "")
                { worker.WorkerMobileNo = "---"; }
                else { worker.WorkerMobileNo = reader1["WorkerMobileNo"].ToString(); }

                if (reader1["Age"].ToString() == "")
                { worker.WorkerAge = 0; }
                else { worker.WorkerAge = (int)reader1["Age"]; }


                if (reader1["Salary"].ToString() == "")
                { worker.WorkerSalary = 0; }
                else { worker.WorkerSalary = (double)reader1["Salary"]; }

                workers.Add(worker);
                return worker;
            }
            else return null;
        }

        public Worker searchWorker(int id)
        {
            Worker temp = new Worker();

            foreach (Worker worker in workers)
            {
                if (worker != null)
                {
                    if (worker.WorkerId == id)
                    {
                        temp = worker;
                    }
                }
            }
            return temp;

        }


        public List<Worker> GetWorkerBillInfo(int sellerId)
        {
            List<Worker> workerbillInfo = new List<Worker>();
            string sql= "SELECT * FROM BillTable Where SellerId= "+sellerId;
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                Worker worker = new Worker();
                worker.ProfitOrLossInABill = (double)reader["ProfitorLoss"];
                worker.UnitsSoldInABill = (int)reader["ProductQuantity"];
                worker.BillDate = reader["BillDate"].ToString();
                worker.BillId = (int)reader["BillId"];

                workerbillInfo.Add(worker);
            }
            if (workerbillInfo.Count!= 0)
            { return workerbillInfo; }
            else return null;

        }


    }
}




