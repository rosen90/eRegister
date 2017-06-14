using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using eRegister.Pages;

namespace eRegister.UserWebForms
{
    public partial class GalleryWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadImages();
            if ( UserMasterPage.getCurrUser().UserTypeID != 2)
            {
                lblHeader.Visible = false;
                FileUpload1.Visible = false;
                Button1.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/images/") + fileName);
            }
                 Response.Redirect(Request.Url.AbsoluteUri);
        }

        private void LoadImages()
        {
            foreach (string strfile in Directory.GetFiles(Server.MapPath("~/images")))
            {
                ImageButton imageButton = new ImageButton();
                FileInfo fi = new FileInfo(strfile);
                imageButton.ImageUrl = "~/images/" + fi.Name;
                imageButton.Height = Unit.Pixel(200);
                imageButton.Style.Add("padding", "5px");
                imageButton.Width = Unit.Pixel(160);
                imageButton.Click += new ImageClickEventHandler(imageButton_Click);
                Panel1.Controls.Add(imageButton);
            }
        }

        protected void imageButton_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("PhotoView.aspx?ImageURL=" +
                ((ImageButton)sender).ImageUrl);
        }
    }
}
