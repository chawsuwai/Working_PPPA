<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProjectDenominatorUpdate.aspx.cs" Inherits="PPP_Project.ProjectDenominatorUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <div class="panel">
                <div class="panel-heading">
                    Project Denominators Monthly Update| IGS - PPPA System
                </div>
                <div class="panel-body">                      
                        <div class="form-group">
                            <div class="controls">
                                <label class="control-label" style="width:110px;">
                                    PROJECT
                                </label>
                                <asp:DropDownList ID="ddlPROJECT" runat="server" CssClass="chosen-select" ClientIDMode="Static"
                                    AutoPostBack="true" Width="190px"  Height="26px"/>
                            </div>
                        </div>                     
                    <div id="divProbes" class="form-group" runat="server" style="display: none">
                        <label class="control-label" style="width:110px;">
                            Probes</label>
                        <asp:TextBox ID="txtProbes" runat="server"  Width="190px"  Height="34px" onkeypress="return isNumberOrDecimal(event,this)"></asp:TextBox>
                    </div>
                    <div class="form-group" id="divPricing" runat="server" style="display: none">
                        <label class="control-label" style="width:110px;">
                            Pricing Probes</label>
                            <asp:TextBox ID="txtPricingProbes" runat="server"  Width="190px"  Height="34px" onkeypress="return isNumberOrDecimal(event,this)"></asp:TextBox>
                    </div>
                    <div class="form-group" id="divMask" runat="server" style="display: none">
                        <label class="control-label" style="width:110px;">
                            Masks</label>                      
                        <asp:TextBox ID="txtMasks" runat="server"  Width="190px"  Height="34px" onkeypress="return isNumberOrDecimal(event,this)"></asp:TextBox>
                    </div>
                    <div id="divRepricing" class="form-group" runat="server" style="display: none">
                        <label class="control-label" style="width:110px;">
                            Repricing</label>
                        <asp:TextBox ID="txtRepricing" runat="server"  Width="190px"  Height="34px" onkeypress="return isNumberOrDecimal(event,this)"></asp:TextBox>
                    </div>
                        <div id="divSceneRecog" class="form-group" runat="server" style="display: none">
                        <label class="control-label" style="width:110px;">
                            SceneRecog</label>
                        <asp:TextBox ID="txtSceneRecog" runat="server"  Width="190px"  Height="34px" onkeypress="return isNumberOrDecimal(event,this)"></asp:TextBox>
                    </div>
                    <div id="divScene" class="form-group" runat="server" style="display: none">
                        <label class="control-label"  style="width:110px;">
                            Scenes</label>
                        <asp:TextBox ID="txtScenes" runat="server"  Width="190px"  Height="34px" onkeypress="return isNumberOrDecimal(event,this)"></asp:TextBox>
                    </div>
                     <div id="divExpert" class="form-group" runat="server" style="display: none">
                        <label class="control-label"  style="width:110px;">
                            Expert</label>
                            <asp:TextBox ID="txtCategoryExpert" runat="server"  Width="190px"  Height="34px" onkeypress="return isNumberOrDecimal(event,this)"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label class="control-label" style="width:110px;">
                            Month</label>
                        <asp:TextBox ID="txtMonth" runat="server" Width="190px"  Height="34px" CssClass="monthyearpicker span3"></asp:TextBox>
                        <div class="control">
                            <br />
                            <asp:Button ID="btnSubmit" runat="server" Text="Search" CssClass="btn btn-info" OnClick="btnSubmit_Click">
                            </asp:Button>
                            <asp:Button ID="btnCancel" runat="server" Text="Cancel" class="btn btn-info" OnClick="btnCancel_Click" />                         
                            <asp:HiddenField ID="hdID" runat="server" />         
                            <asp:HiddenField ID="hdProject" runat="server" />                  
                        </div>
                    </div>
                    <asp:GridView ID="gvDenoChange" runat="server" CssClass="table table-hover table-bordered"
                        AutoGenerateColumns="False" GridLines="None" Width="100%" OnSelectedIndexChanged="gvDenoChange_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="ID" />
                            <asp:BoundField DataField="PROJECT" HeaderText="PROJECT" />
                            <asp:BoundField DataField="Probes" HeaderText="Probes" />
                             <asp:BoundField DataField="Pricingprobes" HeaderText="Pricingprobes" />
                             <asp:BoundField DataField="Masks" HeaderText="Masks" />
                             <asp:BoundField DataField="Repricing" HeaderText="Repricing" />
                             <asp:BoundField DataField="SceneRecog" HeaderText="SceneRecog" />
                             <asp:BoundField DataField="ProbesperScene" HeaderText="ProbesperScene" />
                             <asp:BoundField DataField="Expert" HeaderText="Expert" />
                            <asp:BoundField DataField="DenoMonth" HeaderText="Month" />
                            <asp:BoundField DataField="CreatedDate" HeaderText="Created Date" />
                            <asp:BoundField DataField="CreatedBy" HeaderText="Created By" />
                            <asp:TemplateField HeaderText="Edit">
                                <ItemTemplate>
                                    <asp:LinkButton ID="lbutEdit" runat="server" CausesValidation="False" CommandName="Select">Edit</asp:LinkButton>
                                </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" Width="50px" />
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
    
    <script type="text/javascript" language="javascript">
        function allowOnlyNumber(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode > 31 && (charCode < 48 || charCode > 57))
                return false;
            return true;
        }

        $(function () {
            $('.chosen-select').chosen();
            $('.chosen-select-deselect').chosen({ allow_single_deselect: true });
        });

        function pageLoad(sender, args) {
            if (args.get_isPartialLoad()) {
                $("#ddlPROJECT").chosen();

            }
        }
    </script>
</asp:Content>
