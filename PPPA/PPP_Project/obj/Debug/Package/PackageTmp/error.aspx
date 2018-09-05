<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="error.aspx.cs" Inherits="IGSOperationSys.error" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <title>Error Page - IGS Operation System</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no">
    <meta name="apple-mobile-web-app-capable" content="yes">
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="css/bootstrap-responsive.min.css" rel="stylesheet" type="text/css" />
    <link href="css/font-awesome.css" rel="stylesheet">
    <link href="http://fonts.googleapis.com/css?family=Open+Sans:400italic,600italic,400,600"
        rel="stylesheet">
    <link href="css/style.css" rel="stylesheet" type="text/css">
    <link href="css/pages/signin.css" rel="stylesheet" type="text/css">
</head>
<body>
    <div class="navbar navbar-fixed-top">
        <div class="navbar-inner">
            <div class="container">
                <a class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse"><span
                    class="icon-bar"></span><span class="icon-bar"></span><span class="icon-bar"></span>
                </a><a class="brand" href="SaleManager.aspx">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/img/logo.png" /> &nbsp; &nbsp;IGS Operation System</a>
              
                          </div>
            <!-- /container -->
        </div>
        <!-- /navbar-inner -->
    </div>
    <!-- /navbar -->
    <div class="container">
        <div class="row">
            <div class="span12">
                <div class="error-container">
                    <h1>
                        404</h1>
                    
                    <div class="error-details">
                        Sorry, an error has occured! Why not try going back to the <a href="SaleManager.aspx">home
                            page</a> or perhaps try following!
                    </div>
                    <!-- /error-details -->
                    <div class="error-actions">
                        <a href="SaleManager.aspx" class="btn btn-large btn-primary"><i class="icon-chevron-left">
                        </i>&nbsp; Back to Home Page </a>
                    </div>
                    <!-- /error-actions -->
                </div>
                <!-- /error-container -->
            </div>
            <!-- /span12 -->
        </div>
        <!-- /row -->
    </div>
    <!-- /container -->
    <script src="js/jquery-1.7.2.min.js"></script>
    <script src="js/bootstrap.js"></script>
    
</body>
</html>
