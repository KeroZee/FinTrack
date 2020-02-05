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
            LinkButton b = (LinkButton)sender;

            Session["ArtID"] = b.CommandName;

            string id = Session["ArtID"].ToString();

            Article art = new Article();
            art = art.GetArticleById(id);
            int views = art.Views += 1;

            int insCnt = art.UpdateViews(id, views);
            Response.Redirect("LearnDetailed.aspx");
        }

        protected void BtnAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LearnAdmin.aspx");
        }
    }
}