using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class LearnAdmin : System.Web.UI.Page
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

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("LearnAdminAdd.aspx");
        }
    }
}