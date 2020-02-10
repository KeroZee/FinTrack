using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class LearnDetailed : System.Web.UI.Page
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
                    LblTitle.Text = art.Title.ToString();
                    LblDescription.Text = art.Description.ToString();
                    LblDatePosted.Text = art.DatePosted.ToString();
                    LblAuthor.Text = art.Author.ToString();
                    LblLastUpdated.Text = art.LastUpdated.ToString();
                    LblViews.Text = art.Views.ToString();
                    Image.ImageUrl = art.Image.ToString();

                    var url = art.Link.ToString();
                    BtnLink.Attributes.Add("href", url);
                    BtnLink.Attributes.Add("target", "_blank");
                }
                else
                {
                    Response.Redirect("Learn.aspx");
                }
            }
        }

        protected void BtnLink_Click(object sender, EventArgs e)
        {
           
        }
    }
}