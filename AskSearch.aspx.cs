using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class AskSearch : System.Web.UI.Page
    {
        public List<Post> posts;
        protected void Page_Load(object sender, EventArgs e)
        {
            GetPosts();
        }
        private void GetPosts()
        {
            Post post = new Post();
            List<Post> list = post.GetAllPost();
            if (list != null)
            {
                RefreshRepeater(list);
            }
            else
            {

            }

        }
        private void RefreshRepeater(List<Post> list)
        {
            PostRepeater.DataSource = list;
            PostRepeater.DataBind();
        }
        protected void LbTitle_Click(object sender, EventArgs e)
        {
            LinkButton b = (LinkButton)sender;

            Session["STitle"] = b.Text;
            Session["SId"] = b.CommandName;
            Response.Redirect("AskPost.aspx");
        }
    }
}