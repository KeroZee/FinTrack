using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class Learn : System.Web.UI.Page
    {
        public List<Article> artList;
        protected void Page_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private void Fill()
        {
            Article article = new Article();
            artList = article.GetAllArticle();
        }

        private void Followup()
        {
            //Session["ArticleId"] = 
            Article article = new Article();
           // article = article.GetArticleById()
        }

        protected void BtnDetailed_Click(object sender, EventArgs e)
        {
            Response.Redirect("LearnDetailed.aspx");
        }

        protected void BtnAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LearnAdmin.aspx");
        }
    }
}