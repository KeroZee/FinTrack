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
                    
                    GetPosts();
                    GetComments();
                }
                else
                {
                    Response.Redirect("Ask.aspx");
                }
            }
           
        }

        private void GetPosts()
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

        private void GetComments()
        {
            PostComment post = new PostComment();
            List<PostComment> list = post.GetAllCommentsById(Session["SId"].ToString());
            if (list != null)
            {
                RefreshRepeater(list);
            }
            else
            {

            }
        }
        private void RefreshRepeater(List<PostComment> list)
        {
            PostRepeater.DataSource = list;
            PostRepeater.DataBind();
        }
        protected void LbtnLike_Click(object sender, EventArgs e)
        {
            LinkButton b = (LinkButton)sender;

            Post post = new Post();
            post.UpdateLikesById(Session["SId"].ToString());
            GetPosts();
        }

        protected void LbtnDislike_Click(object sender, EventArgs e)
        {
            LinkButton b = (LinkButton)sender;

            Post post = new Post();
            post.UpdateDislikesById(Session["SId"].ToString());
            GetPosts();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            string id = Session["SId"].ToString();
            Post post = new Post();
            post.DeletePostById(id);
            PostComment postcomm = new PostComment();
            postcomm.DeleteCommentsById(id);
            Response.Redirect("Ask.aspx");
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            Session["SId"] = Session["SId"].ToString();
            Response.Redirect("AskUpdate.aspx");
        }

        protected void BtnReply_Click(object sender, EventArgs e)
        {
            PostComment post = new PostComment();
            string id = post.AutoIncrement();
            string postid = Session["SId"].ToString();
            string content = TbContent.Text.ToString();
            int likes = 0;
            int dislikes = 0;
            int comment = 0;
            string dateposted = DateTime.Now.ToString("d/M/yyyy");
            string accountid = post.AutoIncrement();
            string username = "Commenter";
            PostComment obj = new PostComment(id, postid, content, username, likes, dislikes, dateposted, accountid);
            Post update = new Post();
            int insPost = obj.CreateNewComment();
            if (insPost == 1)
            {
                update.UpdateCommentsById(postid);
                GetPosts();
                GetComments();
                TbContent.Text = "";
            }
        }
    }
}
