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
            TbSearch.ToolTip = Session["SSearch"].ToString();
            GetPosts();
        }
        private void GetPosts()
        {
            string search = Session["SSearch"].ToString();
            Post post = new Post();
            List<Post> list = post.GetSearchPost(search);
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

        protected void LbtnSearch_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session["SSearch"] = TbSearch.Text.ToString();
            Response.Redirect("AskSearch.aspx");
        }
    }
}