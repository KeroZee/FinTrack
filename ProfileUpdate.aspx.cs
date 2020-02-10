using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class ProfileUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Session["email"] != null)
                {
                    String email = Session["email"].ToString();
                    Profiles prof = new Profiles();
                    prof = prof.GetProfileById(email);
                    tbFname.Text = prof.Fname.ToString();
                    tbLname.Text = prof.Lname.ToString();
                    tbCountry.Text = prof.Country.ToString();
                    tbPhone.Text = prof.Phone.ToString();
                    tbLanguage.Text = prof.Language.ToString();
                    tbBio.Text = prof.Bio.ToString();
                    tbNickname.Text = prof.Nickname.ToString();
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Profiles prof = new Profiles();
            prof.UpdateProfile(Session["email"].ToString(), tbFname.Text, tbLname.Text, tbBio.Text, tbCountry.Text, tbPhone.Text, tbLanguage.Text, tbNickname.Text);
            Response.Redirect("Profile.aspx");
        }

    }
}