using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public List<String> errorList = new List<String>();

        private bool ValidatedInput()
        {
            bool result = true;
            if (String.IsNullOrEmpty(TextBoxEmail.Text))
            {
                errorList.Add("Please enter your email. <br/>");
                result = false;
            }
            if (String.IsNullOrEmpty(TextBoxPassword.Text))
            {
                errorList.Add("Please enter your password. <br/>");
                result = false;
            }
            if(TextBoxPassword.Text != TextBoxCPassword.Text)
            {
                errorList.Add("Password and Confirm Password do not match. <br/>");
                result = false;
            }
            if (String.IsNullOrEmpty(TextBoxFname.Text))
            {
                errorList.Add("Please enter your First name. <br/>");
                result = false;
            }
            if (String.IsNullOrEmpty(TextBoxLname.Text))
            {
                errorList.Add("Please enter your Last name. <br/>");
            }
            return result;
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidatedInput()) { 

                String email = TextBoxEmail.Text.ToString();
                String password = TextBoxPassword.Text.ToString();
                String cppassword = TextBoxCPassword.Text.ToString();
                String fname = TextBoxFname.Text.ToString();
                String lname = TextBoxLname.Text.ToString();
            

                Profiles prof = new Profiles(-1, email, password, fname, lname, "",  "", "","", "", "" ,"" , 0);
                int insCnt = prof.AddProfile();
                if (insCnt == 1)
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

    }
}