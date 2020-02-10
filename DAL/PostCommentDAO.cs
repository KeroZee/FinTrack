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
    public class PostCommentDAO
    {
        public string Autoincrement()
        {
            int count = 0;
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection con = new SqlConnection(DBConnect);
            string str = "SELECT TOP 1 id FROM PostComments ORDER BY Id DESC;";
            SqlCommand com = new SqlCommand(str, con);
            con.Open();
            if (str == null)
            {
                count = 1;
            }
            else
            {
                count = Convert.ToInt16(com.ExecuteScalar()) + 1;
            }
            con.Close();
            return count.ToString();
        }
        public List<PostComment> SelectAllComments(string postId)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "Select * from PostComments where postid = @parapostid";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@parapostId", postId);

            DataSet ds = new DataSet();
            da.Fill(ds);


            List<PostComment> List = new List<PostComment>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt < 1)
            {
                List = null;
            }
            else
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {

                    string id = row["id"].ToString();
                    string postid = row["postId"].ToString();
                    string content = row["content"].ToString();
                    string username = row["username"].ToString();
                    int likes = int.Parse(row["likes"].ToString());
                    int dislikes = int.Parse(row["dislikes"].ToString());
                    string accountid = row["accountId"].ToString();
                    string dateposted = Convert.ToDateTime(row["datePosted"]).ToString("d/M/yyyy");
                    PostComment obj = new PostComment(id, postid, content, username, likes, dislikes, dateposted, accountid);
                    List.Add(obj);
                }


            }
            return List;
        }

        public int InsertComment(PostComment postcom)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO PostComments (id, postid, content, username, likes, dislikes, dateposted, accountid) VALUES (@paraid, @parapostid, @paracontent, @parausername, @paralikes, @paradislikes, GETDATE(), @paraaccountid)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraid", postcom.Id);
            sqlCmd.Parameters.AddWithValue("@parapostid", postcom.PostId);
            sqlCmd.Parameters.AddWithValue("@paracontent", postcom.Content);
            sqlCmd.Parameters.AddWithValue("@parausername", postcom.Username);
            sqlCmd.Parameters.AddWithValue("@paralikes", postcom.Likes);
            sqlCmd.Parameters.AddWithValue("@paradislikes", postcom.Dislikes);
            sqlCmd.Parameters.AddWithValue("@paraaccountid", postcom.AccountId);


            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();
            myConn.Close();

            return result;
        }
        public int Delete(string id)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlStmt = "Delete from PostComments where id = @paraid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);
            sqlCmd.Parameters.AddWithValue("@paraid", id);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();
            myConn.Close();
            return result;
        }
        public int DeletePostComments(string postid)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlStmt = "Delete from PostComments where postid = @paraPostId";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);
            sqlCmd.Parameters.AddWithValue("@paraPostId", postid);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();
            myConn.Close();
            return result;
        }
    }
}