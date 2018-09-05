<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="RecheckedAccuracy.aspx.cs" Inherits="PPP_Project.RecheckedAccuracy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <div class="panel">
                <div class="panel-heading">
                    Rechecked Accuracy | IGS - PPPA System
                </div>
                <div class="panel-body"> 
                        <div class="form-group">
                            <div class="controls">
                                <label class="control-label">
                                    Branch Name
                                </label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:DropDownList ID="ddlCenterName" runat="server" CssClass="chosen-select" ClientIDMode="Static" OnSelectedIndexChanged="ddlCenterName_SelectedIndexChanged"
                                    AutoPostBack="true" Width="154px"  Height="26px"/>
                            </div>
                        </div> 

                        <div class="form-group">
                            <div class="controls">
                                <label class="control-label">
                                    QAT
                                </label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                              
                                <asp:DropDownList ID="ddlQAT" runat="server" CssClass="chosen-select" ClientIDMode="Static"
                                    AutoPostBack="true" Width="154px"  Height="26px"/>
                            </div>
                        </div> 
                    <div class="form-group" id="divAccuracy" runat="server" style="display: none">
                        <label class="control-label">
                            Accuracy</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtAccuracy" runat="server" CssClass="span3" onkeypress="return isNumberOrDecimal(event,this)"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label class="control-label">
                            Month</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            
                        <asp:TextBox ID="txtMonth" runat="server" CssClass="monthyearpicker span3"></asp:TextBox>
                        <div class="control">
                            <br />
                            <asp:Button ID="btnSubmit" runat="server" Text="Search" CssClass="btn btn-info" OnClick="btnSubmit_Click">
                            </asp:Button>
                            <asp:Button ID="btnCancel" runat="server" Text="Cancel" class="btn btn-info" OnClick="btnCancel_Click" />
                            <asp:HiddenField ID="hdID" runat="server" />
                            <asp:HiddenField ID="hdQAT" runat="server" />
                            <asp:HiddenField ID="hdCenter" runat="server" />
                        </div>
                    </div>
                    <asp:GridView ID="gvRecheckAcc" runat="server" CssClass="table table-hover table-bordered"
                        AutoGenerateColumns="False" GridLines="None" Width="100%" OnSelectedIndexChanged="gvRecheckAcc_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="ID" />
                            <asp:BoundField DataField="QAT" HeaderText="QAT" />
                            <asp:BoundField DataField="AccuracyPercent" HeaderText="Accuracy" />
                            <asp:BoundField DataField="AccMonth" HeaderText="Month" />
                            <asp:BoundField DataField="Center" HeaderText="Center" />
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
                $("#ddlQAT").chosen();

            }
        }
    </script>
</asp:Content>
