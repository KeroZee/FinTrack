using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class AskCreate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }

        public void ShowToastr(Page page, string message, string title, string type)
        {
            Page.ClientScript.RegisterStartupScript(page.GetType(), "toastr_message", "toast(" + "'" + message + "','" + title + "','" + type.ToLower() + "')", true);
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (TbTitle.Text == "")
            {
                ShowToastr(this, "The title field cannot be empty!", "Error", "error");
            }
            else if (TbContent.Text == "")
            {
                ShowToastr(this, "The content field cannot be empty!", "Error", "error");
            }
            else
            {
                Profiles profile = new Profiles();
                profile = profile.GetProfileById(Session["email"].ToString());
                Post post = new Post();
                string id = post.AutoIncrement();
                string category = DdlCategory.SelectedValue.ToString();
                string title = TbTitle.Text.ToString();
                string content = TbContent.Text.ToString();
                int likes = 0;
                int dislikes = 0;
                int comment = 0;
                string dateposted = DateTime.Now.ToString("d/M/yyyy");
                string accountid = profile.ID.ToString();
                string username = profile.Fname + " " + profile.Lname;
                string approved = "No";
                Post obj = new Post(id, category, title, content, likes, dislikes, comment, dateposted, accountid, username, approved);
                int insPost = obj.CreateNewPost();
                if (insPost == 1)
                {
                    Session["ToastMessage"] = "Question successfully posted!";
                    Session["ToastTitle"] = "Success";
                    Session["ToastType"] = "success";
                    Response.Redirect("Ask.aspx");
                }
            }
                
        }
    }
}