using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eRegister.App_Model;
using System.Web.UI.HtmlControls;

namespace eRegister.UserWebForms
{
    public partial class ScoreWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var db = new eRegisterContext();

            if (db.Subjects.Any())
            {
                var subjects = db.Subjects.ToList();
                subjectsList.DataSource = subjects;
                subjectsList.DataBind();
                
            }
        }

        protected void subjectsList_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.DataItemIndex == 0)
            {
                HtmlGenericControl myLi = (HtmlGenericControl)e.Item.FindControl("listElement");
                myLi.Attributes.Add("class","active");
            }

        }
    }
}