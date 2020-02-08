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
        public string Autoincrement()
        {
            int count = 0;
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection con = new SqlConnection(DBConnect);
            string str = "SELECT TOP 1 id FROM Post ORDER BY Id DESC;";
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
        // When dropdown list is all category and popular, recent and oldest
        public DataTable SelectAllPopular()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);
            String sqlstmt = "Select * from Post Order By likes DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            var dt = new DataTable();
            da.Fill(dt);
            myConn.Close();
            return dt;
        }
        public DataTable SelectAllRecent()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);
            String sqlstmt = "Select * from Post Order By dateposted DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            var dt = new DataTable();
            da.Fill(dt);
            myConn.Close();
            return dt;
        }
        public DataTable SelectAllOldest()
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);
            String sqlstmt = "Select * from Post Order By dateposted";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            var dt = new DataTable();
            da.Fill(dt);
            myConn.Close();
            return dt;
        }
        
        // When dropdown list is sorted by category and popular, recent and oldest
        public DataTable CategorySortPopular(string cate)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * FROM Post WHERE category = @paraCate Order By likes DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraCate", cate);

            var dt = new DataTable();
            da.Fill(dt);
            myConn.Close();
            return dt;

        }
        public DataTable CategorySortRecent(string cate)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * FROM Post WHERE category = @paraCate Order By dateposted DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraCate", cate);

            var dt = new DataTable();
            da.Fill(dt);
            myConn.Close();
            return dt;

        }
        public DataTable CategorySortOldest(string cate)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * FROM Post WHERE category = @paraCate Order By dateposted";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraCate", cate);

            var dt = new DataTable();
            da.Fill(dt);
            myConn.Close();
            return dt;

        }
        //Sorting for search
        public DataTable SearchPopular(string search)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * FROM Post WHERE title LIKE '%' + @paraSearch + '%' Order By likes DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraSearch", search);

            var dt = new DataTable();
            da.Fill(dt);
            myConn.Close();
            return dt;
        }
        public DataTable SearchRecent(string search)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * FROM Post WHERE title LIKE '%' + @paraSearch + '%' Order By dateposted DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraSearch", search);

            var dt = new DataTable();
            da.Fill(dt);
            myConn.Close();
            return dt;
        }
        public DataTable SearchOldest(string search)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * FROM Post WHERE title LIKE '%' + @paraSearch + '%' Order By dateposted";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraSearch", search);

            var dt = new DataTable();
            da.Fill(dt);
            myConn.Close();
            return dt;
        }
        public DataTable SearchPopularCategory(string search, string cate)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * FROM Post WHERE title LIKE '%' + @paraSearch + '%' and category = @paraCate Order By likes DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraSearch", search);
            da.SelectCommand.Parameters.AddWithValue("@paraCate", cate);

            var dt = new DataTable();
            da.Fill(dt);
            myConn.Close();
            return dt;
        }
        public DataTable SearchRecentCategory(string search, string cate)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * FROM Post WHERE title LIKE '%' + @paraSearch + '%' and category = @paraCate Order By dateposted DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraSearch", search);
            da.SelectCommand.Parameters.AddWithValue("@paraCate", cate);

            var dt = new DataTable();
            da.Fill(dt);
            myConn.Close();
            return dt;
        }
        public DataTable SearchOldestCategory(string search, string cate)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            String sqlstmt = "SELECT * FROM Post WHERE title LIKE '%' + @paraSearch + '%' and category = @paraCate Order By dateposted";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraSearch", search);
            da.SelectCommand.Parameters.AddWithValue("@paraCate", cate);

            var dt = new DataTable();
            da.Fill(dt);
            myConn.Close();
            return dt;
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
                string approved = row["Approved"].ToString();
                post = new Post(id, category, title, content, likes, dislikes, comments, dateposted, accountid, username, approved);
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

        public int UpdateComments(string postid)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);


            string sqlStmt = "UPDATE Post SET comments = @paracomments WHERE id = @paraid";


            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraid", postid);
            sqlCmd.Parameters.AddWithValue("@paracomments", GetNumberOfComments(postid));

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();
            myConn.Close();

            return result;
        }
        public int UpdateLikes(string postid)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);


            string sqlStmt = "UPDATE Post SET likes = likes + 1 WHERE id = @paraid";


            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraid", postid);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();
            myConn.Close();

            return result;
        }

        public int UpdateDislikes(string postid)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);


            string sqlStmt = "UPDATE Post SET dislikes = dislikes + 1 WHERE id = @paraid";


            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraid", postid);

            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();
            myConn.Close();

            return result;
        }

        public int GetNumberOfComments(string postid)
        {
            int count = 0;
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection con = new SqlConnection(DBConnect);
            string str = "SELECT COUNT(*) FROM PostComments WHERE postid = @paraid";
            SqlCommand com = new SqlCommand(str, con);
            com.Parameters.AddWithValue("@paraid", postid);
            con.Open();
            if (str == null)
            {
                count = 0;
            }
            else
            {
                count = Convert.ToInt16(com.ExecuteScalar());
            }
            con.Close();
            return count;
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