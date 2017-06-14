<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PhotoView.aspx.cs" Inherits="eRegister.UserWebForms.PhotoView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Галерия</title>
    <meta charset="utf-8"/>
	<meta name="viewport" content="width=device-width, initial-scale=1"/>
	<link rel="stylesheet" href="../css/bootstrap.min.css"/>
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.0/jquery.min.js"></script>
	<script src="../js/bootstrap.min.js"></script>
	<link rel="stylesheet" type="text/css" href="../css/style.css"/>
    <link rel="stylesheet" type="text/css" href="../css/animate.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button2" CssClass="btn btn-primary" Text="Назад към галерия" runat="server" onclick="Button1_Click" />
        <br /><br />
        <asp:Image ID="Image1" CssClass="fillwidth fillheight" runat="server" />
        <br /><br />
        <asp:Button ID="Button1" CssClass="btn btn-primary" Text="Назад към галерия" runat="server" onclick="Button1_Click" />

    </div>
    </form>
</body>
</html>
