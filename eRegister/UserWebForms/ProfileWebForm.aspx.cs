using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eRegister.Pages;
using eRegister.App_Model;

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
            var db = new eRegisterContext();
            Actor currentActor = new Actor();
            int userId = Convert.ToInt32(Session["userid"]);
            if (db.Actors.Any(x => x.UserID == userId))
            {
                currentActor = db.Actors.First(x => x.UserID == userId);
            }
            else
            {
                Session.Abandon();
                Response.Redirect("~/UserWebForms/LogInForm.aspx");
            }
            firstNameLbl.InnerText = currentActor.FirstName;
            middleNameLbl.InnerText = currentActor.MiddleName;
            lastNameLbl.InnerText = currentActor.LastName;
            genderLbl.InnerText = getGender(currentActor.Gender);
            phoneLbl.InnerText = currentActor.PhoneNumber;
            mailLbl.InnerText = currentActor.email;
            addressLbl.InnerText = currentActor.Address;
            egnLbl.InnerText = currentActor.EGN;
            schoolLbl.InnerText = currentActor.School.SchooName;
            devisionLbl.InnerText = currentActor.ClassDevisionDetails.FirstOrDefault().Division.Division1;
            classLbl.InnerText = currentActor.ClassDevisionDetails.FirstOrDefault().Class.Class1.ToString();
            statusLbl.InnerText = getStudentStatus(currentActor.Status ?? false);
            schoolAdressLbl.InnerText = currentActor.School.Address;
            
        }

        private string getGender( bool gender)
        {
            if ( gender)
            {
                return "Мъж";
            }
            return "Жена";
        }
        private string getStudentStatus (bool status)
        {
            if (status)
            {
                return "Учащ";
            }
            return "Прекъснал";
        }
    }
}