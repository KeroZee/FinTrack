using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinTrack
{
    public partial class FinTrackMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["email"])!= null)
            {
                NotLoggedIn.Visible = false;
                LoggedIn.Visible = true;
            }
            else
            {
                NotLoggedIn.Visible = true;
                LoggedIn.Visible = false;
            }
        }

        
    }
}