using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eRegister.MasterPages
{
    public partial class ProfileMasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnScores_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserWebForms/ScoreWebForm.aspx");
        }

        protected void btnMessages_Click(object sender, EventArgs e)
        {

        }

        protected void btnGallery_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserWebForms/GalleryWebForm.aspx");
        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserWebForms/ProfileWebForm.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserWebForms/LogInForm.aspx");
        }
    }
}