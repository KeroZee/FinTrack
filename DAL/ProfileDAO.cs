using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FinTrack.DAL
{
    public class ProfileDAO
    {
        public List<Profiles> SelectAll()
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from Profiles";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet to List
            List<Profiles> Profileslist = new List<Profiles>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[0];  // Sql command returns only one record
                int id = int.Parse(row["userid"].ToString());
                string email = row["email"].ToString();
                string password = row["password"].ToString();
                //DateTime dob = Convert.ToDateTime(row["DOB"].ToString());
                string fname = row["firstName"].ToString();
                string lname = row["lastName"].ToString();
                string bio = row["bio"].ToString();
                string avatar = row["Avatar"].ToString();
                string country = row["country"].ToString();
                string phone = row["phone"].ToString();
                string language = row["language"].ToString();
                string nickname = row["nickname"].ToString();
                string acc_type = row["acc_type"].ToString();
                //DateTime date_join = Convert.ToDateTime(row["date_join"].ToString());
                int question = int.Parse(row["question"].ToString());

                Profiles obj = new Profiles(id, email, password, fname, lname, bio, avatar, country, phone, language, nickname, acc_type, question);
                Profileslist.Add(obj);
            }

            return Profileslist;
        }
        public Profiles SelectById(string email)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "Select * from Profile where email = @paraemail ";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraemail", email);

            DataSet ds = new DataSet();

            da.Fill(ds);

            Profiles Prof = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];  // Sql command returns only one record
                int id = int.Parse(row["userid"].ToString());
                string password = row["password"].ToString();
                //DateTime dob = Convert.ToDateTime(row["DOB"].ToString());
                string fname = row["fname"].ToString();
                string lname = row["lname"].ToString();
                string bio = row["bio"].ToString();
                string avatar = row["Avatar"].ToString();
                string country = row["country"].ToString();
                string phone = row["phone"].ToString();
                string language = row["language"].ToString();
                string nickname = row["nickname"].ToString();
                string acc_type = row["acc_type"].ToString();
                //DateTime date_join = Convert.ToDateTime(row["date_join"].ToString());
                int question = int.Parse(row["question"].ToString());

                Prof = new Profiles(id, email, password, fname, lname, bio, avatar, country, phone,language, nickname, acc_type, question);
            }
            else
            {
                Prof = null;
            }
            return Prof;

        }

        public int LoginCheck(string email , string password)
        {
            int count = 0;
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);
            string query = "SELECT COUNT(*) FROM Profile WHERE email=@paraemail AND password=@parapassword";
            
            SqlCommand sqlCmd = new SqlCommand(query, myConn);
            
            sqlCmd.Parameters.AddWithValue("@paraemail", email.Trim());
            sqlCmd.Parameters.AddWithValue("@parapassword", password.Trim());
            myConn.Open();
            if(query == null)
            {
                count = 0;
            }
            else
            {
                count = Convert.ToInt16(sqlCmd.ExecuteScalar());
            }
            myConn.Close();
            return count;
        }
        public int Insert(Profiles Prof)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Profile (email, password, Avatar, fname, lname, bio, country, phone, language, nickname, question)" +
                             "VALUES (@paraemail, @parapassword, @paraAvatar, @parafname, @paralname, @parabio, @paracountry, @paraphone, @paralanguage, @paranickname, @paraquestion)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraemail", Prof.Email);
            sqlCmd.Parameters.AddWithValue("@parapassword", Prof.Password);
            //sqlCmd.Parameters.AddWithValue("@paradob", Prof.DOB);
            sqlCmd.Parameters.AddWithValue("@paraAvatar", Prof.Avatar);
            sqlCmd.Parameters.AddWithValue("@parafname", Prof.Fname);
            sqlCmd.Parameters.AddWithValue("@paralname", Prof.Lname);
            sqlCmd.Parameters.AddWithValue("@parabio", Prof.Bio);
            sqlCmd.Parameters.AddWithValue("@paracountry", Prof.Country);
            sqlCmd.Parameters.AddWithValue("@paraphone", Prof.Phone);
            sqlCmd.Parameters.AddWithValue("@paralanguage", Prof.Language);
            sqlCmd.Parameters.AddWithValue("@paranickname", Prof.Nickname);
            sqlCmd.Parameters.AddWithValue("@paraquestion", Prof.Question);
            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }
        public int UpdateById(string userid, string fname, string lname, string bio, string country, string phone, string language, string nickname)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Profile SET fname = @parafname, lname = @paralname, bio = @parabio, country = @paracountry," +
                "phone = @paraphone, language = @paralanguage, nickname = @paranickname WHERE id = @paraid";

            int result = 0;
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraid", userid);
            sqlCmd.Parameters.AddWithValue("@parafname", fname);
            sqlCmd.Parameters.AddWithValue("@paralname", lname);
            sqlCmd.Parameters.AddWithValue("@parabio", bio);
            sqlCmd.Parameters.AddWithValue("@paracountry", country);
            sqlCmd.Parameters.AddWithValue("@paraphone", phone);
            sqlCmd.Parameters.AddWithValue("@paralanguage", language);
            sqlCmd.Parameters.AddWithValue("@paranickname", nickname);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();
            myConn.Close();

            return result;
        }


    }
}