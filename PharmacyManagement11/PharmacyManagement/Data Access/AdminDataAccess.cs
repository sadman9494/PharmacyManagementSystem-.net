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
    class AdminDataAccess : DataAccess
    {
        public bool InsertWorkerIntoWorkerInfo(string name,string password)
        {
            string sql2 = "INSERT INTO WorkerInfo (WorkerName,Password) VALUES('" + name + "','" + password + "'  )";
            int result = this.ExecuteQuery(sql2);
            if (result > 0)
                return true;

            else
                return false;
        }
        //public bool InsertWorkerIntoEmployees(int id, string designation, string password)
        //{
        //    string sql =
        //   "INSERT INTO Employees(ID,Designation,Password) VALUES('" + id + "','" + designation + "','" + password + "' )";
        //    int result = this.ExecuteQuery(sql);
        //    if (result > 0)
        //        return true;
        //    else
        //        return false;
        //}

        public int getWorkerID(string name)
        {
            int workerID;
            string sql = "SELECT ID FROM WorkerInfo WHERE WorkerName='" + name + "'";
            SqlDataReader reader1 = this.GetData(sql);
            if (reader1.HasRows)
            {
                reader1.Read();
                workerID = (int)reader1["ID"];
                return workerID;

            }
            else return 0;

        }



        public bool UpdateWorkerSalary(int id, double salary)
        {
            string sql = "UPDATE WorkerInfo SET Salary='" + salary + "' WHERE ID=" + Convert.ToString(id);
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }



        public bool InsertDoctor(string docName, string docMobile, string docSpeciality, string visitingHour)
        {
            string sql =
    "INSERT INTO DoctorInfo (DoctorName, DocMobileNo, Speciality, VisitingHour) VALUES('" + docName + "','" + docMobile + "','" + docSpeciality + "'" +
    ",'" + visitingHour + "' )";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }


        public List<Worker> GetWorkers()
        {
            List<Worker> workers = new List<Worker>();
            string sql = "SELECT * FROM WorkerInfo ";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                Worker worker = new Worker();

                worker.WorkerId = (int)reader["ID"];

                if (reader["Address"].ToString() == "")
                { worker.WorkerAddress = "---"; }
                else { worker.WorkerAddress = reader["Address"].ToString(); }


                if (reader["WorkerName"].ToString() == "")
                { worker.WorkerName = "---"; }
                else { worker.WorkerName = reader["WorkerName"].ToString(); }

                if (reader["Gender"].ToString() == "")
                { worker.WorkerGender = "---"; }
                else { worker.WorkerGender = reader["Gender"].ToString(); }

                if (reader["Email"].ToString() == "")
                { worker.WorkerEmail = "---"; }
                else { worker.WorkerEmail = reader["Email"].ToString(); }


                if (reader["WorkerMobileNo"].ToString() == "")
                { worker.WorkerMobileNo = "---"; }
                else { worker.WorkerMobileNo = reader["WorkerMobileNo"].ToString(); }

                if (reader["Age"].ToString() == "")
                { worker.WorkerAge = 0; }
                else { worker.WorkerAge = (int)reader["Age"]; }


                if (reader["Salary"].ToString() == "")
                { worker.WorkerSalary = 0; }
                else { worker.WorkerSalary = (double)reader["Salary"]; }

                workers.Add(worker);

            }
            if (workers.Count != 0)
            { return workers; }
            else return null;

        }

      
        public int calculateTotalWorkers()
        {
            int totalworkers = 0;
            string sql = "Select * from WorkerInfo";
            SqlDataReader reader = this.GetData(sql);
            while(reader.Read())
            { totalworkers++; }
            return totalworkers;
        }

        public bool removeWorkerFromWorkerInfo(int id)
        {
            string sql = "DELETE FROM WorkerInfo WHERE ID=" + id;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;

            else
                return false;

        }

        //public bool removeWorkerFromEmployees(int id)
        //{
        //    string sql = "DELETE FROM Employees WHERE ID=" + id;
        //    int result = this.ExecuteQuery(sql);
        //    if (result > 0)
        //        return true;

        //    else
        //        return false;
        //}

        public bool removeDoctor(int id)
        {
            string sql = "DELETE FROM DoctorInfo WHERE DoctorID=" + id;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;

            else
                return false;
        }
    }
    
 }



