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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            String email = TextBoxEmail.Text.ToString();
            String password = TextBoxPassword.Text.ToString();
            String cppassword = TextBoxCPassword.Text.ToString();
            

            Profiles prof = new Profiles(-1, email, password, "", "", "",  "", "","", "", "" ,"" , 1);
            int insCnt = prof.AddProfile();
            if (insCnt == 1)
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}