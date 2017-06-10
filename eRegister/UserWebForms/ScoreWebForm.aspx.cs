using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eRegister.App_Model;
using System.Web.UI.HtmlControls;
using eRegister.Pages;

namespace eRegister.UserWebForms
{
    public partial class ScoreWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
          
            if (!Page.IsPostBack)
            {
                loadDropDownLists();
                loadAbsences();
            }
            
        }

        private void loadDropDownLists()
        {
            var db = new eRegisterContext();
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

        private void loadAbsences()
        {
            var db = new eRegisterContext();
            int currUserID = UserMasterPage.getCurrUser().UserID;

            var absencesList = from ab in db.Absences
                               join sub in db.Subjects
                               on ab.SubjectID equals sub.SubjectID
                               join abType in db.AbsenceTypes
                               on ab.AbsenceTypeID equals abType.AbsenceTypeID
                               orderby ab.Date
                               select new
                               {
                                   subject = sub.Name,
                                   type = abType.Absence,
                                   date = ab.Date
                               };
            if ( absencesList.Any())
            {
                gridViewAbsences.DataSource = absencesList.ToList();
                gridViewAbsences.DataBind();
                lblAbsences.Visible = false;
            }
            else
            {
                lblAbsences.Visible = true;
            }
        }
        private void loadScores()
        {
            var db = new eRegisterContext();

            int currUserID = UserMasterPage.getCurrUser().UserID;
            var listScore = from reg in db.Registers
                            join ac in db.Actors
                            on reg.StudentID equals ac.ActorID
                            join sc in db.ScoreTypes
                            on reg.ScoreTypeID equals sc.ScoreTypeID
                            where ac.UserID == currUserID
                            where reg.SubjectID == dropDownListSubjects.SelectedIndex
                            where reg.StudyYearID == dropDownListStudyYear.SelectedIndex
                            where reg.TermID == dropDownListTerm.SelectedIndex
                            orderby reg.Date
                            select new
                            {
                                date = reg.Date,
                                scoreType = sc.ScoreType1,
                                score = reg.ScoreNum
                            };
            if ( listScore.Any())
            {
                gridViewScore.DataSource = listScore.ToList();
                gridViewScore.DataBind();
                gridViewScore.Visible = true;
                lblWarningScore.Visible = false;
            }
            else
            {
                gridViewScore.Visible = false;
                lblWarningScore.Visible = true;
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
            if ( dropDownListStudyYear.SelectedIndex != 0 && dropDownListSubjects.SelectedIndex 
                != 0 && dropDownListTerm.SelectedIndex != 0 )
            {
                if (db.TeacherSubjects.Any(x => x.SubjectID == dropDownListSubjects.SelectedIndex))
                {
                    showTeacherLbl.Visible = true;
                    teacherLbl.InnerText = db.TeacherSubjects.FirstOrDefault(x => x.SubjectID == dropDownListSubjects.SelectedIndex).Actor.FirstName.ToString() + " " +
                        db.TeacherSubjects.FirstOrDefault(x => x.SubjectID == dropDownListSubjects.SelectedIndex).Actor.LastName.ToString();

                }
                else
                {
                    teacherLbl.InnerText = "";
                    showTeacherLbl.Visible = false;
                }
                loadScores();
            }
        }
    }
}