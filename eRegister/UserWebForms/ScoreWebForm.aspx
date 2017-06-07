<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMasterPage.Master" AutoEventWireup="true" CodeBehind="ScoreWebForm.aspx.cs" Inherits="eRegister.UserWebForms.ScoreWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <div class="col-md-9 col-lg-9 col-sm-12 col-xs-12">
        <div class="col-md-6">
            <ul class="personal-info">
                <li><label>Изберете предмет:</label></li>
                <li><asp:DropDownList ID="dropDownListSubjects" AutoPostBack="true" OnSelectedIndexChanged="dropDownListSubjects_SelectedIndexChanged" runat="server"></asp:DropDownList></li>
            </ul>
        </div>
        <div class="col-md-6">
            <ul class="personal-info">
                <li><label>Изберете учебна година:</label></li>
                <li><asp:DropDownList ID="dropDownListStudyYear" AutoPostBack="true" OnSelectedIndexChanged="dropDownListStudyYear_SelectedIndexChanged" runat="server"></asp:DropDownList></li>
            </ul>
        </div>
        <div class="col-md-6">
            <ul class="personal-info">
                <li><label>Изберете срок:</label></li>
                <li><asp:DropDownList ID="dropDownListTerm" AutoPostBack="true" OnSelectedIndexChanged="dropDownListTerm_SelectedIndexChanged" runat="server"></asp:DropDownList></li>
            </ul>
        </div>
    </div>
    <div class="col-md-9 col-lg-9 col-sm-12 col-xs-12">
        <div class="col-md-6">
            <ul class="personal-info">
                <li><label id="showTeacherLbl" visible="false" runat="server">Учител: </label> <label id="teacherLbl" runat="server"></label></li>
            </ul>
        </div>
	</div>
    <div class="col-md-9 col-lg-9 col-sm-12 col-xs-12">
        <div class="col-md-6">
            <ul class="personal-info">
                <li><label>Оценки: </label></li>
            </ul>
        </div>
    </div>
</asp:Content>
