﻿using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new eRegisterContext();
            //WeekDay newWeekDay = new WeekDay
            //{
            //    WeekDayID = 0,
            //    WeekDay1 = "Monday"
            //};
            //db.WeekDays.Add(newWeekDay);
            //db.SaveChanges();

            exampleInputEmail1.Value = db.WeekDays.First().WeekDay1.ToString();
        }
    }
}