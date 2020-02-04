using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class AddProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            String fname = tbFname.Text.ToString();
            String lname = tbLname.Text.ToString();
            String country = tbCountry.Text.ToString();
            String phone = tbPhone.Text.ToString();
            String language = tbLanguage.Text.ToString();
            String bio = tbBio.Text.ToString();
            String nickname = tbNickname.Text.ToString();

            Profiles prof = new Profiles(-1 , "", "", fname, lname, bio, "", country, phone, language, nickname, "", 1);
            int count = prof.AddProfile();
            if(count == 1)
            {
                Response.Redirect("Profile.aspx");
            }
        }
    }
}