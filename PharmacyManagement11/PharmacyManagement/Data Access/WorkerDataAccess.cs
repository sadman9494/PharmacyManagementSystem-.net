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
    class WorkerDataAccess : DataAccess
    {
        public bool CreateProfile(string workerName, int age, string gender, string mobileNo, string address)
        {
            string sql = 
    "INSERT INTO WorkerInfo(WorkerName,Age,Gender,WorkerMobileNo,Address) VALUES('" + workerName + "','" + age + "','" + gender + "',' " + mobileNo + "'," +
    " '" + address + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }



        public bool UpdatePassword(string password, int id)
        {
            string sql = "UPDATE WorkerInfo SET Password='" + password + "' WHERE ID=" + Convert.ToString(id);
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateName(string name, int id)
        {
            string sql = "UPDATE WorkerInfo SET WorkerName='" + name + "' WHERE ID=" + Convert.ToString(id);
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateAge(int age, int id)
        {
            string sql = "UPDATE WorkerInfo SET Age='" + age + "' WHERE ID=" + Convert.ToString(id);
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateGender(string gender, int id)
        {
            string sql = "UPDATE WorkerInfo SET Gender='" + gender + "' WHERE ID=" + Convert.ToString(id);
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }




        public bool UpdateMobileNo(string mobileNo, int id)
        {
            string sql = "UPDATE WorkerInfo SET WorkerMobileNo='" + mobileNo + "' WHERE ID=" + Convert.ToString(id);
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateAddress(string address, int id)
        {
            string sql = "UPDATE WorkerInfo SET Address='" + address + "' WHERE ID=" + Convert.ToString(id);
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateEmail(string email, int id)
        {
            string sql = "UPDATE WorkerInfo SET Email='" + email + "' WHERE ID=" + Convert.ToString(id);
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }



        public Worker ValidateLogin(int id, string password)
        {
            Worker worker = new Worker();
            string sql3 = "SELECT * FROM WorkerInfo WHERE ID='" + Convert.ToString(id) + "' AND Password='" + password + "'";
           SqlDataReader reader = this.GetData(sql3);
            if (reader.HasRows)
            { 
                return worker;
                

            }
             else return null;

        }




        public int GetTotalBillsMade(int id)
        {
            int totalbills = 0;
            string sql = " SELECT *FROM BillTable WHERE SellerId= '" + id + "'";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                totalbills++;
            }
            return totalbills;
        }
       public String GetWorkerName(int id)
        {
            string name = "";
            string sql = " SELECT *FROM WorkerInfo WHERE ID = '" + id + "'";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                name = reader["WorkerName"].ToString();
            }
            return name;
        }

        public List<string> GetWorkerNames()
        {
            List<string> names = new List<string>();
            
            
            string sql = " SELECT *FROM WorkerInfo ";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                string name = "";

                name = reader["WorkerName"].ToString();
                names.Add(name);
            }
            return names;
        }
    }
        



    }

