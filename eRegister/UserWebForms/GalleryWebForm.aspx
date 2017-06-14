<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMasterPage.Master" AutoEventWireup="true" CodeBehind="GalleryWebForm.aspx.cs" Inherits="eRegister.UserWebForms.GalleryWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <div class="col-md-9">
        <div id="title" class="col-md-8" style="text-align: left">
            <h3>Галерия</h3>
        </div>
        <div class="col-md-4" style="text-align: right">
            <h3 style="text-align: left" id="lblHeader" runat="server">Качване на снимки</h3>
        </div>
              <asp:FileUpload ID="FileUpload1" runat="server" />
                <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click" />
                <asp:Panel ID="Panel1" runat="server" Width="100%" Height="100%" HorizontalAlign="Left"/>
		</div>
</asp:Content>

