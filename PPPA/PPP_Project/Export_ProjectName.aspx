<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Export_ProjectName.aspx.cs" Inherits="PPP_Project.Export_ProjectName" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <div class="panel">
                <div class="panel-heading">
                    Excel Export Project Name Lists | IGS - PPPA System
                </div>
                <div class="panel-body">
                    <div class="form-group">  
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
                            Month</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtMonth" runat="server" 
                                CssClass="monthyearpicker form-control"></asp:TextBox>
                             <br />

                           
                            <asp:Button ID="btnExport" runat="server" Text="Export" CssClass="btn btn-info" 
                                onclick="btnExport_Click"></asp:Button>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    
</asp:Content>
