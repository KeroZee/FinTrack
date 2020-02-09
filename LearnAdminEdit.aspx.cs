using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.IO;
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
                Article art = new Article();
                art = art.GetArticleById(id);

                String title = TextboxTitle.Text.ToString();                
                String description = TextboxDescription.Text.ToString();
                String author = TextboxAuthor.Text.ToString();
                var dateAndTime = DateTime.Now;
                String lastupdated = dateAndTime.ToShortDateString();
                String link = TextboxLink.Text.ToString();
                String image = "";

                if (UploadImage.HasFile)
                {
                    string filename = Path.GetFileName(UploadImage.FileName);
                    UploadImage.SaveAs(Server.MapPath("img/articleImages/") + filename);
                    image = ("img/articleImages/" + filename);
                }
                else
                {
                    image = art.Image;
                }

                //Get Article
               
                art = art.GetArticleById(id);
                int insCnt = art.UpdateArticle(id, title, description, image, author, link, lastupdated);
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

            if (TextboxTitle.Text.Length > 40)
            {
                errorList.Add("Title cannot be longer than 40 characters. <br/>");
                result = false;
            }

            if (String.IsNullOrEmpty(TextboxAuthor.Text))
            {
                errorList.Add("Author cannot be empty. <br/>");
                result = false;
            }

            if (TextboxAuthor.Text.Length > 24)
            {
                errorList.Add("Title cannot be longer than 24 characters. <br/>");
                result = false;
            }

            if (String.IsNullOrEmpty(TextboxDescription.Text))
            {
                errorList.Add("Description cannot be empty. <br/>");
                result = false;
            }

            if (String.IsNullOrEmpty(TextboxLink.Text))
            {
                errorList.Add("Link cannot be empty. <br/>");
                result = false;
            }

            if (UploadImage.HasFile)
            {
                if (UploadImage.PostedFile.ContentType != "image/jpeg")
                {
                    errorList.Add("Only jpeg files are accepted. <br/>");
                    result = false;
                }
                if (UploadImage.PostedFile.ContentLength > 1024000)
                {
                    errorList.Add("Image size cannot be larger than 1mb. <br/>");
                    result = false;
                }
            }

            return result;


        }
    }
}