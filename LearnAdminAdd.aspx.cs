﻿using FinTrack.BLL;
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
            if (Validation())
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

        public List<String> errorList = new List<String>();

        private bool Validation()
        {
            bool result = true;

            if (String.IsNullOrEmpty(TextboxTitle.Text))
            {
                errorList.Add("Title cannot be empty. <br/>");
                result = false;
            }

            if (String.IsNullOrEmpty(TextboxAuthor.Text))
            {
                errorList.Add("Author cannot be empty. <br/>");
                result = false;
            }

            if (String.IsNullOrEmpty(TextboxDescription.Text))
            {
                errorList.Add("Description cannot be empty. <br/>");
                result = false;
            }

            return result;


        }
    }
}