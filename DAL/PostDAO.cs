using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using FinTrack.BLL;

namespace FinTrack.DAL
{
    public class PostDAO
    {
        public List<Post> SelectAll()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "Select * from Post";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);

            DataSet ds = new DataSet();
            da.Fill(ds);


            List<Post> List = new List<Post>();
            int rec_cnt = ds.Tables[0].Rows.Count;  
            if (rec_cnt < 1)
            {
                List = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {

                    string id = row["Id"].ToString();
                    string title = row["Title"].ToString();
                    string content = row["Content"].ToString();
                    int likes = int.Parse(row["Likes"].ToString());
                    int dislikes = int.Parse(row["Dislikes"].ToString());
                    int comment = int.Parse(row["Comment"].ToString());
                    string dateposted = Convert.ToDateTime(row["Date_Posted"]).ToString("d/M/yyyy");
                    string accountid = row["Account_ID"].ToString();
                    string username = row["Username"].ToString();
                    Post obj = new Post(id, title, content, likes, dislikes, comment, dateposted, accountid, username);
                    List.Add(obj);
                }
              
                
            }
            return List;
        }
        public int Insert(Post post)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Post (id, title, content, likes, dislikes, comment, date_posted, account_id, username) VALUES (@paraid, @paratitle, @paracontent, @paralikes, @paradislikes, @paracomment, GETDATE(), @paraaccountid, @parausername)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraid", post.Id);
            sqlCmd.Parameters.AddWithValue("@paratitle", post.Title);
            sqlCmd.Parameters.AddWithValue("@paracontent", post.Content);
            sqlCmd.Parameters.AddWithValue("@paralikes", post.Likes);
            sqlCmd.Parameters.AddWithValue("@paradislikes", post.Dislikes);
            sqlCmd.Parameters.AddWithValue("@paracomment", post.Comments);
            sqlCmd.Parameters.AddWithValue("@paraaccountid", post.AccountID);
            sqlCmd.Parameters.AddWithValue("@parausername", post.Username);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();
            myConn.Close();

            return result;
        }
    }
}