<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DenominatorImportForAllProjectDaily.aspx.cs" Inherits="PPP_Project.DenominatorImportForAllProjectDaily" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="panel">
                <header class="panel-heading">Denominator Import For All Project Daily| IGS - PPPA System
                          </header>
                <div class="panel-body">
                    <div class="form-group">
                        <label class="col-sm-2 control-label">
                            From Date</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtImportDate" runat="server" 
                                CssClass="form_date form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div>&nbsp;</div>
                    <div class="form-group">
                        <label class="col-sm-2 control-label">
                            To Date</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtImportDateTo" runat="server" 
                                CssClass="form_date form-control"></asp:TextBox>
                        </div>
                    </div>

                    <div>&nbsp;</div>
                    <div class="form-group">
                        <label class="col-sm-2 control-label">
                            Excel Import</label>
                        <div class="col-sm-10">

                            <asp:FileUpload ID="FileUpload1" runat="server"></asp:FileUpload>

                            <div>&nbsp;</div>
                            
                              <asp:Button ID="btnDenoImport" runat="server" Text="Submit" 
                                    CssClass="btn btn-info" onclick="btnDenoImport_Click"></asp:Button>

                        </div>
                        
                    </div>                    
                </div>
            </div>
        </div>
    </div>
    
 
</asp:Content>
