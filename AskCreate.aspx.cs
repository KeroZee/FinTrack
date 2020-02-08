﻿using FinTrack.BLL;
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

        }
        
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            Post post = new Post();
            string id = post.AutoIncrement();
            string category = DdlCategory.SelectedValue.ToString();
            string title = TbTitle.Text.ToString();
            string content = TbContent.Text.ToString();
            int likes = 0;
            int dislikes = 0;
            int comment = 0;
            string dateposted = DateTime.Now.ToString("d/M/yyyy");
            string accountid = post.AutoIncrement();
            string username = "Admin";
            string approved = "No";
            Post obj = new Post(id, category, title, content, likes, dislikes, comment, dateposted, accountid, username, approved);
            int insPost = obj.CreateNewPost();
            if (insPost == 1)
            {
                Response.Redirect("Ask.aspx");
            }
        }
    }
}