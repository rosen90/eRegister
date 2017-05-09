<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterForm.aspx.cs" Inherits="eRegister.UserWebForms.RegisterForm" %>

<!DOCTYPE html>

<html>
<head runat="server">
     <title>E-register</title>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link rel="stylesheet" href="../css/bootstrap.min.css">
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.0/jquery.min.js"></script>
	<script src="../js/bootstrap.min.js"></script>
	<link rel="stylesheet" type="text/css" href="../css/style.css">

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
		<div class="content">
			<div class="row">
				 <div class="logo">
				 	<div class="col-md-3">
						<img src="../resources/logo.png" width="30%" align="left">
					</div>	
					<div class="col-md-9">
						<h3>E-register</h3>
					</div>		
				 </div>
			</div>
			 <hr>
			 <div class="row">
			 	<div class="col-md-6 col-lg-6 col-sm-12 col-xs-12">
			 		<div class="col-md-8">
				 		<label>Потребителско име <span class="star">*</span> :</label>
				 		<asp:TextBox ID="inputUsername" runat="server" placeholder="Въведете потребителско име" CssClass="form-control" />
                        <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
                            ControlToValidate="inputUsername"
                            ErrorMessage="User name is a required field."
                            ForeColor="Red"
                            Enabled="true">
                        </asp:RequiredFieldValidator>
				 	</div>

				 	<div class="col-md-8">
				 		<label>Парола <span class="star">*</span> :</label>
				 		<asp:TextBox ID="inputPassword" runat="server" TextMode="Password" placeholder="Въведете парола" CssClass="form-control" />
                        <asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server"
                            ControlToValidate="inputPassword"
                            ErrorMessage="Password is a required field."
                            ForeColor="Red"
                            Enabled="true">
                        </asp:RequiredFieldValidator>
				 	</div>

				 	<div class="col-md-8">
				 		<label>Потвърди парола <span class="star">*</span> :</label>
				 			<asp:TextBox ID="inputPasswordConfirm" runat="server" TextMode="Password" placeholder="Въведете парола" CssClass="form-control" />
                            <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server"
                                ControlToValidate="inputPasswordConfirm"
                                ErrorMessage="Password is a required field."
                                ForeColor="Red"
                                Enabled="true">
                            </asp:RequiredFieldValidator>
				 	</div>
			 	</div>	
			 	<div class="col-md-6 col-lg-6 col-sm-12 col-xs-12">	
			 		<div class="row">
			 			<div class="col-md-3" id="avatar">
			 				<img src="../resources/avatar.png" width="100%">
			 			</div>
			 		</div>
			 		<div class="clearfix"></div>
			 		<div class="row">
			 			<form class="form-horizontal" id="file"> 
	 					 	<div class="form-group">
	   							<input type="file" class="form-control-file" id="exampleInputFile" aria-describedby="fileHelp">
	  						</div>
						</form>
			 		</div>
			 		
			 	</div>		 	
			 </div>
			 <hr>
			 <h3>Персонална информация</h3>
			 <div class="clearfix"></div>
				 <div class="row">
				 	<div class="col-md-12">
					 	<div class="col-md-4 col-lg-4 col-sm-12 col-xs-12">
					 		<label>Име:</label><br/>
					 		<asp:TextBox ID="Name" runat="server" placeholder="Въведете име" CssClass="form-control" />
                            <asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server"
                                ControlToValidate="Name"
                                ErrorMessage="Name is a required field."
                                ForeColor="Red"
                                Enabled="true">
                            </asp:RequiredFieldValidator>
					 	</div>
					 	<div class="col-md-4 col-lg-4 col-sm-12 col-xs-12">
					 		<label>Презиме:</label><br/>
					 		<asp:TextBox ID="Midname" runat="server" placeholder="Въведете презиме" CssClass="form-control" />
                            <asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server"
                                ControlToValidate="Midname"
                                ErrorMessage="Midname is a required field."
                                ForeColor="Red"
                                Enabled="true">
                            </asp:RequiredFieldValidator>
					 	</div>
					 	<div class="col-md-4 col-lg-4 col-sm-12 col-xs-12">
					 		<label>Фамилия:</label><br/>
					 		<asp:TextBox ID="Lastname" runat="server" placeholder="Въведете фамилия" CssClass="form-control" />
                            <asp:RequiredFieldValidator id="RequiredFieldValidator6" runat="server"
                                ControlToValidate="Lastname"
                                ErrorMessage="Lastname is a required field."
                                ForeColor="Red"
                                Enabled="true">
                            </asp:RequiredFieldValidator>
					 	</div>
					 </div>
				 </div>
				 <div class="clearfix"></div>
			 	
			 	<div class="row">
			 		<div class="col-md-12">	
			 			<div class="col-md-4 col-lg-4 col-sm-12 col-xs-12">
				 			 <div class="form-group">
							    <label for="exampleSelect1">ЕГН:</label>
					 		    <asp:TextBox ID="PersonalID" runat="server" placeholder="Въведете егн" CssClass="form-control" />
                                <asp:RequiredFieldValidator id="RequiredFieldValidator7" runat="server"
                                    ControlToValidate="PersonalID"
                                    ErrorMessage="Personal ID is a required field."
                                    ForeColor="Red"
                                    Enabled="true">
                                </asp:RequiredFieldValidator>
							  </div>
			 			</div>
			 			<div class="col-md-4 col-lg-4 col-sm-12 col-xs-12">
				 			 <div class="form-group">
							    <label for="exampleSelect1">Статус:</label>
							    <select class="form-control" id="exampleSelect1">
							      <option>учащ</option>
							      <option>прекъснал</option>
							      <option>изгонен</option>
							    </select>
							  </div>
			 			</div>
			 			<div class="col-md-4">
				 		<div class="col-md-12 col-lg-12 col-sm-12 col-xs-12">
				 			<label>Пол:</label> 
				 		</div>
				 		<form class="form-horizontal col-md-12"> 
	 					 	<fieldset class="form-group">
							    <div class="col-md-6">
								    <div class="form-check">
								      <label class="form-check-label">
								        <input type="radio" class="form-check-input" name="optionsRadios" id="optionsRadios1" value="option1" checked>
								        Мъж
								      </label>
								    </div>
								</div>
							     <div class="col-md-6">
								    <div class="form-check">
								      <label class="form-check-label">
								        <input type="radio" class="form-check-input" name="optionsRadios" id="optionsRadios1" value="option1" checked>
								        Жена
								      </label>
								    </div>
								</div>
							</fieldset>
						</form>
				 	</div>
			 		</div>
			 	</div>
			 	<hr>
				 <h3>Контакти</h3>
				 <div class="clearfix"></div>
				 <div class="row">
				 	<div class="col-md-12">
					 	<div class="col-md-4 col-lg-4 col-sm-12 col-xs-12">
					 		<label>Адрес:</label><br/>
					 		<asp:TextBox ID="Address" runat="server" placeholder="гр./с., ж.к., ул., №, вх. ап. " CssClass="form-control" />
                            <asp:RequiredFieldValidator id="RequiredFieldValidator8" runat="server"
                                ControlToValidate="Address"
                                ErrorMessage="Address is a required field."
                                ForeColor="Red"
                                Enabled="true">
                            </asp:RequiredFieldValidator>
					 	</div>
					 	<div class="col-md-4 col-lg-4 col-sm-12 col-xs-12">
					 		<label>Email адрес:</label><br/>
					 		<asp:TextBox ID="Email" runat="server" placeholder="mail@example.com" CssClass="form-control" />
                            <asp:RequiredFieldValidator id="RequiredFieldValidator9" runat="server"
                                ControlToValidate="Email"
                                ErrorMessage="Email is a required field."
                                ForeColor="Red"
                                Enabled="true">
                            </asp:RequiredFieldValidator>
					 	</div>
					 	<div class="col-md-4 col-lg-4 col-sm-12 col-xs-12" >
					 		<label>Телефон:</label><br/>
                            <asp:TextBox ID="Number" runat="server" placeholder="+359 00 000 000" CssClass="form-control" />
                            <asp:RequiredFieldValidator id="RequiredFieldValidator10" runat="server"
                                ControlToValidate="Number"
                                ErrorMessage="Number is a required field."
                                ForeColor="Red"
                                Enabled="true">
                            </asp:RequiredFieldValidator>
					 	</div>
					 </div>
				 </div>
				 <div class="clearfix"></div>
			 
		 	<hr>
		  	<div class="row">
			 	<div class="col-md-12">
				 	<div class="col-md-4 col-lg-4 col-sm-12 col-xs-12">
				 		<div class="form-group">
						    <label for="exampleSelect1">Паралелка:</label>
						    <select class="form-control" id="exampleSelect1">
						      <option>Математическа</option>
						      <option>Езикова</option>
						    </select>
						  </div>
				 	</div>
				 	<div class="col-md-4 col-lg-4 col-sm-12 col-xs-12">
				 		<div class="form-group">
						    <label for="exampleSelect1">Училище:</label>
						    <select class="form-control" id="exampleSelect1">
						      <option>СОУ "Проф. д-р Асен Златаров"</option>
						      <option>НУ "Христо Ботев"</option>
						    </select>
						  </div>
				 	</div>
				 	<div class="col-md-4 col-lg-4 col-sm-12 col-xs-12" >
				 		<div class="form-group">
						    <label for="exampleSelect1">Град/Село:</label>
                            <asp:TextBox ID="Town" runat="server" placeholder="Населено място" CssClass="form-control" />
                            <asp:RequiredFieldValidator id="RequiredFieldValidator11" runat="server"
                                ControlToValidate="Town"
                                ErrorMessage="Town is a required field."
                                ForeColor="Red"
                                Enabled="true">
                            </asp:RequiredFieldValidator>
						  </div>
				 	</div>
				 </div>
			 </div>
			 <hr>
			 <div class="clearfix"></div>
			 	<div class="row" id="reg-btn">			 	
                     <asp:Button runat="server" CausesValidation="true" CssClass="btn btn-primary col-md-4 col-md-offset-4" Text="Регистрация" />
			 	</div>
			 <div class="clearfix"></div>
		</div>
	</div>

	<div class="navbar navbar-default navbar-bottom">
	    <div class="container">
	      <p class="navbar-text pull-left">© Copyright - E-register 2017</p>  
	    </div>
	</div>
    </form>
</body>
</html>
