using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagement
{
    class Issues : DataAccess
    {
        protected string issueAssignedBy;
        protected string issueAssignedTo;
        protected string issueDate;
        protected string issueDescription;
        protected string issueStatus;
        protected int issueId;
        protected int issueAssignedToCount=0;
        protected int issueAssignedByCount=0;
        protected int issueCompletedCount=0;



        public int IssueAssignedToCount
        {
            set { this.issueAssignedToCount = value; }
            get { return issueAssignedToCount; }
        }

        public int IssueAssignedByCount
        {
            set { this.issueAssignedByCount = value; }
            get { return issueAssignedByCount; }
        }

        public int IssueCompletedCount
        {
            set { this.issueCompletedCount = value; }
            get { return issueCompletedCount; }
        }


        public string IssueAssignedBy
        {
            set { this.issueAssignedBy = value; }
            get { return issueAssignedBy; }
        }

        public string IssueAssignedTo
        {
            set { this.issueAssignedTo = value; }
            get { return issueAssignedTo; }
        }

        public string IssueDate
        {
            set { this.issueDate = value; }
            get { return issueDate; }
        }

        public string IssueDescription
        {
            set { this.issueDescription = value; }
            get { return issueDescription; }
        }

        public string IssueStatus
        {
            set { this.issueStatus= value; }
            get { return issueStatus; }
        }
        public int IssueID
        {
            set { this.issueId = value; }
            get { return issueId; }
        }


    }
}
