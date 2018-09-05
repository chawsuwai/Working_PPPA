<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Export_List_Without_Deno.aspx.cs" Inherits="PPP_Project.Export_List_Without_Deno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <div class="panel">
                <div class="panel-heading">
                    Excel Export Without Denominator Lists | IGS - PPPA System
                </div>
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
                            Job Name</label>
                        <div class="col-sm-10">
                            <asp:DropDownList ID="ddlJobName" runat="server" CssClass="form-control">
                                    <asp:ListItem>--Select--</asp:ListItem>
                                     <asp:ListItem>All</asp:ListItem>
                                    <asp:ListItem>Probes</asp:ListItem>
                                    <asp:ListItem>Pricing Probes</asp:ListItem>
                                    <asp:ListItem>Masks</asp:ListItem>                                  
                                    <asp:ListItem>Votes</asp:ListItem>
                                    <asp:ListItem>Repricing</asp:ListItem>
                                    <asp:ListItem>Scenes</asp:ListItem>
                                    <asp:ListItem>Scene Recognition</asp:ListItem>
                                    <asp:ListItem>Category Expert</asp:ListItem>
                                    <asp:ListItem>Category Expert Voting</asp:ListItem>
                                    <asp:ListItem>Category Expert Hunt</asp:ListItem>
                                   <%-- <asp:ListItem>Smart Stitching</asp:ListItem>--%>
                                  
                             </asp:DropDownList>                            
                        </div>
                         
                    </div>
                    <div>&nbsp;</div>
                    <div class="form-group">
                        <label class="col-sm-2 control-label">
                            From Date</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtFromDate" runat="server" 
                                CssClass="form_date form-control"></asp:TextBox>
                        </div>
                    </div>
                    <div>&nbsp;</div>
                    <div class="form-group">
                        <label class="col-sm-2 control-label">
                            To Date</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtToDate" runat="server" 
                                CssClass="form_date form-control"></asp:TextBox>

                             <br />

                            <%--<asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-info" 
                                onclick="btnSubmit_Click"></asp:Button>--%>
                            <asp:Button ID="btnExport" runat="server" Text="Export" CssClass="btn btn-info" 
                                onclick="btnExport_Click"></asp:Button>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    
</asp:Content>
