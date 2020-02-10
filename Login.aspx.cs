using FinTrack.BLL;
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

        public List<String> errorList = new List<String>();
        private bool Validated()
        {
            bool result = true;

            if (String.IsNullOrEmpty(exampleInputEmail1.Text))
            {
                errorList.Add("Please fill in your email. <br/>");
                result = false;
            }
            if (String.IsNullOrEmpty(exampleInputPassword1.Text))
            {
                errorList.Add("Please fill in your password. <br/>");
                result = false;
            }
           
            return result;
        }

        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            if (Validated())
            {
                String email = exampleInputEmail1.Text.Trim();
                String password = exampleInputPassword1.Text.Trim();

                Profiles prof = new Profiles();
                int Count = prof.LoginCheckBy(email,password);
                if(Count == 1) {
                
                    Session["email"] = exampleInputEmail1.Text;
                    Response.Redirect("Profile.aspx"); 
                }

                else
                {
                    errorList.Add("Please try again, credentials are wrong");
                }
            }
        }
    }
}