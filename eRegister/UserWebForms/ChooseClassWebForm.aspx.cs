using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eRegister.App_Model;
using eRegister.Pages;

namespace eRegister.UserWebForms
{
    public partial class ChooseClassWebForm : System.Web.UI.Page
    {
        Actor currActor = new Actor();
        eRegisterContext db = new eRegisterContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            int userId = UserMasterPage.getCurrUser().UserID;
            currActor = db.Actors.FirstOrDefault(x => x.UserID == userId);
            if (!Page.IsPostBack)
            {
                
                
                onInitData();
            }
        }

        private void onInitData()
        {
            var listOfSubjects = db.Subjects.ToList();

            dropDownListSubjects.DataSource = listOfSubjects;
            dropDownListSubjects.DataValueField = "SubjectID";
            dropDownListSubjects.DataTextField = "Name";
            dropDownListSubjects.DataBind();
            dropDownListSubjects.Items.Insert(0, "Избери");

            if (db.TeacherSubjects.Any(x => x.TeacherID == currActor.ActorID))
            {
                int subId = db.TeacherSubjects.FirstOrDefault(x => x.TeacherID == currActor.ActorID).SubjectID;
                dropDownListSubjects.SelectedIndex = subId;
            }

            var listOfClasses = from clDivDet in db.ClassDevisionDetails
                                join div in db.Divisions
                                on clDivDet.DivID equals div.DivisionID
                                join cl in db.Classes
                                on clDivDet.ClassID equals cl.ClassID
                                orderby clDivDet.ClassDevisionDetailsID ascending
                                select new
                                {
                                    classDevDetailsID = clDivDet.ClassDevisionDetailsID,
                                    className = cl.Class1 + "-" + div.Division1
                                };
            dropDownListClass.DataSource = listOfClasses.ToList();
            dropDownListClass.DataValueField = "classDevDetailsID";
            dropDownListClass.DataTextField = "className";
            dropDownListClass.DataBind();
            dropDownListClass.Items.Insert(0, "Избери клас");



        }

        private void fillListOfStudentAbsences()
        {
            int classDevDetID = Int32.Parse(dropDownListClass.SelectedValue);
            var listOfStudents = from ac in db.Actors
                                 where ac.ClassDivisionID == classDevDetID
                                 orderby ac.FirstName ascending
                                 select new
                                 {
                                     actorId = ac.ActorID,
                                     name = ac.FirstName + " " + ac.MiddleName + " " + ac.LastName
                                 };
            listBoxStudentAbsences.DataSource = listOfStudents.ToList();
            listBoxStudentAbsences.DataValueField = "actorId";
            listBoxStudentAbsences.DataTextField = "name";
            listBoxStudentAbsences.DataBind();
            listBoxStudentAbsences.Visible = true;
        }

        private void fillListOfStudentScore()
        {
            int classDevDetID = Int32.Parse(dropDownListClass.SelectedValue);
            var listOfStudents = from ac in db.Actors
                                 where ac.ClassDivisionID == classDevDetID
                                 orderby ac.FirstName ascending
                                 select new
                                 {
                                     actorId = ac.ActorID,
                                     name = ac.FirstName + " " + ac.MiddleName + " " + ac.LastName
                                 };
            listBoxStudentsScore.DataSource = listOfStudents.ToList();
            listBoxStudentsScore.DataValueField = "actorId";
            listBoxStudentsScore.DataTextField = "name";
            listBoxStudentsScore.DataBind();
            listBoxStudentsScore.Visible = true;
        }

        private void fillDdlLists()
        {
            var studyYear = db.StudyYears.ToList();
            ddlStudyYear.DataSource = studyYear;
            ddlStudyYear.DataValueField = "StudyYearID";
            ddlStudyYear.DataTextField = "StudyYear1";
            ddlStudyYear.DataBind();
            ddlStudyYear.Items.Insert(0, "Избери");

            var scoreType = db.ScoreTypes.ToList();

            ddlScoreType.DataSource = scoreType;
            ddlScoreType.DataValueField = "ScoreTypeID";
            ddlScoreType.DataTextField = "ScoreType1";
            ddlScoreType.DataBind();
            ddlScoreType.Items.Insert(0, "Избери");

            ddlTerm.Items.Insert(0, "Избери");
            ddlTerm.Items.Add(new ListItem("Първи", "1"));
            ddlTerm.Items.Add(new ListItem("Втори", "2"));
        }

        protected void dropDownListSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void dropDownListClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropDownListClass.SelectedIndex != 0)
            {
                fillListOfStudentAbsences();
                fillListOfStudentScore();
                fillDdlLists();
            }
        }

        private void saveAbsences()
        {

            List<int> selectedStudents = new List<int>();
            foreach (ListItem item in listBoxStudentAbsences.Items)
            {
                if (item.Selected)
                {
                    selectedStudents.Add(Int32.Parse(item.Value));
                }
            }
            if (selectedStudents.Count() == 0 || dropDownListSubjects.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert(\" Не сте маркирали никого. Опитайте отново след като маркирате избраните ученици. \");", true);
                return;
            }

            for (int i = 0; i < selectedStudents.Count(); ++i)
            {
                Absence newAbsence = new Absence();
                newAbsence.StudentID = selectedStudents[i];
                newAbsence.SubjectID = (short)dropDownListSubjects.SelectedIndex;
                newAbsence.Excused = false;
                newAbsence.AbsenceTypeID = 2;
                newAbsence.Date = DateTime.Now.Date;
                db.Absences.Add(newAbsence);
                db.SaveChanges();
            }
            listBoxStudentAbsences.SelectedIndex = -1;
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert(\" Отсъстващите са записани. \");", true);
        }

        private void saveScore()
        {
            Register newReg = new Register();

            if (ddlTerm.SelectedIndex == 0 || ddlStudyYear.SelectedIndex == 0 || listBoxStudentsScore.SelectedIndex < 0
                || ddlScoreType.SelectedIndex == 0 || Decimal.Parse(txtScore.Text) < 2.00m || Decimal.Parse(txtScore.Text) > 6.00m)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert(\" Данните за записване на оценката са грешни или не всички полета са попълнени. \");", true);
                return;
            }

            newReg.StudentID = Int32.Parse(listBoxStudentsScore.SelectedValue);
            newReg.StudyYearID = ddlStudyYear.SelectedIndex;
            newReg.SubjectID = (short)dropDownListSubjects.SelectedIndex;
            newReg.ScoreNum = Decimal.Parse(txtScore.Text);
            newReg.ScoreTypeID = Byte.Parse(ddlScoreType.SelectedIndex.ToString());
            newReg.Date = DateTime.Now.Date;
            int teachId = currActor.ActorID;
            newReg.TeacherID = teachId;
            newReg.TermID = ddlTerm.SelectedIndex;
            db.Registers.Add(newReg);
            db.SaveChanges();
            listBoxStudentsScore.SelectedIndex = -1;
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert(\" Оценката е записана успешно. \");", true);
        }

        protected void btnSaveAbsences_Click(object sender, EventArgs e)
        {
            saveAbsences();
        }

        protected void btnSaveScore_Click(object sender, EventArgs e)
        {
            saveScore();
        }
    }
}