using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eRegister.App_Model;

namespace eRegister.Pages
{
    public partial class UserMasterPage : System.Web.UI.MasterPage
    {
        private static User currentUser = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                Session.Abandon();
                currentUser = null;
            }
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            var db = new eRegisterContext();
            if (CheckForUser())
            {
                if ( currentUser.UserTypeID == 2 )
                {
                    Response.Redirect("~/UserWebForms/AdminPage.aspx");
                }
                else
                {
                    Session["userid"] = currentUser.UserID;
                    Response.Redirect(string.Format("~/UserWebForms/ProfileWebForm.aspx?id={0}", db.Actors.First(x => x.UserID == currentUser.UserID).ActorID));
                }
                
            }
            else
            {
                inputUser.Text = "Wrong pass or user name!!!!";
            }
        }

        bool CheckForUser()
        {
            var db = new eRegisterContext();
            if (db.Users.Any(x => x.UserName == inputUser.Text && x.Password == inputPass.Text))
            {
                currentUser = db.Users.First(x => x.UserName == inputUser.Text && x.Password == inputPass.Text);
                return true;
            }

            return false;
        }

        public static User getCurrUser()
        {
            return currentUser;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserWebForms/RegisterForm.aspx");
        }
    }
}