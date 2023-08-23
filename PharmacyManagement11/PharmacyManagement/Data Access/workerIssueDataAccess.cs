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
    class workerIssueDataAccess : DataAccess
    {
        public bool CreateIssues(string assignBy, string assignTo, string issue, string date, string status)
        {
            string sql = "INSERT INTO workerIssue(AssignBy, AssignTo, Issue , Date , Status) VALUES('" + assignBy + "','" + assignTo + "','" + issue + "',' " + date + "' ,' " + status + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;

        }

        public Issues GetName(int id)
        {
            string sql = " SELECT * FROM WorkerInfo WHERE ID = '" + id + "'";

            
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                reader.Read();
                Issues issueName = new Issues();
                issueName.IssueAssignedTo = reader["WorkerName"].ToString();
                return issueName;
            }
            else
            { return null; }
            
        }
    }
}
