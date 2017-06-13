﻿using System;
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
            if (!IsPostBack)
            {
                string[] filePaths = Directory.GetFiles(Server.MapPath("~/images/"));
                List<ListItem> files = new List<ListItem>();
                List<string> filesPaths = new List<string>();
                foreach (string filePath in filePaths)
                {
                    string fileName = "~/images/" + Path.GetFileName(filePath);
                    filesPaths.Add(fileName);
                    
                    //files.Add(new ListItem(fileName, "~/images/" + fileName));
                }

                lvPhotos.DataSource = filesPaths;
                lvPhotos.DataBind();
                //GridView1.DataSource = files;
                //GridView1.DataBind();

            }

            if ( UserMasterPage.getCurrUser().UserTypeID != 2)
            {
                lblHeader.InnerText = "";
                FileUpload1.Visible = false;
                btnUpload.Visible = false;
            }

        }

        protected void Upload(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/images/") + fileName);
                Response.Redirect(Request.Url.AbsoluteUri);
            }
        }
    }
}