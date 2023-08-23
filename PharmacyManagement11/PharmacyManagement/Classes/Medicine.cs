using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement
{
    class Medicine : DataAccess
    {
        protected string medicineName;
        protected string medicineCategory;
        protected string medicineCompanyName;
        protected double buyingPrice;
        protected double sellingPrice;
        protected int initialQuantity;
        protected int soldQuantity;
        protected int remainingQuantity;
        protected double remainingAmount;
        protected string expiringDate;
        protected double profitOrLoss;
        protected double discount;
        protected int medicineId;
        

        public int MedicineId
        {
            set { this.medicineId = value; }
            get { return medicineId; }
        }
        public string MedicineName
        {
            set { this.medicineName = value; }
            get { return medicineName; }
        }
        public string MedicineCategory
        {
            set { this.medicineCategory = value; }
            get { return medicineCategory; }
        }
        public string MedicineCompanyName
        {
            set { this.medicineCompanyName = value; }
            get { return medicineCompanyName; }
        }
        public double BuyingPrice
        {
            set { this.buyingPrice = value; }
            get { return buyingPrice; }
        }
        public double SellingPrice
        {
            set { this.sellingPrice = value; }
            get { return sellingPrice; }
        }

        public int InitialQuantity
        {
            set { this.initialQuantity = value; }
            get { return initialQuantity; }
        }
        public int SoldQuantity
        {
            set { this.soldQuantity = value; }
            get { return soldQuantity; }
        }
        public int RemainingQuantity
        {
            set { this.remainingQuantity = value; }
            get { return remainingQuantity; }
        }
        public double RemainingAmount
        {
            set { this.remainingAmount = value; }
            get { return remainingAmount; }
        }

        public string ExpiringDate
        {
            set { this.expiringDate = value; }
            get { return expiringDate; }
        }

        public double ProfitOrLoss
        {
            set { this.profitOrLoss = value; }
            get { return profitOrLoss; }
        }

        public double Discount
        {
            set { this.discount = value; }
            get { return discount; }
        }

       
    }
}
