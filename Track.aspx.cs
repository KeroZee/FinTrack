using FinTrack.BLL;
using FinTrack.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class Track : System.Web.UI.Page
    {
        Expense exp = new Expense();
        List<Expense> expList;
        List<Expense> dateRangeList;
        public Boolean adminaccess = false;
        DateTime now = DateTime.Today;  
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["email"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                String email = Session["email"].ToString();
                Profiles prof = new Profiles();
                prof = prof.GetProfileById(email);
                var acctype = prof.Acc_type.ToString();

                if (acctype == "Admin")
                {
                    adminaccess = true;
                }
                else
                {
                    adminaccess = false;
                }
                RefreshGridView();
            }
        }

        private void RefreshGridView()
        {
            expList = exp.GetAllExpense(Session["email"].ToString());
            gvExpense.Visible = true;
            gvExpense.DataSource = expList;
            gvExpense.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                double cost = Convert.ToDouble(txtCost.Text);
                exp = new Expense(exp.Id, txtDesc.Text, ddlCat.Text, cost, now.Date, Session["email"].ToString());

                int result = exp.AddExpense(Session["email"].ToString());
                if (result == 1)
                {
                    lblError.Text = "Record added successfully!";
                    lblError.ForeColor = Color.Green;
                    txtDesc.Text = "";
                    txtCost.Text = "";
                    RefreshGridView();
                }
                else
                {
                    lblError.Text = "Error Adding into the System!";
                    lblError.ForeColor = Color.Red;
                }
            }
        }
        private bool ValidateInput()
        {
            lblError.Text = String.Empty;

            if (txtDesc.Text == "")
            {
                lblError.Text += "Description of the Expense is required!" + "<br/>";
            }
            if (String.IsNullOrEmpty(txtCost.Text))
            {
                lblError.Text += "Cost of item is required!" + "<br/>";
            }
            if (ddlCat.SelectedIndex == 0)
            {
                lblError.Text += "You must select a Category!" + "<br/>";
            }

            if (String.IsNullOrEmpty(lblError.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void gvExpense_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvExpense.SelectedRow;
            RefreshGridView();
            Session["SSID"] = row.Cells[0].Text;
            Session["SSCategory"] = row.Cells[1].Text;
            Session["SSDescription"] = row.Cells[2].Text;
            Session["SSCOst"] = row.Cells[3].Text;
            Response.Redirect("UpdateTrack.aspx");
        }

        protected void gvExpense_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int rowIndex = e.RowIndex;

            Expense exp = new Expense();
            exp.DeleteByRow(Convert.ToInt16(gvExpense.Rows[rowIndex].Cells[0].Text));

            gvExpense.EditIndex = -1;
            RefreshGridView();
        }

        protected void gvExpense_RowEditing(object sender, GridViewEditEventArgs e)
        {
        }

        protected void gvExpense_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            Expense exp = new Expense();
            dateRangeList = exp.FilterDate(txtStartDate.Text, txtEndDate.Text);
            gvExpense.Visible = true;
            gvExpense.DataSource = dateRangeList;
            gvExpense.DataBind();
        }

        protected void btnGenerateGraph_Click(object sender, EventArgs e)
        {
            Response.Redirect("GenerateGraph.aspx");
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminSearch.aspx");
        }
    }
}