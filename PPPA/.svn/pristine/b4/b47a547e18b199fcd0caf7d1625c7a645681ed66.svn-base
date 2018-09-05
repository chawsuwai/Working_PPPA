<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserSignUp.aspx.cs" Inherits="PPP_Project.UserSignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="panel">
                <header class="panel-heading"> User SignUp| IGS - PPPA System
                 </header>
                <div class="panel-body">
                <div class="form-group">
                        <label class="col-sm-2 control-label">
                            User Name</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtUsername" runat="server" 
                                CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                     <div>&nbsp;</div>
                    <div class="form-group">
                      <label class="col-sm-2 control-label">
                            Password</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtPassword" runat="server" 
                                CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                     <div>&nbsp;</div>
                    <div class="form-group">
                      <label class="col-sm-2 control-label">
                        Confirm Password</label>
                        <div class="col-sm-10">
                            <asp:TextBox ID="txtConfirmPwd" runat="server" 
                                CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                     <div>&nbsp;</div>
                    <div class="form-group">
                      <label class="col-sm-2 control-label">
                           User Type</label>
                        <div class="col-sm-10">
                            <asp:DropDownList ID="ddlUserType" runat="server" CssClass="form-control">
                            </asp:DropDownList>                           
                        </div>
                    </div>
                    <div>&nbsp;</div>
                     <div class="control-group">
                            <div class="controls">
                                <asp:Button ID="btnCreate" class="btn btn-primary" runat="server" Text="Create" 
                                    onclick="btnCreate_Click" />
                                <asp:Button ID="btnUpdate" class="btn btn-primary" runat="server" Text="Update" 
                                    onclick="btnUpdate_Click" />
                                <asp:Button ID="btnCancel" class="btn btn-primary" runat="server" Text="Cancel" 
                                    onclick="btnCancel_Click" />
                            </div>
                        </div>
                        <div>&nbsp;</div>
                      <asp:GridView ID="gvUser" runat="server" CssClass="table table-hover table-bordered"
                        GridLines="None" AutoGenerateColumns="False" 
                        onselectedindexchanged="gvUser_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="UserName" HeaderText="User Name" />
                            <asp:BoundField DataField="UserType" HeaderText="User Type" />
                            <asp:TemplateField HeaderText="Edit">
                                <ItemTemplate>
                                    <asp:LinkButton ID="btnEdit" runat="server" CausesValidation="False" CommandName="Select">Edit</asp:LinkButton>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" Width="50px" />
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
