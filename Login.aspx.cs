using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click (object sender, EventArgs e){
            if (ValidateInput())
            {
                Response.Redirect("Profile.aspx");
            }
      
          
        }
        public List<String> errormsg = new List<String>();
        private bool ValidateInput()
        {
            bool result = true;

            if (String.IsNullOrEmpty(exampleInputEmail1.Text))
            {
                errormsg.Add("Please fill in your email");
                result = false;
            }
            if (String.IsNullOrEmpty(exampleInputPassword1.Text))
            {
                errormsg.Add("Please fill in your password");
                result = true;
            }
           
            return result;
        }

        
    }
}