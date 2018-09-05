<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProbesQtySetup.aspx.cs" Inherits="PPP_Project.ProbesQtySetup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="panel">
                <div class="panel-heading">
                    Probes Rate | IGS - PPPA System
                </div>
                <div class="panel-body">
                    <div class="form-group">                     
                             
                            <label class="control-label">
                            Probes Qty</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                               <asp:TextBox ID="txtQty" runat="server" CssClass="span3" onkeypress="return allowOnlyNumber(event);"></asp:TextBox>
                        <div class="control"> 
                             <br />
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-info" 
                                onclick="btnSubmit_Click"></asp:Button>       
                                <asp:HiddenField ID="hdID" runat="server"/>                 

                        </div>
                    </div>
             
            </div>
        </div>
    </div>
    </div>
    
    <script type ="text/javascript" language="javascript" >
        function allowOnlyNumber(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode > 31 && (charCode < 48 || charCode > 57))
                return false;
            return true;
        }
</script>
</asp:Content>
