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
                <asp:Button ID="btnLogOut" runat="server" CssClass="btn btn-primary exit-btn" Text="Изход" OnClick="btnLogOut_Click" />
			</div>
		</div>

		<div class="row selection">
			<div class="col-md-3">
                <asp:DropDownList ID="ddlCity" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged" runat="server"></asp:DropDownList>
			</div>

			<div class="col-md-3">
                <asp:DropDownList ID="ddlSchool" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlSchool_SelectedIndexChanged" runat="server"></asp:DropDownList>
			</div>

			<div class="col-md-3">
                <asp:DropDownList ID="ddlClass" runat="server" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlClass_SelectedIndexChanged"></asp:DropDownList>
			</div>
		</div>

		<div class="row">
			<div class="col-md-3 cp-title">
				<h3>Профили</h3>
			</div>

			<div class="col-md-3" style="text-align: left;">
                <asp:TextBox ID="txtSearch" runat="server" name="search" placeholder="Търси..." CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-3" style="text-align: left;">
                <asp:LinkButton ID="searchButton" runat="server" OnClick="searchButton_Click" CssClass="btn btn-primary"><span class="glyphicon glyphicon-search"></span></asp:LinkButton>
                
			</div>	
		</div>

		<div class="row">

			<div class="col-md-6">
                <asp:GridView ID="gridViewUsers" PageSize="10" OnPageIndexChanging="gridViewUsers_PageIndexChanging" runat="server" CssClass="table" AutoGenerateSelectButton="true" AllowPaging="true" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="UserID" HeaderText="#"/>
                        <asp:BoundField DataField="FullName" HeaderText="Име"/>
                        <asp:BoundField DataField="Type" HeaderText="Тип"/>
                    </Columns>
                </asp:GridView>
			</div>

			<div class="col-md-3" style="position: relative; margin-top: 33px; padding-left: 18px">
                <asp:Button runat="server" CausesValidation="true" OnClick="RegClick" CssClass="btn btn-primary reg-btn first-reg" Text="Регистрация на потребител" />
			</div>
            <div class="col-md-3" style="position: relative; margin-top: 33px; padding-left: 18px">
                <asp:Button ID="btnGallery" runat="server" CausesValidation="true" OnClick="btnGallery_Click" CssClass="btn btn-primary reg-btn first-reg" Text="Галерия" />
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
