﻿using System;
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
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlSchool_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}