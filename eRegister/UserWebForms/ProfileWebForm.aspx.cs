using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eRegister.Pages;

namespace eRegister.UserWebForms
{
    public partial class ProfileWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if( UserMasterPage.getCurrUser() != null )
            {
                if ( Convert.ToInt32(Session["userid"]) == UserMasterPage.getCurrUser().UserID)
                {
                    LoadPage();
                }
                else
                {
                    Session.Abandon();
                    Response.Redirect("~/UserWebForms/LogInForm.aspx");
                }
            }
            else
            {
                Session.Abandon();
                Response.Redirect("~/UserWebForms/LogInForm.aspx");
            }
        }

        private void LoadPage()
        {

        }
    }
}