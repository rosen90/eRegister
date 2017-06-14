<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMasterPage.Master" AutoEventWireup="true" CodeBehind="ChooseClassWebForm.aspx.cs" Inherits="eRegister.UserWebForms.ChooseClassWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">

    <div class="col-md-9 col-lg-9 col-sm-12 col-xs-12">
        <div class="col-md-6">
            <ul class="personal-info">
                <li><label>Изберете предмет:</label></li>
                <li><asp:DropDownList ID="dropDownListSubjects" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="dropDownListSubjects_SelectedIndexChanged" runat="server"></asp:DropDownList></li>
            </ul>
        </div>
        <div class="col-md-6">
            <ul class="personal-info">
                <li><label>Изберете клас:</label></li>
                <li><asp:DropDownList ID="dropDownListClass" AutoPostBack="true" OnSelectedIndexChanged="dropDownListClass_SelectedIndexChanged" CssClass="form-control" runat="server"></asp:DropDownList></li>
            </ul>
        </div>
    </div>
    <hr />
    <div class="col-md-9 col-lg-9 col-sm-12 col-xs-12">
        <div class="col-md-6">
            <ul class="personal-info">
                <li><label>Изберете отсъстващите:</label></li>
                <asp:ListBox ID="listBoxStudentAbsences" runat="server" SelectionMode="Multiple" Rows="10" Visible="false"></asp:ListBox>
                <asp:Button ID="btnSaveAbsences" runat="server" OnClick="btnSaveAbsences_Click" CssClass="btn btn-primary reg-btn first-reg" Text="Запиши отсъстващите"/>
            </ul>
        </div>
        <div class="col-md-6">
            <ul class="personal-info">
                <li><label>Оценка:</label></li>
                <asp:ListBox ID="listBoxStudentsScore" runat="server" SelectionMode="Single" Rows="10" Visible="false"></asp:ListBox>
                <asp:TextBox ID="txtScore" runat="server" placeholder="Въведи оценка" CssClass="form-control"></asp:TextBox>
                <asp:DropDownList ID="ddlStudyYear" runat="server" CssClass="form-control"></asp:DropDownList>
                <asp:DropDownList ID="ddlScoreType" runat="server" CssClass="form-control"></asp:DropDownList>
                <asp:DropDownList ID="ddlTerm" runat="server" CssClass="form-control"></asp:DropDownList>
                <asp:Button ID="btnSaveScore" runat="server" OnClick="btnSaveScore_Click" CssClass="btn btn-primary reg-btn first-reg" Text="Запиши оценка" />
            </ul>
        </div>
    </div>
</asp:Content>
