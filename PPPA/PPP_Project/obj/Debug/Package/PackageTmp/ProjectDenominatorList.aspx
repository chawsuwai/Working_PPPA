<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ProjectDenominatorList.aspx.cs" Inherits="PPP_Project.ProjectDenominatorList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <div class="panel">
                <div class="panel-heading">
                    Project Denominators List | IGS - PPPA System
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <div class="controls">
                            <label class="control-label" style="width: 110px;">
                                PROJECT
                            </label>
                            <asp:DropDownList ID="ddlPROJECT" runat="server" CssClass="chosen-select" ClientIDMode="Static"
                                AutoPostBack="true" Width="190px" Height="26px" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="control"> 
                            <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-info" 
                                onclick="btnSearch_Click"  >
                            </asp:Button>
                            <asp:HiddenField ID="hdID" runat="server" />
                        </div>
                    </div>
                    <asp:GridView ID="gvDenoChange" runat="server" CssClass="table table-hover table-bordered"
                        AutoGenerateColumns="False" GridLines="None" Width="100%" OnSelectedIndexChanged="gvDenoChange_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="ID" />
                            <asp:BoundField DataField="PROJECT" HeaderText="PROJECT" />
                            <asp:BoundField DataField="Probes" HeaderText="Probes" />
                            <asp:BoundField DataField="Pricingprobes" HeaderText="Pricingprobes" />
                            <asp:BoundField DataField="Votes" HeaderText="Votes" />
                            <asp:BoundField DataField="Masks" HeaderText="Masks" />
                            <asp:BoundField DataField="Repricing" HeaderText="Repricing" />
                            <asp:BoundField DataField="SceneRecog" HeaderText="SceneRecog" />
                            <asp:BoundField DataField="ProbesperScene" HeaderText="ProbesperScene" />
                            <asp:BoundField DataField="Expert" HeaderText="Expert" />
                            <asp:BoundField DataField="ExpertVoting" HeaderText="ExpertVoting" />
                            <asp:BoundField DataField="DCDate" HeaderText="Date" />
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
