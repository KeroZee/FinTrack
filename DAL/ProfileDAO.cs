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
        public Profiles SelectById(string userid)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "Select * from Profile where Id = @paraId ";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            da.SelectCommand.Parameters.AddWithValue("@paraId", userid);

            DataSet ds = new DataSet();

            da.Fill(ds);

            Profiles Prof = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
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

                Prof = new Profiles(id, email, password, fname, lname, bio, avatar, country, phone,language, nickname, acc_type, question);
            }
            else
            {
                Prof = null;
            }
            return Prof;

        }
        public int Insert(Profiles Prof)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Profile (email, password, Avatar, fname, lname, bio, country, phone, language, nickname)" +
                             "VALUES (@paraemail, @parapassword, @paraAvatar, @parafname, @paralname, @parabio, @paracountry, @paraphone, @paralanguage, @paranickname)";

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
            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

    }
}