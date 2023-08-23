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
    class IssueOperations : Issues
    {
       public int GetIssuesAssignedTo (string name)
        {
            string sql = "SELECT *FROM workerIssue WHERE AssignTo LIKE '" + name + "%'";
            SqlDataReader reader = this.GetData(sql);
            int issueAssignedToCount = 0;
            while ( reader.Read())
            {
                issueAssignedToCount++;
            }

            return issueAssignedToCount;
        }

        public int GetIssuesAssignedBy(string name)
        {

            string sql = "SELECT *FROM workerIssue WHERE AssignBy LIKE '" + name + "%'";
            SqlDataReader reader = this.GetData(sql);
            issueAssignedByCount = 0;
            while (reader.Read())
            {

                issueAssignedByCount++;
            }

            return issueAssignedByCount;
        }

        public int GetIssuesCompleted(string name)
        {
            string status = "Done";
            string sql = "SELECT *FROM workerIssue WHERE Status = '" + status + "' AND  AssignTo LIKE '" + name + "%'";
            SqlDataReader reader = this.GetData(sql);
            issueCompletedCount = 0;
            while (reader.Read())
            {

                issueCompletedCount++;
            }

            return issueCompletedCount;
        }


        


        public List<Issues> GetAllIssues()
        {
            List<Issues> issues = new List<Issues>();
            
            string sql = "SELECT * FROM workerIssue";
            SqlDataReader reader = this.GetData(sql);

            while (reader.Read())
            {
                Issues issue = new Issues();
                issue.IssueAssignedBy = reader["AssignBy"].ToString();
                issue.IssueAssignedTo = reader["AssignTo"].ToString();
                issue.IssueID = (int)reader["IssueId"];
                issue.IssueDescription = reader["Issue"].ToString();
                issue.IssueStatus = reader["Status"].ToString();
                issue.IssueDate = reader["Date"].ToString();

                issues.Add(issue);
            }
            if (issues.Count != 0)
                return issues;
            else return null;
        }

        public List<Issues> Getissues(string name)
        {
            List<Issues> issues = new List<Issues>();
           
            string sql = "SELECT *FROM workerIssue WHERE AssignTo = '" + name + "'";
            SqlDataReader reader = this.GetData(sql);

            while (reader.Read())
            {
                Issues issue = new Issues();
                issue.IssueAssignedBy = reader["AssignBy"].ToString();
                issue.IssueID = (int)reader["IssueId"];
                issue.IssueDescription = reader["Issue"].ToString();
                issue.IssueStatus = reader["Status"].ToString();

                issues.Add(issue);
            }
            return issues;

        }

        public bool UpdateIssueStatus(int id, string status)
        {

            string sql = "UPDATE workerIssue SET Status='" + status + "' WHERE IssueId=" + Convert.ToString(id);
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

    }
    }

