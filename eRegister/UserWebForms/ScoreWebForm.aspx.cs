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
                    subjectsList.DataSource = subjects;
                    subjectsList.DataBind();

                }
               
            }
            LoadTeacher();

            //if (!Page.IsPostBack)
            //{
            //    LoadDynamicallyHtmlCode();
            //}
            
        }

        void LoadTeacher()
        {
            var db = new eRegisterContext();
            teacherLbl.InnerText = db.TeacherSubjects.FirstOrDefault(x => x.SubjectID == subjectsList.SelectedIndex + 1).Actor.FirstName.ToString() + " " +
                db.TeacherSubjects.FirstOrDefault(x => x.SubjectID == subjectsList.SelectedIndex + 1).Actor.LastName.ToString();

        }

        private void LoadDynamicallyHtmlCode()
        {
            var db = new eRegisterContext();
            List<Subject> listSubjects = null;
            if (db.Subjects.Any())
            {
                listSubjects = db.Subjects.ToList();

            }
            string htmlCode = "";
            for (int i = 1; i <= listSubjects.Count; i++)
            {
                if ( i == 1 )
                {
                    htmlCode += "<div class=\"tab - pane fade active in\" ";
                }
                else
                {
                    htmlCode += "<div class=\"tab - pane fade\" ";
                }
                htmlCode += "id=\"set" + i.ToString() + "\"> \n <div class=\"tabbable score-info\"> <p> <label>Учител: </label> Иван Иванов";
                htmlCode += "</p> <p> <label>Оценки:" + i.ToString() + "</label> </p> <ul class=\"nav nav-tabs\">  <li class=\"active\"><a href = \"#sub11\" > Първи срок</a>";
                htmlCode += "</li>  <li><a href = \"#sub12\" > Втори срок</a>  </li>  </ul>";
                htmlCode += "<div class=\"tab -content\"> <div class=\"tab-pane fade active in\" id=\"sub11\">  <table class=\"table\">";
                htmlCode += "<thead>  <tr>  <th>#</th>  <th>Форма на контрол</th>  <th>Оценка</th>  <th>Дата</th>  </tr>  </thead>";
                htmlCode += "<tbody> <tr> <td>1</td>  <td>Текуща оценка</td>  <td>Много добър (5)</td>  <td>29.04.2017</td>  </tr>  <tr>";
                htmlCode += "<td>2</td> <td>Текуща оценка</td> <td>Добър (4)</td> <td>29.04.2017</td>  </tr> <tr>  <td>3</td>";
                htmlCode += "<td>Текуща оценка</td> <td>Много добър (5)</td> <td>29.04.2017</td> </tr> </tbody> </table>";
                htmlCode += "<label>Среден успех: </label> <span id = \"av -score\" > 4,66</span> </div> </div> </div> </div>";
                
            }
            divContent.InnerHtml = htmlCode;
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