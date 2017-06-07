<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="eRegister.UserWebForms.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>E-register</title>
	<meta charset="utf-8"/>
	<meta name="viewport" content="width=device-width, initial-scale=1"/>
	<link rel="stylesheet" href="../css/bootstrap.min.css"/>
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.0/jquery.min.js"></script>
	<script src="../js/bootstrap.min.js"></script>
	<link rel="stylesheet" type="text/css" href="../css/style.css" />

</head>
<body>
    <form id="form1" runat="server">
      <div class="container">
		<div class="content">
			<div class="row">
				 <div class="logo">
				 	<div class="col-md-3">
						<img src="../resources/logo.png" width="30%" align="left"/>
					</div>	
					<div class="col-md-9">
						<h3>E-register</h3>
					</div>		
				 </div>
			</div>
             <hr/>
            <!-- Content -->
		<div class="row" style="padding: 20px">
			<div class="col-md-9 cp-title">
				<h3>Административен панел</h3>
			</div>

			<div class="col-md-3" style="text-align: right;">
				<button class="btn btn-primary exit-btn">Изход</button>
			</div>
		</div>

		<div class="row selection">
			<div class="col-md-3">
                <asp:DropDownList ID="ddlCity" CssClass="form-control" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged" runat="server"></asp:DropDownList>
			</div>

			<div class="col-md-3">
                <asp:DropDownList ID="ddlSchool" CssClass="form-control" OnSelectedIndexChanged="ddlSchool_SelectedIndexChanged" runat="server"></asp:DropDownList>
			</div>

			<div class="col-md-3">
                <asp:DropDownList ID="ddlClass" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlClass_SelectedIndexChanged"></asp:DropDownList>
			</div>
		</div>

		<div class="row">
			<div class="col-md-3 cp-title">
				<h3>Профили</h3>
			</div>

			<div class="col-md-3" style="text-align: left;">
				<form  class="search-form">
                	<div class="form-group has-feedback">
	            		<label for="search" class="sr-only">Търси</label>
	            		<input type="text" class="form-control" name="search" id="search" placeholder="Търси...">
	              		<span class="glyphicon glyphicon-search form-control-feedback"></span>
	            	</div>
            	</form>
			</div>	
		</div>

		<div class="row">

			<div class="col-md-6">
				<table class="table">
				    <thead>
				      <tr>
				        <th>#</th>
				        <th>Име</th>
				        <th>Тип</th>				        
				      </tr>
				    </thead>
				    <tbody>
				      <tr>
				        <td>1</td>
				        <td>Иван Петров Петров</td>
				        <td>Ученик</td>
				      </tr>
				      <tr>
				        <td>2</td>
				        <td>Петър Иванов Иванов</td>
				        <td>Родител</td>
				      </tr>
				      <tr>
				        <td>3</td>
				        <td>Галя Иванова Иванова</td>
				        <td>Учител</td>
				      </tr>
				      <tr>
				        <td>1</td>
				        <td>Иван Петров Петров</td>
				        <td>Ученик</td>
				      </tr>
				      <tr>
				        <td>2</td>
				        <td>Петър Иванов Иванов</td>
				        <td>Родител</td>
				      </tr>
				      <tr>
				        <td>3</td>
				        <td>Галя Иванова Иванова</td>
				        <td>Учител</td>
				      </tr><tr>
				        <td>1</td>
				        <td>Иван Петров Петров</td>
				        <td>Ученик</td>
				      </tr>
				      <tr>
				        <td>2</td>
				        <td>Петър Иванов Иванов</td>
				        <td>Родител</td>
				      </tr>
				      <tr>
				        <td>3</td>
				        <td>Галя Иванова Иванова</td>
				        <td>Учител</td>
				      </tr>
				    </tbody>
				</table>
			</div>

			<div class="col-md-3" style="position: relative; margin-top: 33px; padding-left: 18px">
				<button class="btn btn-primary reg-btn first-reg">Регистрация на ученик</button><br/>
				<button class="btn btn-primary reg-btn">Регистрация на родител</button><br/>
				<button class="btn btn-primary reg-btn">Регистрация на учител</button><br/>
			</div>

			<div class="col-md-3" style="text-align: right; margin-top: 40px">
				<img src="../resources/change.png" width="80%" align="right" />
			</div>
		</div>
        <!-- Content ends -->
    </div>         
</div>
			
<div class="clearfix" style="padding-bottom: 50px"></div>
<!-- Footer -->
<div class="navbar navbar-default navbar-fixed-bottom footer">
    <div class="container">
      <p class="navbar-text pull-left">© Copyright - E-register 2017</p>  
    </div>
</div>	
    </form>
</body>
</html>
