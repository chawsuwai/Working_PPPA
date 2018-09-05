using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PPP_Project.Base;
using PPP_Project.Common;
using PPP_Project.CommonAttributes;
using PPP_Project.Common.Utility;
using PPP_Project.Common.Message;
using PPP_Project.Entity;
using PPP_Project.Criteria;
using System.IO;
using System.Transactions;
using OfficeOpenXml;
using PPP_Project.Business;

namespace PPP_Project
{
    public partial class RecheckedAccuracy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                    //BindQAT();
                    
                    var Probes = new Probes();
                    var result = Probes.FindAllBranch();

                    for (int i = 0; i < result.Count; i++)
                    {
                        ddlCenterName.Items.Insert(i, new ListItem(result[i].BranchName, result[i].BranchCode));
                    }
                    ddlCenterName_SelectedIndexChanged(sender, e);
                if (btnSubmit.Text == "Search")
                {
                  BindGrid();
               }
            }
        }

        private bool ValidateForm()
        {
            if (this.ddlQAT.SelectedItem.Text == "Select")
            {
                MessageBox.MessageShow(this.GetType(), "Please choose QAT.", ClientScript);
                this.ddlQAT.Focus();
                return false;
            }

            //if (txtAccuracy.Text == "")
            //{
            //    MessageBox.MessageShow(this.GetType(), "Please type Rate.", ClientScript);
            //    txtAccuracy.Focus();
            //    return false;
            //}           

            if (txtMonth.Text == "")
            {
                MessageBox.MessageShow(this.GetType(), "Please Choose Month.", ClientScript);
                txtMonth.Focus();
                return false;
            }

            return true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                BindGrid();
                return;
            }
            using (TransactionScope scope = new TransactionScope())
            {
                if (btnSubmit.Text != "Search")
                {
                    try
                    {
                        var userEntity = (UserEntity)Session["ID"];
                        AccuracyPercentage Pbusiness = new AccuracyPercentage();
                        var entity = Pbusiness.FindDataByID(hdID.Value);
                        if (entity != null)
                        {
                        new AccuracyPercentage
                        {
        
                            Entity = new AccuracyEntity
                            {
                                ID=hdID.Value,
                                QAT = hdQAT.Value,
                                Center=hdCenter.Value,
                                AccuracyPercent = Convert.ToDecimal(txtAccuracy.Text),
                                AccMonth = GeneralUtility.ConvertMonthYearStringFormat(txtMonth.Text.Trim()),
                                Createdby = userEntity.ID,                              
                            }
                        }.Update();
                    }

                        MessageBox.MessageShow(this.GetType(), "Successfully Updated.", ClientScript);
                        btnSubmit.Text = "Search";
                        divAccuracy.Attributes.Add("style", "display:none");
                        BindGrid();
                        scope.Complete();
                      
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    try
                    {
                        BindGrid();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

            ddlQAT.Enabled = true;
            ddlCenterName.Enabled = true;
            ddlQAT.SelectedValue = "Select";
            ddlQAT.SelectedIndex = 0;
            txtAccuracy.Text = "";          
            txtMonth.Text = "";        

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

            this.hdID.Value = string.Empty;
            this.hdQAT.Value = string.Empty;
            this.hdCenter.Value = string.Empty;
            this.ddlQAT.SelectedIndex = 0;
            this.ddlCenterName.SelectedIndex = 0;
            this.txtAccuracy.Text = string.Empty;
            this.txtMonth.Text = string.Empty;
            ddlQAT.Enabled = true;
            ddlCenterName.Enabled = true;
            btnSubmit.Text = "Search";
            divAccuracy.Attributes.Add("style", "display:none");
            ddlCenterName_SelectedIndexChanged(sender, e);
            BindGrid();
             
        }

     
        private void BindGrid()
        {
            gvRecheckAcc.Columns[0].Visible = true;
            AccuracyPercentage Pbusiness = new AccuracyPercentage();
            var list = Pbusiness.Finds();
            string month = GeneralUtility.ConvertMonthYearStringFormat(txtMonth.Text.Trim());
            //string currentMonth=month.Substring(0, 6);
            list = list.Where(x => x.AccMonth == month && x.QAT == ddlQAT.SelectedValue).ToList();
            var reslist = from data in list
                          select new { data.ID, data.QAT, data.AccuracyPercent, data.Center,AccMonth = GeneralUtility.ConvertDisplayMonthStringFormat(data.AccMonth), CreatedDate = GeneralUtility.ConvertDisplayDateStringFormat(data.CreatedDate), data.Createdby };
            gvRecheckAcc.DataSource = reslist.ToList();
            gvRecheckAcc.DataBind();
            gvRecheckAcc.Columns[0].Visible = false;
            //gvRecheckAcc.Columns[4].Visible = false;
            gvRecheckAcc.Columns[5].Visible = false;
            gvRecheckAcc.Columns[6].Visible = false;

        }

        protected void gvRecheckAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            hdID.Value = gvRecheckAcc.SelectedRow.Cells[0].Text;
            hdQAT.Value = gvRecheckAcc.SelectedRow.Cells[1].Text;
            hdCenter.Value = gvRecheckAcc.SelectedRow.Cells[4].Text;
            string id = hdID.Value.ToString();
            AccuracyPercentage business = new AccuracyPercentage();
            var entity = business.FindDataByID(id);
            if (entity != null)
            {
                this.ddlQAT.SelectedValue = entity.QAT;
                this.ddlCenterName.SelectedValue = entity.Center;
                this.txtAccuracy.Text = entity.AccuracyPercent.ToString();           
                this.txtMonth.Text = GeneralUtility.ConvertDisplayMonthStringFormat(entity.AccMonth);
            }
            divAccuracy.Attributes.Add("style", "");
            ddlQAT.Enabled = false;
            ddlCenterName.Enabled = false;
           // divAccuracy.Style = ""; 
            btnSubmit.Text = "Update";
        }

        private void BindQAT()
        {
            var result = new AccuracyPercentage().FindQAT();
            this.ddlQAT.Items.Clear();
            ddlQAT.Items.Insert(0, "Select");
                for (int i = 0; i < result.Count; i++)
                {
                    ddlQAT.Items.Insert(i + 1, new ListItem(result[i].QAT, result[i].QAT));
                }
            
        }

        protected void ddlCenterName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var result = new AccuracyPercentage().FindQAT();
                if (ddlCenterName.SelectedValue != "All")
                {
                    var qats = (from data in result.Where(x => x.Center == this.ddlCenterName.SelectedValue).ToList()
                                     select data).ToList();
                    ddlQAT.Items.Clear();
                    ddlQAT.Items.Insert(0, "Select");
                    for (int i = 0; i < qats.Count; i++)
                    {
                        ddlQAT.Items.Insert(i + 1, new ListItem(qats[i].QAT, qats[i].QAT));
                    }
                }
                else
                {
                    ddlQAT.Items.Clear();
                    ddlQAT.Items.Insert(0, "Select");
                    for (int i = 0; i < result.Count; i++)
                    {
                        ddlQAT.Items.Insert(i + 1, new ListItem(result[i].QAT, result[i].QAT));
                    }
                }
                //btnSearch_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.MessageShow(this.GetType(), ex.Message.ToString(), ClientScript);
            }
        }

       
    }
}