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
				 		<input type="text" class="form-control" name="" required="">
				 	</div>

				 	<div class="col-md-8">
				 		<label>Парола <span class="star">*</span> :</label>
				 		<input type="password" class="form-control" name="" required="">
				 	</div>

				 	<div class="col-md-8">
				 		<label>Потвърди парола <span class="star">*</span> :</label>
				 		<input type="password" class="form-control" name="" required="">
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
					 		<input type="text" name="" class="form-control" required="">
					 	</div>
					 	<div class="col-md-4 col-lg-4 col-sm-12 col-xs-12">
					 		<label>Презиме:</label><br/>
					 		<input type="text" name="" class="form-control" required="">
					 	</div>
					 	<div class="col-md-4 col-lg-4 col-sm-12 col-xs-12">
					 		<label>Фамилия:</label><br/>
					 		<input type="text" name="" class="form-control" required="">
					 	</div>
					 </div>
				 </div>
				 <div class="clearfix"></div>
			 	
			 	<div class="row">
			 		<div class="col-md-12">	
			 			<div class="col-md-4 col-lg-4 col-sm-12 col-xs-12">
				 			 <div class="form-group">
							    <label for="exampleSelect1">ЕГН:</label>
							    <input type="text" name="" class="form-control" required="">
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
					 		<input type="text" name="" class="form-control" placeholder="гр./с., ж.к., ул., №, вх. ап. " required="">
					 	</div>
					 	<div class="col-md-4 col-lg-4 col-sm-12 col-xs-12">
					 		<label>Email адрес:</label><br/>
					 		<input type="email" name="" class="form-control" placeholder="mail@example.com" required="">
					 	</div>
					 	<div class="col-md-4 col-lg-4 col-sm-12 col-xs-12" >
					 		<label>Телефон:</label><br/>
					 		<input type="number" name="" class="form-control" placeholder="+359 00 000 000" required="">
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
						    <input type="text" name="" class="form-control" required="">
						  </div>
				 	</div>
				 </div>
			 </div>
			 <hr>
			 <div class="clearfix"></div>
			 	<div class="row" id="reg-btn">			 	
			 		<button type="submit" class="btn btn-primary">Регистрация</button>
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
