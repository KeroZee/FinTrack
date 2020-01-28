using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class LearnAdminAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            String title = TextboxTitle.Text.ToString();
            int views = 0;
            int likes = 0;
            int comments = 0;
            String description = TextboxDescription.Text.ToString();
            String image = "";
            var dateAndTime = DateTime.Now;
            String dateposted = dateAndTime.ToShortDateString();
            String author = TextboxAuthor.Text.ToString();

            //Instantiate object
            Article art = new Article(title, views, likes, comments, description, image, dateposted, author);
            int insCnt = art.AddArticle();
            Response.Redirect("LearnAdmin.aspx");
        }
    }
}