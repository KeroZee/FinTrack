using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class LearnAdminEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                if (Session["ArtID"] != null)
                {
                    string id = Session["ArtID"].ToString();
                    Article art = new Article();
                    art = art.GetArticleById(id);
                    TextboxTitle.Text = art.Title.ToString();
                    TextboxDescription.Text = art.Description.ToString();
                    TextboxAuthor.Text = art.Author.ToString();
                    TextboxLink.Text = art.Link.ToString();
                }
                else
                {
                    Response.Redirect("LearnAdmin.aspx");
                }
            }
        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                string id = Session["ArtID"].ToString();
                String title = TextboxTitle.Text.ToString();                
                String description = TextboxDescription.Text.ToString();
                String author = TextboxAuthor.Text.ToString();
                var dateAndTime = DateTime.Now;
                String lastupdated = dateAndTime.ToShortDateString();
                String link = TextboxLink.Text.ToString();

                //Get Article

                Article art = new Article();
                art = art.GetArticleById(id);
                int insCnt = art.UpdateArticle(id, title, description, author, link, lastupdated);
                Response.Redirect("LearnAdmin.aspx");
            }
        }

        public List<String> errorList = new List<String>();

        private bool Validation()
        {
            bool result = true;

            if (String.IsNullOrEmpty(TextboxTitle.Text))
            {
                errorList.Add("Title cannot be empty. <br/>");
                result = false;
            }

            if (String.IsNullOrEmpty(TextboxAuthor.Text))
            {
                errorList.Add("Author cannot be empty. <br/>");
                result = false;
            }

            if (String.IsNullOrEmpty(TextboxDescription.Text))
            {
                errorList.Add("Description cannot be empty. <br/>");
                result = false;
            }

            return result;


        }
    }
}