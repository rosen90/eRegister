<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMasterPage.Master" AutoEventWireup="true" CodeBehind="ProfileWebForm.aspx.cs" Inherits="eRegister.UserWebForms.ProfileWebForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
		
			<div class="col-md-9 col-lg-9 col-sm-12 col-xs-12">
				<div class="col-md-6">
				
					<ul class="personal-info">
						<li><h3>Персонална информация</h3></li>
						<hr/>
						<li><label>Име:</label> Иван</li>
						<li><label>Презиме: </label> Иванов</li>
						<li><label>Фамилия: </label> Иванов</li>
						<li><label>Пол: </label> Mъж</li>
					</ul>
				</div>
				<div class="col-md-6">
					<ul class="personal-info">
						<li><h3>Контакти</h3></li>
						<hr/>
						<li><label>Телефон:</label> 0887 - 555 - 124;</li>
						<li><label>Email: </label> ivan@abv.bg; </li>
						<li><label>Адрес: </label> гр. София, ж.к. Младост, бл. 204;</li>
						
					</ul>
				</div>




			</div>
			<div class="col-md-9 col-lg-9 col-sm-12 col-xs-12">
				<div class="col-md-6">
				
					<ul class="personal-info">
						<li><h3>Генерална информация</h3></li>
						<hr>
						<li><label>ЕГН:</label> 9902255698</li>
						<li><label>Училище: </label> 2-ра немска гимназия</li>
						<li><label>Паралелка: </label> немски език</li>
						<li><label>Клас: </label> 10</li>
						<li><label>Статус: </label> Учащ</li>
						<li><label>Град: </label> София</li>
					</ul>
				</div>
				<div class="col-md-6">
                    <hr/>
					<ul class="personal-info">
						<li><h3>Съобщения:</h3></li>

						<div class="form-group">
						 
						  <textarea class="form-control" rows="5" id="comment"></textarea>
						</div>
						
					</ul>
				</div>

			</div>
</asp:Content>
