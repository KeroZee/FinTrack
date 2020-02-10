using FinTrack.BLL;
using FinTrack;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.UI.WebControls;
using System.Web;
using System.Web.UI.DataVisualization.Charting;

namespace FinTrack.DAL
{
    public class ExpenseDAO
    {
        public List<Expense> SelectAll(string email)
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from Expense where email = @paraEmail";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraEmail", email);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet to List
            List<Expense> expenseList = new List<Expense>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];  // Sql command returns only one record
                int expenseId = Convert.ToInt16(row["id"].ToString());
                string description = row["description"].ToString();
                DateTime DatePosted = Convert.ToDateTime(row["date"].ToString());
                string expenseCategory = row["category"].ToString();
                double expenseCost = Convert.ToDouble(row["price"].ToString());
                string expenseEmail = row["email"].ToString();
                Expense obj = new Expense(expenseId, description, expenseCategory, expenseCost, DatePosted, expenseEmail);
                expenseList.Add(obj);
            }

            return expenseList;
        }
        public List<Expense> SelectGraphData(string date, string category)
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from Expense";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet to List
            List<Expense> expenseList = new List<Expense>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];  // Sql command returns only one record
                int expenseId = Convert.ToInt16(row["id"].ToString());
                string description = row["description"].ToString();
                DateTime DatePosted = Convert.ToDateTime(row["date"].ToString());
                string expenseCategory = row["category"].ToString();
                double expenseCost = Convert.ToDouble(row["price"].ToString());
                string email = row["email"].ToString();
                Expense obj = new Expense(expenseId, description, expenseCategory, expenseCost, DatePosted, email);
                expenseList.Add(obj);
            }

            return expenseList;
        }
        public int Insert(Expense exp, string email)
        {
            // Execute NonQuery return an integer value
            int result = 0;
            SqlCommand sqlCmd = new SqlCommand();

            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            // Step 2 - Instantiate SqlCommand instance to add record 
            //          with INSERT statement
            string sqlStmt = "INSERT INTO Expense (description, category, price, date, email) " +
                "VALUES (@paraDesc, @paraCat, @paraCost, @paraDate, @paraEmail)";
            sqlCmd = new SqlCommand(sqlStmt, myConn);

            // Step 3 : Add each parameterised variable with value
            //TODO: implement userid into each expense entry
            //sqlCmd.Parameters.AddWithValue("@paraDesc", user.userid);
            sqlCmd.Parameters.AddWithValue("@paraDesc", exp.Description);
            sqlCmd.Parameters.AddWithValue("@paraCat", exp.Category);
            sqlCmd.Parameters.AddWithValue("@paraCost", exp.Cost);
            sqlCmd.Parameters.AddWithValue("@paraDate", exp.Date);
            sqlCmd.Parameters.AddWithValue("@paraEmail", email);

            // Step 4 Open connection the execute NonQuery of sql command   
            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();


            // Step 5 :Close connection
            myConn.Close();

            return result;
        }
        public int Update(Expense exp)
        {
            int result = 0;
            SqlCommand sqlCmd = new SqlCommand();

            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            // Step 2 - Instantiate SqlCommand instance to add record 
            //          with INSERT statement
            string sqlStmt = "UPDATE Expense SET description = @paraDesc, category = @paraCat, " +
                "price = @paraCost, date = @paraDate where id = @paraId";

            sqlCmd = new SqlCommand(sqlStmt, myConn);

            // Step 3 : Add each parameterised variable with value
            sqlCmd.Parameters.AddWithValue("@paraId", exp.Id);
            sqlCmd.Parameters.AddWithValue("@paraDesc", exp.Description);
            sqlCmd.Parameters.AddWithValue("@paraCat", exp.Category);
            sqlCmd.Parameters.AddWithValue("@paraCost", exp.Cost);
            sqlCmd.Parameters.AddWithValue("@paraDate", exp.Date.ToShortDateString());

            // Step 4 Open connection the execute NonQuery of sql command   
            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            // Step 5 :Close connection
            myConn.Close();

            return result;
        }
        public int DeletebyRow(long sid)
        {
            // Execute NonQuery return an integer value
            int result = 0;
            SqlCommand sqlCmd = new SqlCommand();

            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            // Step 2 - Instantiate SqlCommand instance to add record 
            //          with INSERT statement
            string sqlStmt = "DELETE FROM Expense WHERE id = @paraId";
            sqlCmd = new SqlCommand(sqlStmt, myConn);

            // Step 3 : Add each parameterised variable with value
            //TODO: implement userid into each expense entry
            //sqlCmd.Parameters.AddWithValue("@paraDesc", user.userid);
            sqlCmd.Parameters.AddWithValue("@paraId", sid);

            // Step 4 Open connection the execute NonQuery of sql command   
            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();


            // Step 5 :Close connection
            myConn.Close();

            return result;
        }
        public List<Expense> FilterByDate(string startDate, string endDate)
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from Expense WHERE date BETWEEN '" + startDate + "'and'" + endDate + "'";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet to List
            List<Expense> expenseList = new List<Expense>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];  // Sql command returns only one record
                int expenseId = Convert.ToInt16(row["id"].ToString());
                string description = row["description"].ToString();
                DateTime DatePosted = Convert.ToDateTime(row["date"].ToString());
                string expenseCategory = row["category"].ToString();
                double expenseCost = Convert.ToDouble(row["price"].ToString());
                string email = row["email"].ToString();
                Expense obj = new Expense(expenseId, description, expenseCategory, expenseCost, DatePosted, email);
                expenseList.Add(obj);
            }
            return expenseList;
        }
        public List<Expense> SearchByEmail(string email)
        {
            SqlCommand sqlCmd = new SqlCommand();

            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from Expense WHERE email ='" + email + "'";
            sqlCmd.Parameters.AddWithValue("@paraEmail", email);
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet to List
            List<Expense> expenseList = new List<Expense>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];  // Sql command returns only one record
                int expenseId = Convert.ToInt16(row["id"].ToString());
                string description = row["description"].ToString();
                DateTime DatePosted = Convert.ToDateTime(row["date"].ToString());
                string expenseCategory = row["category"].ToString();
                double expenseCost = Convert.ToDouble(row["price"].ToString());
                string expenseEmail = row["email"].ToString();
                Expense obj = new Expense(expenseId, description, expenseCategory, expenseCost, DatePosted, expenseEmail);
                expenseList.Add(obj);
            }
            return expenseList;
        }
    }
}