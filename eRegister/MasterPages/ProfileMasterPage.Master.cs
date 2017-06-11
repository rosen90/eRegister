using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eRegister.Pages;

namespace eRegister.MasterPages
{
    public partial class ProfileMasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( UserMasterPage.getCurrUser().UserTypeID == 4 )
            {
                btnChoose.Visible = true;
            }
            if ( UserMasterPage.getCurrUser().UserTypeID == 2)
            {
                btnProfile.Visible = false;
                btnScores.Visible = false;
            }
            else
            {
                btnAdminPage.Visible = false;
            }
        }

        protected void btnScores_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserWebForms/ScoreWebForm.aspx");
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

        protected void btnChoose_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserWebForms/ChooseClassWebForm.aspx");
        }

        protected void btnAdminPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserWebForms/AdminPage.aspx");
        }
    }
}