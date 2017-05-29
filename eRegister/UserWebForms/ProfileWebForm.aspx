<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMasterPage.Master" AutoEventWireup="true" CodeBehind="ProfileWebForm.aspx.cs" Inherits="eRegister.UserWebForms.ProfileWebForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
		
			<div class="col-md-9 col-lg-9 col-sm-12 col-xs-12">
				<div class="col-md-6">
				
					<ul class="personal-info">
						<li><h3>Персонална информация</h3></li>
						<hr/>
						<li><label>Име: </label> <label id="firstNameLbl" runat="server" style="font-weight:normal; font-style:normal; color:black">Иван </label></li>
						<li><label>Презиме: </label> <label id="middleNameLbl" runat="server" style="font-weight:normal; font-style:normal; color:black"> Иванов</label></li>
						<li><label>Фамилия: </label> <label id="lastNameLbl" runat="server" style="font-weight:normal; font-style:normal; color:black"> Иванов </label></li>
						<li><label>Пол: </label> <label id="genderLbl" runat="server" style="font-weight:normal; font-style:normal; color:black"> Mъж </label></li>
					</ul>
				</div>
				<div class="col-md-6">
					<ul class="personal-info">
						<li><h3>Контакти</h3></li>
						<hr/>
						<li><label>Телефон: </label> <label id="phoneLbl" runat="server" style="font-weight:normal; font-style:normal; color:black"> 0887 - 555 - 124 </label></li>
						<li><label>Email: </label> <label id="mailLbl" runat="server" style="font-weight:normal; font-style:normal; color:black"> ivan@abv.bg </label></li>
						<li><label>Адрес: </label> <label id="addressLbl" runat="server" style="font-weight:normal; font-style:normal; color:black"> гр. София, ж.к. Младост, бл. 204 </label></li>
						
					</ul>
				</div>




			</div>
			<div class="col-md-9 col-lg-9 col-sm-12 col-xs-12">
				<div class="col-md-6">
				
					<ul class="personal-info">
						<li><h3>Генерална информация</h3></li>
						<hr>
						<li><label>ЕГН:</label> <label id="egnLbl" runat="server" style="font-weight:normal; font-style:normal; color:black"> 9902255698 </label></li>
						<li><label>Училище: </label> <label id="schoolLbl" runat="server" style="font-weight:normal; font-style:normal; color:black">2-ра немска гимназия </label></li>
						<li><label>Паралелка: </label> <label id="devisionLbl" runat="server" style="font-weight:normal; font-style:normal; color:black"> A</label></li>
						<li><label>Клас: </label> <label id="classLbl" runat="server" style="font-weight:normal; font-style:normal; color:black">10</label></li>
						<li><label>Статус: </label> <label id="statusLbl" runat="server" style="font-weight:normal; font-style:normal; color:black">Учащ</label></li>
						<li><label>Град: </label> <label id="schoolAdressLbl" runat="server" style="font-weight:normal; font-style:normal; color:black">София</label></li>
					</ul>
				</div>
				<div class="col-md-6">
					<ul class="personal-info">
						<li><h3>Родител:</h3></li>
                        <hr/>
						<li><label>Име:</label> Петър Петров</li>
                        <li><label>Телефон:</label> +35988323425</li>
						
					</ul>
				</div>

			</div>
</asp:Content>
