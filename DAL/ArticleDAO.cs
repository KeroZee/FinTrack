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
                string id = row["id"].ToString();
                string title = row["title"].ToString();
                int views = Convert.ToInt32(row["views"]);
                int likes = Convert.ToInt32(row["likes"]);
                int comments = Convert.ToInt32(row["comments"]);
                string description = row["description"].ToString();
                obj = new Article(id, title, views, likes, comments, description);
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
                DataRow row = ds.Tables[0].Rows[0];
                string id = row["id"].ToString();
                string title = row["title"].ToString();
                int views = Convert.ToInt32(row["views"]);
                int likes = Convert.ToInt32(row["likes"]);
                int comments = Convert.ToInt32(row["comments"]);
                string description = row["description"].ToString();
                Article obj = new Article(id, title, views, likes, comments, description);
                articleList.Add(obj);
            }

            return articleList;
        }
    }
}