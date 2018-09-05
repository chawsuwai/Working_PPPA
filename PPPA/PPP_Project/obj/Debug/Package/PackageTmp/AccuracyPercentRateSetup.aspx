<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AccuracyPercentRateSetup.aspx.cs" Inherits="PPP_Project.AccuracyPercentRateSetup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <div class="panel">
                <div class="panel-heading">
                    Accuracy Percent Rate | IGS - PPPA System
                </div>
                <div class="panel-body">
                   <div class="form-group">                     
                            <div class="controls">
                               <label class="control-label" >
                                 96%
                            </label> 
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:TextBox ID="txtAccPercentRate1" runat="server" CssClass="span3" onkeypress="return allowOnlyNumber(event);"></asp:TextBox>
                            </div>                        
                        </div>
                      
                    <div class="form-group">
                        <label class="control-label">
                            97% </label> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                              <asp:TextBox ID="txtAccPercentRate2" runat="server" CssClass="span3" onkeypress="return allowOnlyNumber(event);"></asp:TextBox>
                    </div>

                     <div class="form-group">
                         <label class="control-label">
                            98%-100%</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtAccPercentRate3" runat="server" 
                                CssClass="span3" onkeypress="return allowOnlyNumber(event);"></asp:TextBox>
                    </div>

                    <div class="form-group">                     
                             
                            <label class="control-label">
                            Month</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                             <asp:TextBox ID="txtAccPerMonth" runat="server" 
                                CssClass="monthyearpicker span3"></asp:TextBox>
                        <div class="control"> 
                             <br />
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-info" 
                                onclick="btnSubmit_Click"></asp:Button>       
                                <asp:HiddenField ID="hdID" runat="server"/>                 

                        </div>
                    </div>


                    <asp:GridView ID="gvAccPerRate" runat="server" CssClass="table table-hover table-bordered"
                        AutoGenerateColumns="False" GridLines="None" Width="100%" onselectedindexchanged="gvAccPerRate_SelectedIndexChanged" 
                       >
                         <Columns>
                         <asp:BoundField DataField="ID" HeaderText="ID" />
                            <asp:BoundField DataField="AccPerRate1" HeaderText="96%" />
                            <asp:BoundField DataField="AccPerRate2" HeaderText="97%" />
                            <asp:BoundField DataField="AccPerRate3" HeaderText="98%-100%" />
                            <asp:BoundField DataField="AccPerRatedYear" HeaderText="Month" />
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
    
    <script type ="text/javascript" language="javascript" >
        function allowOnlyNumber(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode > 31 && (charCode < 48 || charCode > 57))
                return false;
            return true;
        }
</script> 
</asp:Content>
