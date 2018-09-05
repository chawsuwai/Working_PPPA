<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PPP_Project.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="Creative - Bootstrap 3 Responsive Admin Template">
    <meta name="author" content="GeeksLabs">
    <meta name="keyword" content="Creative, Dashboard, Admin, Template, Theme, Bootstrap, Responsive, Retina, Minimal">
    <link rel="shortcut icon" href="img/favicon.png">
    <title>Login Page | IGS - PPPA System</title>
    <!-- Bootstrap CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <!-- bootstrap theme -->
    <link href="css/bootstrap-theme.css" rel="stylesheet" />
    <!--external css-->
    <!-- font icon -->
    <link href="css/elegant-icons-style.css" rel="stylesheet" />
    <link href="css/font-awesome.css" rel="stylesheet" />
    <!-- Custom styles -->
    <link href="css/style.css" rel="stylesheet" />
    <link href="css/style-responsive.css" rel="stylesheet" />
</head>
<body class="login-img3-body">
    <div class="container">
        <form id="form1" runat="server" class="login-form">
        <div class="login-wrap">
            <p class="login-img">
                <i class="icon_lock_alt"></i>
                PPPA System
            </p>
            <div class="input-group">
                <span class="input-group-addon"><i class="icon_profile"></i></span>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Username"></asp:TextBox>
            </div>
            <div class="input-group">
                <span class="input-group-addon"><i class="icon_key_alt"></i></span>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Password"></asp:TextBox>
            </div>
            <%--<label class="checkbox">--%>
            <%-- <input type="checkbox" value="remember-me">--%>
              <%--  <asp:CheckBox ID="CheckBox1" runat="server" />
                Remember me <span class="pull-right">
                    <asp:HyperLink ID="HyperLink1" runat="server">Forgot Password?</asp:HyperLink>
            </label>--%>
            <asp:Button ID="btnLogin" runat="server" Text="Login" 
                CssClass="btn btn-primary btn-lg btn-block" onclick="btnLogin_Click" />
        </div>
        </form>
        <div class="text-center">
            <div class="credits">
                <a href="#">Developed</a> by <a href="http://www.infinityglobals.com">
                    IGS</a>
            </div>
        </div>
    </div>
</body>
</html>
