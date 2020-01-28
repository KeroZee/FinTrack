using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class AskPost : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                if (Session["SId"] != null)
                {
                    string id = Session["SId"].ToString();
                    Post post = new Post();
                    post = post.GetPostById(id);
                    LblCategory.Text = post.Category.ToString();
                    LblTitle.Text = post.Title.ToString();
                    LblContent.Text = post.Content.ToString();
                    LblUsername.Text = post.Username.ToString();
                    LblDate.Text = post.DatePosted.ToString();
                    LblLikes.Text = post.Likes.ToString();
                    LblDislikes.Text = post.Dislikes.ToString();
                    LblComments.Text = post.Comments.ToString();
                }
                else
                {
                    Response.Redirect("Ask.aspx");
                }
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            string id = Session["SId"].ToString();
            Post post = new Post();
            post.DeletePostById(id);
            Response.Redirect("Ask.aspx");
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            Session["SId"] = Session["SId"].ToString();
            Response.Redirect("AskUpdate.aspx");
        }
    }
}
