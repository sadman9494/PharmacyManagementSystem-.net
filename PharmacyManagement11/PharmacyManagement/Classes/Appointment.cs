using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement
{
    class Appointment  
    {
        protected int serialNo;
        protected string patientName;
        protected string visitingTime;
        protected string visitDate;

        public int SerialNo
        {
            set { this.serialNo = value; }
            get { return serialNo; }
        }

        public string PatientName
        {
            set { this.patientName = value; }
            get { return patientName; }
        }

        public string VisitingTime
        {
            set { this.visitingTime = value; }
            get { return visitingTime; }
        }
        public string VisitDate
        {
            set { this.visitDate = value; }
            get { return visitDate; }
        }




    }
}
