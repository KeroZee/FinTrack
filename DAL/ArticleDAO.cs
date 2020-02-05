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
    public class ArticleDAO
    {
        public Article SelectById(string articleId)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlstmt = "Select * from Article where id = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlstmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraId", articleId);

            DataSet ds = new DataSet();
            da.Fill(ds);
            int rec_cnt = ds.Tables[0].Rows.Count;

            Article obj = null;
            if (rec_cnt > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                //string id = row["id"].ToString();
                string title = row["title"].ToString();
                int views = Convert.ToInt32(row["views"]);
                int likes = Convert.ToInt32(row["likes"]);
                int comments = Convert.ToInt32(row["comments"]);
                string description = row["description"].ToString();
                string image = row["image"].ToString();
                string dateposted = Convert.ToDateTime(row["dateposted"]).ToString("d/M/yyyy");
                string author = row["author"].ToString();
                string link = row["link"].ToString();
                string lastupdated = Convert.ToDateTime(row["lastupdated"]).ToString("d/M/yyyy");
                Boolean deleted = Convert.ToBoolean(row["deleted"]);
                obj = new Article(title, views, likes, comments, description, image, dateposted, author, link, lastupdated, deleted);
            }
            return obj;
        }

        public List<Article> SelectAll()
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from web.config
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from Article";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet to List
            List<Article> articleList = new List<Article>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                //string id = row["id"].ToString();
                string title = row["title"].ToString();
                int views = Convert.ToInt32(row["views"]);
                int likes = Convert.ToInt32(row["likes"]);
                int comments = Convert.ToInt32(row["comments"]);
                string description = row["description"].ToString();
                string image = row["image"].ToString();
                string dateposted = row["dateposted"].ToString();
                string author = row["author"].ToString();
                string link = row["link"].ToString();
                string lastupdated = Convert.ToDateTime(row["lastupdated"]).ToString("d/M/yyyy");
                Boolean deleted = Convert.ToBoolean(row["deleted"]);
                Article obj = new Article(title, views, likes, comments, description, image, dateposted, author, link, lastupdated, deleted);
                articleList.Add(obj);
            }

            return articleList;
        }

        public int Insert(Article art)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "INSERT INTO Article (title, views, likes, comments, description, image, dateposted, author, link, lastupdated, deleted)" +
                             "VALUES (@paratitle, @paraviews, @paralikes, @paracomments, @paradescriptions, @paraimage, @paradateposted, @paraauthor, @paralink, @paralastupdated, @paradeleted)";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            //sqlCmd.Parameters.AddWithValue("@paraid", art.Id);
            sqlCmd.Parameters.AddWithValue("@paratitle", art.Title);
            sqlCmd.Parameters.AddWithValue("@paraviews", art.Views);
            sqlCmd.Parameters.AddWithValue("@paralikes", art.Likes);
            sqlCmd.Parameters.AddWithValue("@paracomments", art.Comments);
            sqlCmd.Parameters.AddWithValue("@paradescriptions", art.Description);
            sqlCmd.Parameters.AddWithValue("@paraimage", art.Image);
            sqlCmd.Parameters.AddWithValue("@paradateposted", art.DatePosted);
            sqlCmd.Parameters.AddWithValue("@paraauthor", art.Author);
            sqlCmd.Parameters.AddWithValue("@paralink", art.Link);
            sqlCmd.Parameters.AddWithValue("@paralastupdated", art.LastUpdated);
            sqlCmd.Parameters.AddWithValue("@paradeleted", art.Deleted);


            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();

            myConn.Close();

            return result;
        }

        public int UpdateById(string id, string title, string description, string author, string link, string lastupdated)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Article SET title = @paratitle, description = @paradescription, author = @paraauthor, " +
                "link = @paralink, lastupdated = @paralastupdated WHERE id = @paraid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraid", id);
            sqlCmd.Parameters.AddWithValue("@paratitle", title);
            sqlCmd.Parameters.AddWithValue("@paradescription", description);
            sqlCmd.Parameters.AddWithValue("@paraauthor", author);
            sqlCmd.Parameters.AddWithValue("@paralink", link);
            sqlCmd.Parameters.AddWithValue("@paralastupdated", lastupdated);


            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();
            myConn.Close();

            return result;
        }

        public int DeleteById(string id, Boolean deleted)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Article SET deleted = @paradeleted WHERE id = @paraid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraid", id);
            sqlCmd.Parameters.AddWithValue("@paradeleted", deleted);


            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();
            myConn.Close();

            return result;
        }

        public int UpdateViewsById(string id, int views)
        {
            string DBConnect = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            string sqlStmt = "UPDATE Article SET views = @paraviews WHERE id = @paraid";

            int result = 0;    // Execute NonQuery return an integer value
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            sqlCmd.Parameters.AddWithValue("@paraid", id);
            sqlCmd.Parameters.AddWithValue("@paraviews", views);


            myConn.Open();
            result = sqlCmd.ExecuteNonQuery();
            myConn.Close();

            return result;
        }
    }
}