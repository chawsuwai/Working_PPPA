<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AccuracyImport.aspx.cs" Inherits="PPP_Project.AccuracyImport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="panel">
                <header class="panel-heading"> Accuracy Import | IGS - PPPA System
                          </header>
                <div class="panel-body">
                    <div class="form-group">
                        <label class="col-sm-2 control-label">
                            Branch Name</label>
                        <div class="col-sm-10">
                            <asp:DropDownList ID="ddlCenterName" runat="server" CssClass="form-control">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div>&nbsp;</div>
                    <div class="form-group">
                        <label class="col-sm-2 control-label">
                            Month</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtImportDate" runat="server" 
                                CssClass="monthyearpicker form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div>&nbsp;</div>
                    <div class="form-group">
                        <label class="col-sm-2 control-label">
                            Excel Import</label>
                        <div class="col-sm-10">

                            <asp:FileUpload ID="FileUpload1" runat="server"></asp:FileUpload>

                            <div>&nbsp;</div>

                       <asp:Button ID="btnAccImport" runat="server" Text="Submit" 
                                    CssClass="btn btn-info" onclick="btnAccImport_Click"></asp:Button>

                                    <input type="hidden" id="hidLocalPath" runat="server" />

                        </div>
                        
                    </div>                    
                </div>
            </div>
        </div>
    </div>
     <script type="text/javascript" language="javascript">
         $('#<%=FileUpload1.ClientID %>').change(function () {        
             $('#<%=hidLocalPath.ClientID %>').val($('#<%=FileUpload1.ClientID %>').val());
         });
       </script>
   
</asp:Content>
