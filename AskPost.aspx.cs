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
        public string checkcomm;
        public string admin;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                if (Session["SId"] != null)
                {
                    if(Session["email"] != null)
                    {
                        Profiles profile = new Profiles();
                        profile = profile.GetProfileById(Session["email"].ToString());
                        checkcomm = profile.ID.ToString();
                        if (profile.Acc_type == "Admin")
                        {
                            admin = "yes";
                        }
                        else
                        {
                            admin = "";
                        }
                    }
                    
                    GetPosts();
                    GetComments();
                    CheckEdit();
                }
                else
                {
                    Response.Redirect("Ask.aspx");
                }
            }
           
        }
        public void ShowToastr(Page page, string message, string title, string type)
        {
            Page.ClientScript.RegisterStartupScript(page.GetType(), "toastr_message", "toast(" + "'" + message + "','" + title + "','" + type.ToLower() + "')", true);
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
        private void CheckEdit()
        {
            if (Session["email"] != null)
            {
                string email = Session["email"].ToString();
                string id = Session["SId"].ToString();
                Post post = new Post();
                post = post.GetPostById(id);
                Profiles profile = new Profiles();
                profile = profile.GetProfileById(email);
                if (profile.ID.ToString() == post.AccountId.ToString())
                {
                    BtnEdit.Visible = true;
                    BtnDelete.Visible = true;
                }
                else if(profile.Acc_type == "Admin")
                {
                    BtnEdit.Visible = true;
                    BtnDelete.Visible = true;
                }
                else
                {
                    BtnEdit.Visible = false;
                    BtnDelete.Visible = false;
                }
            }
            else
            {
                BtnEdit.Visible = false;
                BtnDelete.Visible = false;
                checkcomm = "";
            }
           


        }

        private void GetComments()
        {
            PostComment post = new PostComment();
            List<PostComment> list = post.GetAllCommentsById(Session["SId"].ToString());
            RefreshRepeater(list);

        }
        private void RefreshRepeater(List<PostComment> list)
        {
            PostRepeater.DataSource = list;
            PostRepeater.DataBind();
        }
        protected void LbtnLike_Click(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("Login.aspx");
            }   
            LinkButton b = (LinkButton)sender;

            Post post = new Post();
            post.UpdateLikesById(Session["SId"].ToString());
            GetPosts();
        }
        protected void LbtnDislike_Click(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            LinkButton b = (LinkButton)sender;

            Post post = new Post();
            post.UpdateDislikesById(Session["SId"].ToString());
            GetPosts();
        }
        protected void LbtnCommLike_Click(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            LinkButton b = (LinkButton)sender;

            PostComment post = new PostComment();
            post.UpdateLikesById(b.CommandName);
            GetComments();
        }
        protected void LbtnCommDislike_Click(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            LinkButton b = (LinkButton)sender;

            PostComment post = new PostComment();
            post.UpdateDislikesById(b.CommandName);
            GetComments();
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            string id = Session["SId"].ToString();
            Post post = new Post();
            post.DeletePostById(id);
            PostComment postcomm = new PostComment();
            postcomm.DeleteAllComments(id);
            Session["ToastMessage"] = "Question successfully deleted!";
            Session["ToastTitle"] = "Success";
            Session["ToastType"] = "success";
            Response.Redirect("Ask.aspx");
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            Session["SId"] = Session["SId"].ToString();
            Response.Redirect("AskUpdate.aspx");
        }
        protected void BtnDeleteComm_Click(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            Post update = new Post();
            LinkButton b = (LinkButton)sender;
            PostComment postcomm = new PostComment();
            postcomm.DeleteCommentsById(b.CommandName.ToString());
            update.UpdateCommentsById(Session["SId"].ToString());
            GetPosts();
            GetComments();
            ShowToastr(this, "Comment successfully deleted!", "Success", "success");
        }

        protected void BtnReply_Click(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (TbContent.Text != "")
            {
                Profiles profile = new Profiles();
                profile = profile.GetProfileById(Session["email"].ToString());
                PostComment post = new PostComment();
                string id = post.AutoIncrement();
                string postid = Session["SId"].ToString();
                string content = TbContent.Text.ToString();
                int likes = 0;
                int dislikes = 0;
                string dateposted = DateTime.Now.ToString("d/M/yyyy");
                string accountid = profile.ID.ToString();
                string username = profile.Fname + " " + profile.Lname;
                PostComment obj = new PostComment(id, postid, content, username, likes, dislikes, dateposted, accountid);
                Post update = new Post();
                int insPost = obj.CreateNewComment();
                if (insPost == 1)
                {
                    update.UpdateCommentsById(postid);
                    GetPosts();
                    GetComments();
                    CheckEdit();
                    TbContent.Text = "";
                    ShowToastr(this, "Comment successfully posted!", "Success", "success");
                }
            }
            else
            {
                ShowToastr(this, "You cannot post an empty comment!", "Error", "error");
            }

        }
    }
}
