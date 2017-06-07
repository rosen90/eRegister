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
          
            if (!Page.IsPostBack)
            {
                if (db.Subjects.Any())
                {
                    var subjects = db.Subjects.ToList();
                    var studyYear = db.StudyYears.ToList();
                    
                    dropDownListSubjects.DataSource = subjects;
                    dropDownListSubjects.DataValueField = "SubjectID";
                    dropDownListSubjects.DataTextField = "Name";
                    dropDownListSubjects.DataBind();
                    dropDownListSubjects.Items.Insert(0, "Избери");

                    dropDownListStudyYear.DataSource = studyYear;
                    dropDownListStudyYear.DataValueField = "StudyYearID";
                    dropDownListStudyYear.DataTextField = "StudyYear1";
                    dropDownListStudyYear.DataBind();
                    dropDownListStudyYear.Items.Insert(0, "Избери");

                    dropDownListTerm.Items.Insert(0, "Избери");
                    dropDownListTerm.Items.Add(new ListItem("Първи", "1"));
                    dropDownListTerm.Items.Add(new ListItem("Втори", "2"));
                    

                }
            }
            
        }

        protected void dropDownListSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTeacherLabel();
        }

        protected void dropDownListStudyYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTeacherLabel();
        }

        protected void dropDownListTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            showTeacherLabel();
        }

        private void showTeacherLabel()
        {
            var db = new eRegisterContext();
            short selectedValue = Convert.ToInt16(dropDownListSubjects.SelectedValue);
            if ( dropDownListStudyYear.SelectedIndex != 0 && dropDownListSubjects.SelectedIndex 
                != 0 && dropDownListTerm.SelectedIndex != 0  && db.TeacherSubjects.Any(x => x.SubjectID == selectedValue))
            {
                
                showTeacherLbl.Visible = true;
                teacherLbl.InnerText = db.TeacherSubjects.FirstOrDefault(x => x.SubjectID == selectedValue).Actor.FirstName.ToString() + " " +
                    db.TeacherSubjects.FirstOrDefault(x => x.SubjectID == selectedValue).Actor.LastName.ToString();
            }
            else
            {
                teacherLbl.InnerText = "";
                showTeacherLbl.Visible = false;
            }
        }
    }
}