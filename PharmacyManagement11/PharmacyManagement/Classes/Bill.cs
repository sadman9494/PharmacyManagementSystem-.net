using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement
{
    class Bill : Medicine
    {
        protected string billDate;
        protected string soldBy;
        protected string customerName;
        protected double billAmount;
        //protected double totalProfit;
        protected int billId;
        protected string productName;
        protected int productQuantity;
        protected double productPrice;
        protected double profitLoss;
        protected string companyName;
        protected double billDiscount;



        public string BillDate
        {
            set { this.billDate = value; }
            get { return billDate; }
        }

        public string SoldBy
        {
            set { this.soldBy = value; }
            get { return soldBy; }
        }

        public string CustomerName
        {
            set { this.customerName = value; }
            get { return customerName; }
        }


        public double BillAmount
        {
            set { this.billAmount = value; }
            get { return billAmount; }
        }
        /*  public double TotalProfit
         {
             set { this.totalProfit = value; }
             get { return totalProfit; }
         }*/

        public int BillID
        {
            set { this.billId = value; }
            get { return billId; }
        }

        public double ProductPrice
        {
            set { this.productPrice = value; }
            get { return productPrice; }
        }

        public string ProductName
        {
            set { this.productName = value; }
            get { return productName; }
        }

        public int ProductQuantity
        {
            set { this.productQuantity = value; }
            get { return productQuantity; }
        }

        public double ProfitLoss
        {
            set { this.profitLoss = value; }
            get { return profitLoss; }
        }
        public string CompanyName
        {
            set { this.companyName = value; }
            get { return companyName; }
        }

        public double BillDiscount
        {
            set { this.billDiscount = value; }
            get { return billDiscount; }
        }


    }
}
