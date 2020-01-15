using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class Learn1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private void Fill()
        {
            Article article = new Article();
            List<Article> artList;
            artList = article.GetAllArticle();
        }

        private void Followup()
        {
            //Session["ArticleId"] = 
            Article article = new Article();
           // article = article.GetArticleById()
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("LearnDetailed.aspx");
        }
    }
}