﻿using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class AskUpdate : System.Web.UI.Page
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
                    TbTitle.Text = post.Title.ToString();
                    DdlCategory.Text = post.Category.ToString();
                    TbContent.Text = post.Content.ToString();
                }
                else
                {
                    Response.Redirect("Ask.aspx");
                }
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            Post post = new Post();
            post.UpdatePostById(Session["SId"].ToString(), DdlCategory.SelectedValue.ToString(), TbTitle.Text, TbContent.Text);
            Response.Redirect("Ask.aspx");
        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Session["SId"] = Session["SId"].ToString();
            Response.Redirect("AskPost.aspx");
        }
    }
}