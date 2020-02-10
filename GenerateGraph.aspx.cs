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
        Expense exp = new Expense();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetChartData();
            }
        }

        private void GetChartData()
        {
            DataTable dt = new DataTable();
            string cs = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select category, sum(price) from Expense group by category", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
            }
            string[] x = new string[dt.Rows.Count];
            int[] y = new int[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                x[i] = dt.Rows[i][0].ToString();
                y[i] = Convert.ToInt16(dt.Rows[i][1].ToString());
            }
            ExpenseChart.Series[0].Points.DataBindXY(x, y);
            ExpenseChart.Series[0].ChartType = SeriesChartType.StackedColumn;
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Category";
            chartArea.AxisY.Title = "Cost";

        }
    }
}