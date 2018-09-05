<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProjectNameImport.aspx.cs" Inherits="PPP_Project.ProjectNameImport" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <div class="panel">
                <header class="panel-heading"> Project Names Import | IGS - PPPA System
                          </header>
                <div class="panel-body">
                    <div class="form-group">
                        <label class="col-sm-2 control-label">
                            Month</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtImportDate" runat="server" 
                                CssClass="monthyearpicker form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div>&nbsp;</div>
                    <label class="col-sm-2 control-label">
                            Job Name</label>
                    <div class="col-sm-10">
                            <asp:DropDownList ID="ddlJobName" runat="server" CssClass="form-control">                                 
                                    <asp:ListItem>Probes</asp:ListItem>
                                    <asp:ListItem>Pricing Probes</asp:ListItem>
                                    <asp:ListItem>Masks</asp:ListItem>
                                    <asp:ListItem>Votes</asp:ListItem>
                                    <asp:ListItem>Repricing</asp:ListItem>
                                    <asp:ListItem>Scenes</asp:ListItem>
                                    <asp:ListItem>Scene Recognition</asp:ListItem>
                                    <asp:ListItem>Category Expert</asp:ListItem>                                
                                    <asp:ListItem>Category Expert Voting</asp:ListItem>
                             </asp:DropDownList>                            
                        </div>
                        <div>&nbsp;</div>
                    <label class="col-sm-2 control-label">
                            Status</label>
                    <div class="col-sm-10">
                            <asp:DropDownList ID="ddlStatus" runat="server" CssClass="form-control">                                     
                                    <asp:ListItem>WithoutDeno</asp:ListItem>
                                    <asp:ListItem>WithDeno</asp:ListItem>                                    
                             </asp:DropDownList>                            
                        </div>

                    <div>&nbsp;</div>
                    <div class="form-group">
                        <label class="col-sm-2 control-label">
                            Excel Import</label>
                        <div class="col-sm-10">

                            <asp:FileUpload ID="FileUpload1" runat="server"></asp:FileUpload>

                            <div>&nbsp;</div>
                            
                              <asp:Button ID="btnProjectImport" runat="server" Text="Submit" 
                                    CssClass="btn btn-info" onclick="btnProjectImport_Click"></asp:Button>
                        </div>
                        
                    </div>                    
                </div>
            </div>
        </div>
    </div>
</asp:Content>
