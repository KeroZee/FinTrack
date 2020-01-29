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

                    string id = row["id"].ToString();
                    string category = row["category"].ToString();
                    string title = row["title"].ToString();
                    string content = row["content"].ToString();
                    int likes = int.Parse(row["likes"].ToString());
                    int dislikes = int.Parse(row["dislikes"].ToString());
                    int comments = int.Parse(row["comments"].ToString());
                    string accountid = row["accountId"].ToString();
                    string dateposted = Convert.ToDateTime(row["datePosted"]).ToString("d/M/yyyy");
                    string username = row["Username"].ToString();
                    Post obj = new Post(id, category, title, content, likes, dislikes, comments, dateposted, accountid, username);
                    List.Add(obj);
                }
              
                
            }
            return List;
        }
        public List<Post> Search(string search)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * FROM Post WHERE title LIKE '%' + @paraSearch + '%';";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraSearch", search);

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

                    string id = row["id"].ToString();
                    string category = row["category"].ToString();
                    string title = row["title"].ToString();
                    string content = row["content"].ToString();
                    int likes = int.Parse(row["likes"].ToString());
                    int dislikes = int.Parse(row["dislikes"].ToString());
                    int comments = int.Parse(row["comments"].ToString());
                    string accountid = row["accountId"].ToString();
                    string dateposted = Convert.ToDateTime(row["datePosted"]).ToString("d/M/yyyy");
                    string username = row["Username"].ToString();
                    Post obj = new Post(id, category, title, content, likes, dislikes, comments, dateposted, accountid, username);
                    List.Add(obj);
                }


            }
            return List;
        }

            public Post SelectById(string postid)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "Select * from Post where id = @paraPostId";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraPostId", postid);

            DataSet ds = new DataSet();
            da.Fill(ds);


            Post post = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string id = row["id"].ToString();
                string category = row["category"].ToString();
                string title = row["title"].ToString();
                string content = row["content"].ToString();
                int likes = int.Parse(row["likes"].ToString());
                int dislikes = int.Parse(row["dislikes"].ToString());
                int comments = int.Parse(row["comments"].ToString());
                string accountid = row["accountId"].ToString();
                string dateposted = Convert.ToDateTime(row["datePosted"]).ToString("d/M/yyyy");
                string username = row["Username"].ToString();
                post = new Post(id, category, title, content, likes, dislikes, comments, dateposted, accountid, username);
            }
            return post;
        }
        public int Insert(Post post)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Post (id, category, title, content, likes, dislikes, comments, dateposted, accountid, username) VALUES (@paraid, @paracategory, @paratitle, @paracontent, @paralikes, @paradislikes, @paracomments, GETDATE(), @paraaccountid, @parausername)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraid", post.Id);
            sqlCmd.Parameters.AddWithValue("@paracategory", post.Category);
            sqlCmd.Parameters.AddWithValue("@paratitle", post.Title);
            sqlCmd.Parameters.AddWithValue("@paracontent", post.Content);
            sqlCmd.Parameters.AddWithValue("@paralikes", post.Likes);
            sqlCmd.Parameters.AddWithValue("@paradislikes", post.Dislikes);
            sqlCmd.Parameters.AddWithValue("@paracomments", post.Comments);
            sqlCmd.Parameters.AddWithValue("@paraaccountid", post.AccountId);
            sqlCmd.Parameters.AddWithValue("@parausername", post.Username);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();
            myConn.Close();

            return result;
        }

        public int UpdateById(string postid, string postcategory, string posttitle, string postcontent)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Post SET title = @paratitle, category = @paracategory, content = @paracontent WHERE id = @paraid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraid", postid);
            sqlCmd.Parameters.AddWithValue("@paracategory", postcategory);
            sqlCmd.Parameters.AddWithValue("@paratitle", posttitle);
            sqlCmd.Parameters.AddWithValue("@paracontent", postcontent);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();
            myConn.Close();

            return result;
        }

        public int DeleteById(string postid)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlStmt = "Delete from Post where id = @paraPostId";

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