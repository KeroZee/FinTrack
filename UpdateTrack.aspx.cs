using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class UpdateTrack : System.Web.UI.Page
    {
        DateTime now = DateTime.Today;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtID.Text = Session["SSID"].ToString();
                txtUpdateDesc.Text = Session["SSDescription"].ToString();
                ddlCat.SelectedItem.Text = Session["SSCategory"].ToString();
                txtUpdateCost.Text = Session["SSCost"].ToString();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                double cost = Convert.ToDouble(txtUpdateCost.Text);
                string desc = txtUpdateDesc.Text.ToString();
                int id = Convert.ToInt16(txtID.Text);
                Expense exp = new Expense();
                exp = new Expense(id, txtUpdateDesc.Text, ddlCat.Text, cost, now.Date);
                int result = exp.UpdateExpense();
                if (result == 1)
                {
                    LblMsg.Text = "Record updated successfully!";
                    LblMsg.ForeColor = Color.Green;
                    Response.Redirect("Track.aspx");
                }
                else
                {
                    LblMsg.Text = "Error in updating your record. Please contact our administrators!";
                    LblMsg.ForeColor = Color.Red;
                }

            }
        }
        private bool ValidateInput()
        {
            bool result;
            LblMsg.Text = String.Empty;

            if (String.IsNullOrEmpty(txtUpdateDesc.Text))
            {
                LblMsg.Text += "A Description is required!" + "<br/>";
            }
            double cost;
            result = double.TryParse(txtUpdateCost.Text, out cost);
            if (!result)
            {
                LblMsg.Text += "Cost of item is invalid!" + "<br/>";
            }

            if (String.IsNullOrEmpty(LblMsg.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}