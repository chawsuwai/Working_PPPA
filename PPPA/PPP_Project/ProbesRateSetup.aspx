<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProbesRateSetup.aspx.cs" Inherits="PPP_Project.ProbesRateSetup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="row">
        <div class="col-lg-12">
            <div class="panel">
                <div class="panel-heading">
                    Probes Rate | IGS - PPPA System
                </div>
                <div class="panel-body">
                   <div class="form-group">                     
                            <div class="controls">
                               <%--<label class="control-label" >
                                 Range1
                            </label> --%>
                            <asp:Label ID="lblRange1" runat="server"  Font-Size="14px" Text="Range1" CssClass="span3" ></asp:Label>
                           
                             <asp:TextBox ID="txtRate1" runat="server" CssClass="span3" onkeypress="return isNumberOrDecimal(event);"></asp:TextBox>
                            </div>                        
                        </div>
                      
                    <div class="form-group">
                        <%--<label class="control-label">
                            Range2 </label>--%>
                            <asp:Label ID="lblRange2" runat="server"  Font-Size="14px" Text="Range2" CssClass="span3" ></asp:Label>
                             
                              <asp:TextBox ID="txtRate2" runat="server" CssClass="span3" onkeypress="return isNumberOrDecimal(event);"></asp:TextBox>
                    </div>

                     <div class="form-group">
                         <asp:Label ID="lblRange3" runat="server"  Font-Size="14px" Text="Range3(Above)" CssClass="span3" ></asp:Label>                            
                            
                            <asp:TextBox ID="txtRate3" runat="server" 
                                CssClass="span3" onkeypress="return isNumberOrDecimal(event);"></asp:TextBox>
                    </div>

                    <div class="form-group">                     
                             
                            <label class="control-label" CssClass="span3" >
                            Month</label>
                             <asp:TextBox ID="txtMonth" runat="server" 
                                CssClass="monthyearpicker span3"></asp:TextBox>
                        <div class="control"> 
                             <br />
                            <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-info" 
                                onclick="btnSubmit_Click"></asp:Button>       
                                <asp:HiddenField ID="hdID" runat="server"/>                 

                        </div>
                    </div>


                    <asp:GridView ID="gvProbesRate" runat="server" CssClass="table table-hover table-bordered"
                        AutoGenerateColumns="False" GridLines="None" Width="100%" onselectedindexchanged="gvProbesRate_SelectedIndexChanged" 
                       >
                         <Columns>
                         <asp:BoundField DataField="ID" HeaderText="ID" />
                            <asp:BoundField DataField="Rate1" HeaderText="5000-5500" />
                            <asp:BoundField DataField="Rate2" HeaderText="5500-6000" />
                            <asp:BoundField DataField="Rate3" HeaderText="6000 above" />
                            <asp:BoundField DataField="RatedYear" HeaderText="Month" />
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