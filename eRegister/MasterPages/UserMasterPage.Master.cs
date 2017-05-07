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
                Session["userid"] = currentUser.UserID;
                Response.Redirect(string.Format("~/UserWebForms/ProfileWebForm.aspx?id={0}", db.Actors.First(x => x.UserID == currentUser.UserID).ActorID));
            }
            else
            {
                inputUser.Text = "Wrong pass or user name!!!!";
            }
        }

        bool CheckForUser()
        {
            var db = new eRegisterContext();
            currentUser = db.Users.First(x => x.UserName == inputUser.Text && x.Password == inputPass.Text);
            if (currentUser == null)
            {
                return false;
            }

            return true;
        }

        public static User getCurrUser()
        {
            return currentUser;
        }
    }
}