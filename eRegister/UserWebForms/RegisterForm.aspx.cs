using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eRegister.App_Model;

namespace eRegister.UserWebForms
{
    public partial class RegisterForm : System.Web.UI.Page
    {

        App_Model.User newUser = new App_Model.User();
        Actor parrentActor = new Actor();
        protected void Page_Load(object sender, EventArgs e)
        {
            if ( !Page.IsPostBack )
            {
                onInitData();
                newUser = new App_Model.User();
                parrentActor = new Actor();
            }
        }

        private void onInitData()
        {
            var db = new eRegisterContext();
            var userTypes = db.UserTypes.ToList();

            dropDownListType.DataSource = userTypes;
            dropDownListType.DataValueField = "UserTypeID";
            dropDownListType.DataTextField = "Type";
            dropDownListType.DataBind();
            dropDownListType.Items.Insert(0, "Избери");

            var schools = db.Schools.ToList();

            dropDownListSchool.DataSource = schools;
            dropDownListSchool.DataValueField = "SchoolID";
            dropDownListSchool.DataTextField = "SchooName";
            dropDownListSchool.DataBind();
            dropDownListSchool.Items.Insert(0, "Избери");

            var divisionDetails = from divDet in db.ClassDevisionDetails
                                  join cl in db.Classes
                                  on divDet.ClassID equals cl.ClassID
                                  join div in db.Divisions
                                  on divDet.DivID equals div.DivisionID
                                  orderby divDet.ClassDevisionDetailsID ascending
                                  select new
                                  {
                                      classDivDetailsID = divDet.ClassDevisionDetailsID,
                                      classDivDetailsText = cl.Class1.ToString() + " " + div.Division1
                                  };

            dropDownListDivisionDetails.DataSource = divisionDetails.ToList();
            dropDownListDivisionDetails.DataValueField = "classDivDetailsID";
            dropDownListDivisionDetails.DataTextField = "classDivDetailsText";
            dropDownListDivisionDetails.DataBind();
            dropDownListDivisionDetails.Items.Insert(0, "Избери");

            dropDownListGender.Items.Insert(0, "Жена");
            dropDownListGender.Items.Insert(1, "Мъж");

            var cities = db.CityVillages.ToList();
            dropDownListTown.DataSource = cities;
            dropDownListTown.DataValueField = "CityVillageID";
            dropDownListTown.DataTextField = "Name";
            dropDownListTown.DataBind();
            dropDownListTown.Items.Insert(0, "Избери");

        }

        protected void dropDownListType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( dropDownListType.SelectedIndex == 1 )
            {
                showParrentInfo();
            }
            else
            {
                hideParrentInfo();
            }
        }

        private void showParrentInfo()
        {
            parrentHeader.Visible = true;
            lblParrentName.Visible = true;
            parrentName.Visible = true;
            lblParrentMName.Visible = true;
            parrentMName.Visible = true;
            lblParrentLName.Visible = true;
            parrentLName.Visible = true;
            lblParrentPhone.Visible = true;
            parrentPhone.Visible = true;
            RequiredFieldValidator12.Enabled = true;
            RequiredFieldValidator13.Enabled = true;
            RequiredFieldValidator14.Enabled = true;
            RequiredFieldValidator15.Enabled = true;
        }

        private void hideParrentInfo()
        {
            parrentHeader.Visible = false;
            lblParrentName.Visible = false;
            parrentName.Visible = false;
            lblParrentMName.Visible = false;
            parrentMName.Visible = false;
            lblParrentLName.Visible = false;
            parrentLName.Visible = false;
            lblParrentPhone.Visible = false;
            parrentPhone.Visible = false;
            RequiredFieldValidator12.Enabled = false;
            RequiredFieldValidator13.Enabled = false;
            RequiredFieldValidator14.Enabled = false;
            RequiredFieldValidator15.Enabled = false;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if ( inputPassword.Text != inputPasswordConfirm.Text )
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert(\" Паролата не съвпада!!! \");", true);
                inputPassword.Text = "";
                inputPasswordConfirm.Text = "";
                return;
            }
            if ( dropDownListType.SelectedIndex == 0  || dropDownListDivisionDetails.SelectedIndex == 0
                || dropDownListSchool.SelectedIndex == 0 || dropDownListTown.SelectedIndex == 0 )
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert(\" Не е избрана опция на някои от падащите менюта \");", true);
                inputPassword.Text = "";
                inputPasswordConfirm.Text = "";
                return;
            }
            saveUser();
            if( dropDownListType.SelectedIndex == 1 )
            {
                saveParrentActor();
            }
            saveActor();
            Response.Redirect("~/UserWebForms/AdminPage.aspx");

        }

        private void saveUser()
        {
            var db = new eRegisterContext();

            
            newUser.UserName = inputUsername.Text;
            newUser.Password = inputPassword.Text;
            newUser.UserTypeID = dropDownListType.SelectedIndex;
            db.Users.Add(newUser);
            db.SaveChanges();
            //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert(\" Потребителят е добавен успешно. \");", true);
        }

        private void saveActor()
        {
            var db = new eRegisterContext();

            Actor newActor = new Actor();

            newActor.FirstName = Name.Text;
            newActor.MiddleName = Midname.Text;
            newActor.LastName = Lastname.Text;
            newActor.Gender = Convert.ToBoolean(dropDownListGender.SelectedIndex);
            newActor.Address = Address.Text;
            newActor.EGN = PersonalID.Text;
            newActor.email = Email.Text;
            newActor.PhoneNumber = Number.Text;
            newActor.UserID = newUser.UserID;

            newActor.ClassDivisionID = dropDownListDivisionDetails.SelectedIndex;
            newActor.SchoolID = dropDownListSchool.SelectedIndex;
            newActor.CityVillageID = dropDownListTown.SelectedIndex;

            if ( dropDownListType.SelectedIndex == 1 )
            {
                newActor.ParentlID = parrentActor.ActorID;
            }

            db.Actors.Add(newActor);
            db.SaveChanges();

            
        }

        private void saveParrentActor()
        {
            var db = new eRegisterContext();
            parrentActor.FirstName = parrentName.Text;
            parrentActor.MiddleName = parrentMName.Text;
            parrentActor.LastName = parrentLName.Text;

            parrentActor.Gender = Convert.ToBoolean(dropDownListGender.SelectedIndex);
            parrentActor.Address = Address.Text;
            parrentActor.EGN = PersonalID.Text;
            parrentActor.email = Email.Text;
            parrentActor.PhoneNumber = parrentPhone.Text;
            db.Actors.Add(parrentActor);
            db.SaveChanges();
        }
    }
}