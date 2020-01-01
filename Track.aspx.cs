using FinTrack.BLL;
using FinTrack.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
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
        List<Expense> expList;
        DateTime now = DateTime.Today;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RefreshGridView();
            }
        }

        private void RefreshGridView()
        {
            Expense exp = new Expense();
            expList = exp.GetAllExpense();
            gvExpense.Visible = true;
            gvExpense.DataSource = expList;
            gvExpense.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Expense exp = new Expense();
            if (ValidateInput())
            {
                double cost = Convert.ToDouble(txtCost.Text);
                exp = new Expense(exp.Id, txtDesc.Text, ddlCat.Text, cost, now.Date);

                int result = exp.AddExpense();
                if (result == 1)
                {
                    lblError.Text = "Record added successfully!";
                    lblError.ForeColor = Color.Green;
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
                lblError.Text += "Name is required!" + "<br/>";
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
            Session["SSCategory"] = row.Cells[1].Text;
            Session["SSDescription"] = row.Cells[2].Text;
            Session["SSCOst"] = row.Cells[3].Text;
            Session["SSDate"] = row.Cells[4].Text;
            //TODO : Redirect user to Update page to update whatever is needed.
        }

        protected void gvExpense_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString);
            SqlCommand cmd = null;

            int rowIndex = e.RowIndex;
            int sid = Convert.ToInt16(gvExpense.Rows[rowIndex].Cells[0].Text);

            con.Open();
            cmd = new SqlCommand("DELETE FROM Expense WHERE id = @id", con);
            cmd.Parameters.AddWithValue("@id", sid);
            cmd.ExecuteNonQuery();
            con.Close();

            gvExpense.EditIndex = -1;
            RefreshGridView();
        }

        protected void gvExpense_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Expense exp = new Expense();
            exp.GetAllExpense();
            RefreshGridView();
        }

        protected void gvExpense_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString);
            SqlCommand cmd = null;
            Expense exp = new Expense();

            int rowIndex = e.RowIndex;
            int sid = Convert.ToInt16(gvExpense.Rows[rowIndex].Cells[0].Text);

            DropDownList category = (DropDownList)gvExpense.Rows[rowIndex].Cells[1].FindControl("ddlCat");
            TextBox desc = (TextBox)gvExpense.Rows[rowIndex].Cells[2].Controls[0];
            TextBox cost = (TextBox)gvExpense.Rows[rowIndex].Cells[3].Controls[0];

            con.Open();
            cmd = new SqlCommand("UPDATE Expense SET category=@paraCategory, price=@paraPrice, description=@paradesc WHERE id=@id", con);
            cmd.Parameters.AddWithValue("@paraDesc", desc.Text);
            cmd.Parameters.AddWithValue("@paraCat", category.Text);
            cmd.Parameters.AddWithValue("@paraCost", cost.Text);
            cmd.Parameters.AddWithValue("@id", sid);
            cmd.ExecuteNonQuery();
            con.Close();

            gvExpense.EditIndex = -1;
            RefreshGridView();
        }
    }
}