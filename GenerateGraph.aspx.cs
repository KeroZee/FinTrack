using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class GenerateGraph : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetChartTypes();
                GetChartData();
            }
        }

        private void GetChartData()
        {

            string cs = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Select price, date, category from Expense", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                ExpenseChart.Series["ExpenseSeries"].XValueMember = "date";
                ExpenseChart.Series["ExpenseSeries"].YValueMembers = "category";
                ExpenseChart.DataSource = rdr;
                ExpenseChart.DataBind();
            }

        }
        private void GetChartTypes()
        {
            foreach(int chartType in Enum.GetValues(typeof(SeriesChartType)))
            {
                ListItem li = new ListItem(Enum.GetName(typeof(SeriesChartType), chartType), chartType.ToString());
                ddlGraphType.Items.Add(li);
            }
        }

        protected void ddlGraphType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ExpenseChart.Series["ExpenseSeries"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), ddlGraphType.SelectedValue);
        }
    }
}