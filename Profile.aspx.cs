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
                if(Session["email"] != null) { 
                    Profiles prof = new Profiles();
                    prof = prof.GetProfileById(Session["email"].ToString());
                    email.Text = "Email: " + prof.Email;
                    country.Text = "Country: " + prof.Country;
                    phone.Text = "Phone: " + prof.Phone;
                    language.Text = "Language: " + prof.Language;
                    nickname.Text = "Nickname: " + prof.Nickname;
                    Name.Text = prof.Fname + " " + prof.Lname;
                    bio.Text = prof.Bio;
                    Question.Text = prof.Question.ToString();
                    acc_type.Text = "Account type: " + prof.Acc_type.ToString();
                    date_joined.Text = "Date Joined: " + prof.Date_join.ToString();
                    dob.Text = "Date of Birth: " + prof.DOB.ToString();
                    imageshow.ImageUrl = prof.Avatar.ToString();


                }
                else
                {
                    Response.Redirect("Login.aspx");
                }

            }

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfileUpdate.aspx");
        }
    }
}