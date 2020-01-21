using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class Ask : System.Web.UI.Page
    {
        public List<Post> posts;
        protected void Page_Load(object sender, EventArgs e)
        {
            GetPosts();
        }
        private void GetPosts()
        {
            Post post = new Post();
            posts = post.GetAllPost();
        }


        protected void LbTitle_Click(object sender, EventArgs e)
        {
            LinkButton b = (LinkButton)sender;
            Session["STitle"] = b.ToolTip.ToString() + "Test";
            Response.Redirect("AskPost.aspx");
        }
    }
}