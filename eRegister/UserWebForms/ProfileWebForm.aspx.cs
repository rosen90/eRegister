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
            devisionLbl.InnerText = "";
            classLbl.InnerText = "";
            statusLbl.InnerText = "";
            if ( currentActor.ClassDivisionID != null && UserMasterPage.getCurrUser().UserTypeID == 1)
            {
                int divClassId = (int)currentActor.ClassDivisionID;
                int divId = db.ClassDevisionDetails.FirstOrDefault(x => x.ClassDevisionDetailsID == divClassId).DivID;
                devisionLbl.InnerText = db.Divisions.FirstOrDefault(x => x.DivisionID == divId).Division1;
                int classId = db.ClassDevisionDetails.FirstOrDefault(x => x.ClassDevisionDetailsID == divClassId).ClassID;
                classLbl.InnerText = db.Classes.FirstOrDefault(x => x.ClassID == classId).Class1.ToString();
                statusLbl.InnerText = getStudentStatus(currentActor.Status ?? false);
            }

            schoolAdressLbl.InnerText = currentActor.School.Address;
            
            if(UserMasterPage.getCurrUser().UserTypeID == 1 && currentActor.ParentlID != null)
            {
                int parId = (int)currentActor.ParentlID;
                Actor parrent = db.Actors.FirstOrDefault(x => x.ActorID == parId);
                lblParName.InnerText = parrent.FirstName + " " + parrent.MiddleName + " " + parrent.LastName;
                lblParNumber.InnerText = parrent.PhoneNumber;
                h3Parrent.Visible = true;
                lblParName.Visible = true;
                lblParNumber.Visible = true;
                lblPName.Visible = true;
                lblPNumber.Visible = true;
            }
            

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