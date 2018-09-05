<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CancelImport.aspx.cs" Inherits="PPP_Project.CancelImport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="panel">
                <header class="panel-heading"> Cancel Probes and Scenes Import | IGS - PPPA System
                          </header>
                <div class="panel-body">
                    <div class="form-group">
                      <label class="col-sm-2 control-label">
                            Branch Name</label>
                        <div class="col-sm-10">
                            <asp:DropDownList ID="ddlCenterName" runat="server" CssClass="form-control">
                            </asp:DropDownList>                           
                        </div>
                        <div>&nbsp;</div>
                        <label class="col-sm-2 control-label">
                            Month</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtImportDate" runat="server" 
                                CssClass="monthyearpicker form-control"></asp:TextBox>
                        </div>
                        <div>&nbsp;</div>
                        <label class="col-sm-2 control-label">
                            Job Name</label>
                        <div class="col-sm-10">
                            <asp:DropDownList ID="ddlJobName" runat="server" CssClass="form-control">
                                    <asp:ListItem>--Select--</asp:ListItem>                                   
                                    <asp:ListItem>Probes</asp:ListItem>                                    
                                    <asp:ListItem>Scenes</asp:ListItem>      
                                    <asp:ListItem>Stitching</asp:ListItem>                                  
                             </asp:DropDownList>                            
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
                                    CssClass="btn btn-info" onclick="btnCancelImport_Click"></asp:Button>

                        </div>
                        
                    </div>                    
                </div>
            </div>
        </div>
    </div>
    
    
</asp:Content>
