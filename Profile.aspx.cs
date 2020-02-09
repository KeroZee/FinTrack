using FinTrack.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) {
                    Profiles prof = new Profiles();
                    prof = prof.GetProfileById(Session["email"].ToString());
                    email.Text = "Email: " + prof.Email;
                    country.Text = "Country: " + prof.Country;
                    phone.Text = "Phone: " + prof.Phone;
                    language.Text = "Language: " + prof.Language;
                    nickname.Text = "Nickname" + prof.Nickname;
                
            }

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddProfile.aspx");
        }
    }
}