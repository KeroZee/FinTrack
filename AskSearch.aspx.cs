﻿using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class AskSearch : System.Web.UI.Page
    {
        public List<Post> posts;
        readonly PagedDataSource _pgsource = new PagedDataSource();
        int _firstIndex, _lastIndex;
        private int _pageSize = 5;
        private int CurrentPage
        {
            get
            {
                if (ViewState["CurrentPage"] == null)
                {
                    return 0;
                }
                return ((int)ViewState["CurrentPage"]);
            }
            set
            {
                ViewState["CurrentPage"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                if (Session["SSearch"] != null)
                {
                    TbSearch.ToolTip = Session["SSearch"].ToString();
                    GetPosts();
                }
                else
                {
                    Response.Redirect("Ask.aspx");
                }
            }
                    
        }

        private void GetPosts()
        {
            string search = Session["SSearch"].ToString();
            Post post = new Post();
            DataTable list = post.GetSearchPopular(search);
            RefreshRepeater(list);

        }
        private void RefreshRepeater(DataTable list)
        {
            var dt = list;
            _pgsource.DataSource = dt.DefaultView;
            _pgsource.AllowPaging = true;
            // Number of items to be displayed in the Repeater
            _pgsource.PageSize = _pageSize;
            _pgsource.CurrentPageIndex = CurrentPage;
            // Keep the Total pages in View State
            ViewState["TotalPages"] = _pgsource.PageCount;
            // Example: "Page 1 of 10"
            lblpage.Text = "Page " + (CurrentPage + 1) + " of " + _pgsource.PageCount;
            // Enable First, Last, Previous, Next buttons
            lbPrevious.Enabled = !_pgsource.IsFirstPage;
            lbNext.Enabled = !_pgsource.IsLastPage;
            lbFirst.Enabled = !_pgsource.IsFirstPage;
            lbLast.Enabled = !_pgsource.IsLastPage;

            PostRepeater.DataSource = _pgsource;
            PostRepeater.DataBind();
            HandlePaging();
            int count = 0;
            foreach (var item in dt.DefaultView)
            {
                count++;
            }
            LblCategory.Text = "Results : " + count;
        }
        private void FilterSystem()
        {
            if (DdlCategory.SelectedValue == "")
            {
                if (DdlSort.SelectedValue == "Recent")
                {
                    Post post = new Post();
                    DataTable list = post.GetSearchRecent(Session["SSearch"].ToString());
                    RefreshRepeater(list);
                }
                else if (DdlSort.SelectedValue == "Oldest")
                {
                    Post post = new Post();
                    DataTable list = post.GetSearchOldest(Session["SSearch"].ToString());
                    RefreshRepeater(list);

                }
                else
                {
                    Post post = new Post();
                    DataTable list = post.GetSearchPopular(Session["SSearch"].ToString());
                    RefreshRepeater(list);
                }
            }
            else
            {
                if (DdlSort.SelectedValue == "Recent")
                {
                    Post postcate = new Post();
                    DataTable listcate = postcate.GetSearchRecentCate(Session["SSearch"].ToString(), DdlCategory.SelectedValue);
                    RefreshRepeater(listcate);
                }
                else if (DdlSort.SelectedValue == "Oldest")
                {
                    Post postcate = new Post();
                    DataTable listcate = postcate.GetSearchOldestCate(Session["SSearch"].ToString(), DdlCategory.SelectedValue);
                    RefreshRepeater(listcate);
                }
                else
                {
                    Post postcate = new Post();
                    DataTable listcate = postcate.GetSearchPopularCate(Session["SSearch"].ToString(), DdlCategory.SelectedValue);
                    RefreshRepeater(listcate);
                }
            }

        }
        private void HandlePaging()
        {
            var dt = new DataTable();
            dt.Columns.Add("PageIndex"); //Start from 0
            dt.Columns.Add("PageText"); //Start from 1

            _firstIndex = CurrentPage - 5;
            if (CurrentPage > 5)
                _lastIndex = CurrentPage + 5;
            else
                _lastIndex = 10;

            // Check last page is greater than total page then reduced it 
            // to total no. of page is last index
            if (_lastIndex > Convert.ToInt32(ViewState["TotalPages"]))
            {
                _lastIndex = Convert.ToInt32(ViewState["TotalPages"]);
                _firstIndex = _lastIndex - 10;
            }

            if (_firstIndex < 0)
                _firstIndex = 0;

            // Now creating page number based on above first and last page index
            for (var i = _firstIndex; i < _lastIndex; i++)
            {
                var dr = dt.NewRow();
                dr[0] = i;
                dr[1] = i + 1;
                dt.Rows.Add(dr);
            }

            rptPaging.DataSource = dt;
            rptPaging.DataBind();
        }

        protected void lbFirst_Click(object sender, EventArgs e)
        {
            CurrentPage = 0;
            FilterSystem();
        }
        protected void lbLast_Click(object sender, EventArgs e)
        {
            CurrentPage = Convert.ToInt32(ViewState["TotalPages"]) - 1;
            FilterSystem();
        }
        protected void lbPrevious_Click(object sender, EventArgs e)
        {
            CurrentPage -= 1;
            FilterSystem();
        }
        protected void lbNext_Click(object sender, EventArgs e)
        {
            CurrentPage += 1;
            FilterSystem();
        }

        protected void rptPaging_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (!e.CommandName.Equals("newPage")) return;
            CurrentPage = Convert.ToInt32(e.CommandArgument.ToString());
            FilterSystem();
        }

        protected void rptPaging_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            var lnkPage = (LinkButton)e.Item.FindControl("lbPaging");
            if (lnkPage.CommandArgument != CurrentPage.ToString()) return;
            lnkPage.Enabled = false;
            lnkPage.ForeColor = Color.Blue;
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
        protected void LbtnLike_Click(object sender, EventArgs e)
        {
            LinkButton b = (LinkButton)sender;

            Post post = new Post();
            post.UpdateLikesById(b.CommandName.ToString());
            CurrentPage = 0;
            FilterSystem();
            b.Enabled = false;
        }

        protected void LbtnDislike_Click(object sender, EventArgs e)
        {
            LinkButton b = (LinkButton)sender;

            Post post = new Post();
            post.UpdateDislikesById(b.CommandName.ToString());
            CurrentPage = 0;
            FilterSystem();
        }

        protected void DdlSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentPage = 0;
            FilterSystem();
        }

        protected void DdlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentPage = 0;
            FilterSystem();
        }
    }
}