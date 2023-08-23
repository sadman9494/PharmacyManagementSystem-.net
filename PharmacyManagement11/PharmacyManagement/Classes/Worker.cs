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
    class Worker : DataAccess
    {
        protected int workerId;
        protected string workerPassword;
        protected string workerName;
        protected int workerAge;
        protected string workerGender;
        protected string workerMobileNo;
        protected string workerEmail;
        protected double workerSalary;
        protected string workerAddress;
        protected double profitOrLossInABill;
        protected int unitsSoldInABill;
        protected string billDate;
        protected int billId;

        protected double totalProfitMade;
        protected double totalQuantitiesSold;


        public int BillId
        {
            set { this.billId = value; }
            get { return billId ; }
        }


        public double ProfitOrLossInABill
        {
            set { this.profitOrLossInABill = value; }
            get { return profitOrLossInABill; }
        }

        public string BillDate
        {
            set { this.billDate = value; }
            get { return billDate; }
        }

        public int UnitsSoldInABill
        {
            set { this.unitsSoldInABill = value; }
            get { return unitsSoldInABill; }
        }


        public int WorkerId
        {
            set { this.workerId = value; }
            get { return workerId; }
        }

        public string WorkerPassword
        {
            set { this.workerPassword = value; }
            get { return workerPassword; }
        }

        public string WorkerName
        {
            set { this.workerName = value; }
            get { return workerName; }
        }

        public int WorkerAge
        {
            set { this.workerAge = value; }
            get { return workerAge; }
        }

        public string WorkerAddress
        {
            set { this.workerAddress = value; }
            get { return workerAddress; }
        }


        public string WorkerGender
        {
            set { this.workerGender = value; }
            get { return workerGender; }
        }

        public string WorkerMobileNo
        {
            set { this.workerMobileNo = value; }
            get { return workerMobileNo; }
        }

        public string WorkerEmail
        {
            set { this.workerEmail = value; }
            get { return workerEmail; }
        }

        public double WorkerSalary
        {
            set { this.workerSalary = value; }
            get { return workerSalary; }
        }
       
        public double TotalProfitMade
        {
            set { this.totalProfitMade = value; }
            get { return totalProfitMade; }
        }

        public double TotalQuantitiesSold
        {
            set { this.totalQuantitiesSold = value; }
            get { return totalQuantitiesSold; }
        }









    }
}
