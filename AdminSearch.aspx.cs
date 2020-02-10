using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class AdminSearch : System.Web.UI.Page
    {
        List<Expense> searchList;
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {
        }

        protected void gvExpense_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvExpense_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
            
        protected void btnSearch_Click1(object sender, EventArgs e)
        {
            Expense exp = new Expense();
            searchList = exp.RetrieveDataByEmail(txtSearch.Text);
            gvExpense.Visible = true;
            gvExpense.DataSource = searchList;
            gvExpense.DataBind();
        }
    }
}