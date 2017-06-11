using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eRegister.App_Model;

namespace eRegister.UserWebForms
{
    public partial class AdminPage : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                loadStartPage();
            }
        }

        private void loadStartPage()
        {
            var db = new eRegisterContext();

            /**  Load cities in dropdownlist */
            var listOfCities = db.CityVillages.ToList();
            ddlCity.DataSource = listOfCities;
            ddlCity.DataValueField = "CityVillageID";
            ddlCity.DataTextField = "Name";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, "Град");

            /**  Load schools in dropdownlist */
            var listOfSchools = db.Schools.ToList();
            ddlSchool.DataSource = listOfSchools;
            ddlSchool.DataValueField = "SchoolID";
            ddlSchool.DataTextField = "SchooName";
            ddlSchool.DataBind();
            ddlSchool.Items.Insert(0, "Училище");

            /**  Load classes in dropdownlist */
            var listOfClasses = db.Classes.ToList();
            ddlClass.DataSource = listOfClasses;
            ddlClass.DataValueField = "ClassID";
            ddlClass.DataTextField = "Class1";
            ddlClass.DataBind();
            ddlClass.Items.Insert(0, "Клас");

            /**  Load gridview with users  */
            var userList = from us in db.Users
                           join ac in db.Actors
                           on us.UserID equals ac.UserID
                           join type in db.UserTypes
                           on us.UserTypeID equals type.UserTypeID
                           orderby us.UserID ascending
                           select new
                           {
                               UserID = us.UserID,
                               FullName = ac.FirstName + " " + ac.MiddleName + " " + ac.LastName,
                               Type = type.Type
                           };


            gridViewUsers.DataSource = userList.ToList();
            gridViewUsers.DataBind();
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new eRegisterContext();
            int cityId = ddlCity.SelectedIndex;

            /**  Load gridview with users  */
            var userList = from us in db.Users
                           join ac in db.Actors
                           on us.UserID equals ac.UserID
                           join type in db.UserTypes
                           on us.UserTypeID equals type.UserTypeID
                           where ac.CityVillageID == cityId
                           orderby us.UserID ascending
                           select new
                           {
                               UserID = us.UserID,
                               FullName = ac.FirstName + " " + ac.MiddleName + " " + ac.LastName,
                               Type = type.Type
                           };
            if ( ddlSchool.SelectedIndex != 0 && ddlClass.SelectedIndex != 0)
            {
                /**  Load gridview with users  */
                userList = from us in db.Users
                           join ac in db.Actors
                           on us.UserID equals ac.UserID
                           join type in db.UserTypes
                           on us.UserTypeID equals type.UserTypeID
                           join cd in db.ClassDevisionDetails
                           on ac.ClassDivisionID equals cd.ClassDevisionDetailsID
                           where ac.CityVillageID == cityId
                           where cd.ClassID == ddlClass.SelectedIndex
                           where ac.SchoolID == ddlSchool.SelectedIndex
                           orderby us.UserID ascending
                           select new
                           {
                               UserID = us.UserID,
                               FullName = ac.FirstName + " " + ac.MiddleName + " " + ac.LastName,
                               Type = type.Type
                           };
            }
            else if ( ddlClass.SelectedIndex != 0)
            {
                /**  Load gridview with users  */
                userList = from us in db.Users
                               join ac in db.Actors
                               on us.UserID equals ac.UserID
                               join type in db.UserTypes
                               on us.UserTypeID equals type.UserTypeID
                               join cd in db.ClassDevisionDetails
                               on ac.ClassDivisionID equals cd.ClassDevisionDetailsID
                               where ac.CityVillageID == cityId
                               where cd.ClassID == ddlClass.SelectedIndex
                               orderby us.UserID ascending
                               select new
                               {
                                   UserID = us.UserID,
                                   FullName = ac.FirstName + " " + ac.MiddleName + " " + ac.LastName,
                                   Type = type.Type
                               };
            }
           else if ( ddlSchool.SelectedIndex != 0 )
            {
                /**  Load gridview with users  */
                userList = from us in db.Users
                               join ac in db.Actors
                               on us.UserID equals ac.UserID
                               join type in db.UserTypes
                               on us.UserTypeID equals type.UserTypeID
                               where ac.CityVillageID == cityId
                               where ac.SchoolID == ddlSchool.SelectedIndex
                               orderby us.UserID ascending
                               select new
                               {
                                   UserID = us.UserID,
                                   FullName = ac.FirstName + " " + ac.MiddleName + " " + ac.LastName,
                                   Type = type.Type
                               };
            }
           
            if (userList.Any())
            {
                gridViewUsers.DataSource = userList.ToList();
                gridViewUsers.DataBind();
            }
            else
            {
                loadStartPage();
            }

        }

        protected void ddlSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new eRegisterContext();
            int schoolId = ddlSchool.SelectedIndex;
            /**  Load gridview with users  */
            var userList = from us in db.Users
                           join ac in db.Actors
                           on us.UserID equals ac.UserID
                           join type in db.UserTypes
                           on us.UserTypeID equals type.UserTypeID
                           where ac.SchoolID == schoolId
                           orderby us.UserID ascending
                           select new
                           {
                               UserID = us.UserID,
                               FullName = ac.FirstName + " " + ac.MiddleName + " " + ac.LastName,
                               Type = type.Type
                           };
            if ( ddlCity.SelectedIndex != 0 && ddlClass.SelectedIndex != 0 )
            {
                /**  Load gridview with users  */
                userList = from us in db.Users
                           join ac in db.Actors
                           on us.UserID equals ac.UserID
                           join type in db.UserTypes
                           on us.UserTypeID equals type.UserTypeID
                           join cd in db.ClassDevisionDetails
                           on ac.ClassDivisionID equals cd.ClassDevisionDetailsID
                           where ac.CityVillageID == ddlCity.SelectedIndex
                           where cd.ClassID == ddlClass.SelectedIndex
                           where ac.SchoolID == schoolId
                           orderby us.UserID ascending
                           select new
                           {
                               UserID = us.UserID,
                               FullName = ac.FirstName + " " + ac.MiddleName + " " + ac.LastName,
                               Type = type.Type
                           };
            }
            else if ( ddlCity.SelectedIndex != 0 )
            {
                /**  Load gridview with users  */
                userList = from us in db.Users
                           join ac in db.Actors
                           on us.UserID equals ac.UserID
                           join type in db.UserTypes
                           on us.UserTypeID equals type.UserTypeID
                           where ac.CityVillageID == ddlCity.SelectedIndex
                           where ac.SchoolID == schoolId
                           orderby us.UserID ascending
                           select new
                           {
                               UserID = us.UserID,
                               FullName = ac.FirstName + " " + ac.MiddleName + " " + ac.LastName,
                               Type = type.Type
                           };
            }
            else if ( ddlClass.SelectedIndex != 0 )
            {
                /**  Load gridview with users  */
                userList = from us in db.Users
                           join ac in db.Actors
                           on us.UserID equals ac.UserID
                           join type in db.UserTypes
                           on us.UserTypeID equals type.UserTypeID
                           join cd in db.ClassDevisionDetails
                           on ac.ClassDivisionID equals cd.ClassDevisionDetailsID
                           where cd.ClassID == ddlClass.SelectedIndex
                           where ac.SchoolID == schoolId
                           orderby us.UserID ascending
                           select new
                           {
                               UserID = us.UserID,
                               FullName = ac.FirstName + " " + ac.MiddleName + " " + ac.LastName,
                               Type = type.Type
                           };
            }

            if (userList.Any())
            {
                gridViewUsers.DataSource = userList.ToList();
                gridViewUsers.DataBind();
            }
            else
            {
                loadStartPage();
            }
        }

        protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new eRegisterContext();
            int classId = ddlClass.SelectedIndex;
            /**  Load gridview with users  */
            var userList = from us in db.Users
                           join ac in db.Actors
                           on us.UserID equals ac.UserID
                           join type in db.UserTypes
                           on us.UserTypeID equals type.UserTypeID
                           join cd in db.ClassDevisionDetails
                           on ac.ClassDivisionID equals cd.ClassDevisionDetailsID
                           where cd.ClassID == classId
                           orderby us.UserID ascending
                           select new
                           {
                               UserID = us.UserID,
                               FullName = ac.FirstName + " " + ac.MiddleName + " " + ac.LastName,
                               Type = type.Type
                           };

            if ( ddlCity.SelectedIndex != 0 && ddlSchool.SelectedIndex != 0 )
            {
                /**  Load gridview with users  */
                userList = from us in db.Users
                           join ac in db.Actors
                           on us.UserID equals ac.UserID
                           join type in db.UserTypes
                           on us.UserTypeID equals type.UserTypeID
                           join cd in db.ClassDevisionDetails
                           on ac.ClassDivisionID equals cd.ClassDevisionDetailsID
                           where ac.CityVillageID == ddlCity.SelectedIndex
                           where cd.ClassID == classId
                           where ac.SchoolID == ddlSchool.SelectedIndex
                           orderby us.UserID ascending
                           select new
                           {
                               UserID = us.UserID,
                               FullName = ac.FirstName + " " + ac.MiddleName + " " + ac.LastName,
                               Type = type.Type
                           };
            }
            else if ( ddlCity.SelectedIndex != 0 )
            {
                /**  Load gridview with users  */
                userList = from us in db.Users
                           join ac in db.Actors
                           on us.UserID equals ac.UserID
                           join type in db.UserTypes
                           on us.UserTypeID equals type.UserTypeID
                           join cd in db.ClassDevisionDetails
                           on ac.ClassDivisionID equals cd.ClassDevisionDetailsID
                           where ac.CityVillageID == ddlCity.SelectedIndex
                           where cd.ClassID == classId
                           orderby us.UserID ascending
                           select new
                           {
                               UserID = us.UserID,
                               FullName = ac.FirstName + " " + ac.MiddleName + " " + ac.LastName,
                               Type = type.Type
                           };
            }
            else if ( ddlSchool.SelectedIndex != 0 )
            {
                /**  Load gridview with users  */
                userList = from us in db.Users
                           join ac in db.Actors
                           on us.UserID equals ac.UserID
                           join type in db.UserTypes
                           on us.UserTypeID equals type.UserTypeID
                           join cd in db.ClassDevisionDetails
                           on ac.ClassDivisionID equals cd.ClassDevisionDetailsID
                           where cd.ClassID == classId
                           where ac.SchoolID == ddlSchool.SelectedIndex
                           orderby us.UserID ascending
                           select new
                           {
                               UserID = us.UserID,
                               FullName = ac.FirstName + " " + ac.MiddleName + " " + ac.LastName,
                               Type = type.Type
                           };
            }

            if (userList.Any())
            {
                gridViewUsers.DataSource = userList.ToList();
                gridViewUsers.DataBind();
            }
            else
            {
                loadStartPage();
            }
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            ddlCity.SelectedIndex = 0;
            ddlClass.SelectedIndex = 0;
            ddlSchool.SelectedIndex = 0;
            var db = new eRegisterContext();
            var userList = from us in db.Users
                                join ac in db.Actors
                                on us.UserID equals ac.UserID
                                join type in db.UserTypes
                                on us.UserTypeID equals type.UserTypeID
                                orderby us.UserID ascending
                                select new
                                {
                                    UserID = us.UserID,
                                    FullName = ac.FirstName + " " + ac.MiddleName + " " + ac.LastName,
                                    Type = type.Type
                                };
            userList.Where(x => x.FullName.ToLower().Contains(txtSearch.Text.ToLower()) == true).ToList();
            if( userList.Any(x => x.FullName.ToLower().Contains(txtSearch.Text.ToLower()) == true))
            {
                gridViewUsers.DataSource = userList.Where(x => x.FullName.ToLower().Contains(txtSearch.Text.ToLower()) == true).ToList();
                gridViewUsers.DataBind();
            }
            else
            {
                loadStartPage();
            }
            txtSearch.Text = "";
        }

        protected void gridViewUsers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gridViewUsers.PageIndex = e.NewPageIndex;
            loadStartPage();
        }

        protected void RegClick(object sender, EventArgs e)
        {
            Response.Redirect("~/UserWebForms/RegisterForm.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserWebForms/LogInForm.aspx");
        }

        protected void btnGallery_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UserWebForms/GalleryWebForm.aspx");
        }
    }
}