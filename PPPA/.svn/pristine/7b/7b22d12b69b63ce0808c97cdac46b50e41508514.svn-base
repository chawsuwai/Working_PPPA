<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProbesRangeSetup.aspx.cs" Inherits="PPP_Project.ProbesRangeSetup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="panel">
                <div class="panel-heading">
                    Probes Range | IGS - PPPA System
                </div>
                <div class="panel-body">
                   <div class="form-group"> 
                            <div class="controls">
                               <%--<label class="control-label" for="lblRange1" runat="server">
                                 Range1
                            </label>--%> 
                            <asp:Label ID="lblRange1" runat="server"  Font-Size="14px" Text="Range1"></asp:Label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                            
                             <asp:TextBox ID="txtFromRange1" runat="server" CssClass="span3" onkeypress="return allowOnlyNumber(event);"></asp:TextBox>
                              &nbsp;
                             <label class="control-label" >
                                 -
                            </label>          
                            &nbsp;                    
                             <asp:TextBox ID="txtToRange1" runat="server" CssClass="span3" onkeypress="return allowOnlyNumber(event);"></asp:TextBox>
                            </div>                        
                        </div>
                      
                    <div class="form-group">
                        <%--<label class="control-label" for="lblRange2">
                            Range2 </label> --%>
                            <asp:Label ID="lblRange2" runat="server"  Font-Size="14px" Text="Range2"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtFromRange2" runat="server" CssClass="span3" onkeypress="return allowOnlyNumber(event);"></asp:TextBox>
                              &nbsp;
                             <label class="control-label" >
                                 -
                            </label>
                            &nbsp;                              
                             <asp:TextBox ID="txtToRange2" runat="server" CssClass="span3" onkeypress="return allowOnlyNumber(event);"></asp:TextBox>
                    </div>

                     <div class="form-group">
                         <%--<label class="control-label" for="lblRange3">
                            Range3(Above)</label>--%>
                            <asp:Label ID="lblRange3" runat="server"  Font-Size="14px" Text="Range3(Above)"></asp:Label>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtFromRange3" runat="server" 
                                CssClass="span3" onkeypress="return allowOnlyNumber(event);"></asp:TextBox>
                    </div>

                    <div class="form-group">                   
                             
                        <div class="control"> 
                             <br />
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-info" 
                                onclick="btnSubmit_Click"></asp:Button>       
                                <asp:HiddenField ID="hdID1" runat="server"/>
                                <asp:HiddenField ID="hdID2" runat="server"/>   
                                <asp:HiddenField ID="hdID3" runat="server"/>              

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
