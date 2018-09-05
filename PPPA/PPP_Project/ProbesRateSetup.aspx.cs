using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Transactions;
using System.Web.UI.WebControls;
using PPP_Project.Common.Message;
using PPP_Project.Business;
using PPP_Project.Entity;
using PPP_Project.Common.Utility;

namespace PPP_Project
{
    public partial class ProbesRateSetup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                BindGrid();
            }
        }


        private bool ValidateForm()
        {
            if (txtRate1.Text == "")
            {
                MessageBox.MessageShow(this.GetType(), "Please Type Rate.", ClientScript);
                txtRate1.Focus();
                return false;
            }
            if (txtRate2.Text == "")
            {
                MessageBox.MessageShow(this.GetType(), "Please type Rate.", ClientScript);
                txtRate2.Focus();
                return false;
            }
            if (txtRate3.Text == "")
            {
                MessageBox.MessageShow(this.GetType(), "Please type Rate.", ClientScript);
                txtRate3.Focus();
                return false;
            }

            if(txtMonth.Text=="")
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
                return;
            using (TransactionScope scope = new TransactionScope())
            {
                if (btnSubmit.Text == "Submit")
                {
                    try
                    {
                        var userEntity = (UserEntity)Session["ID"];
                        new ProbesRate
                        {
                            Entity = new RateEntity
                            {
                                ID = GeneralUtility.GeneratedKey,
                                Rate1 = Convert.ToDecimal(txtRate1.Text),
                                Rate2 = Convert.ToDecimal(txtRate2.Text),
                                Rate3 = Convert.ToDecimal(txtRate3.Text),
                                RatedYear = GeneralUtility.ConvertMonthYearStringFormat(txtMonth.Text.Trim()),
                                Createdby = userEntity.ID,
                                UpdatedBy = userEntity.ID,
                                UpdatedDate = GeneralUtility.ConvertSystemDateStringFormat(System.DateTime.Now)
                            }
                        }.Save();
                        MessageBox.MessageShow(this.GetType(), "Successfully Save.", ClientScript);
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
                        var userEntity = (UserEntity)Session["ID"];
                        new ProbesRate
                        {
                            Entity = new RateEntity
                            {
                                ID = ID = hdID.Value,
                                Rate1 = Convert.ToDecimal(txtRate1.Text),
                                Rate2 = Convert.ToDecimal(txtRate2.Text),
                                Rate3 = Convert.ToDecimal(txtRate3.Text),
                                RatedYear = GeneralUtility.ConvertMonthYearStringFormat(txtMonth.Text.Trim()),
                                Createdby = userEntity.ID,
                                UpdatedBy = userEntity.ID,
                                UpdatedDate = GeneralUtility.ConvertSystemDateStringFormat(System.DateTime.Now),
                            }
                        }.Update();
                        MessageBox.MessageShow(this.GetType(), "Successfully Updated.", ClientScript);
                        btnSubmit.Text = "Submit";
                        scope.Complete();

                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            txtRate1.Text = "";
            txtRate2.Text = "";
            txtRate3.Text = "";
            txtMonth.Text = "";
            BindGrid();

            //if (btnSubmit.Text == "Submit")
            //{

            //    using (TransactionScope scope = new TransactionScope())
            //    {

            //        try
            //        {
            //            var entity = new ProbesRate().FindRate();
            //            var userEntity = (UserEntity)Session["ID"];
            //            if (entity != null)
            //            {
            //                //ID = hdID.Value;
            //                entity.Rate1 = Convert.ToInt32(txtRate1.Text);
            //                entity.Rate2 = Convert.ToInt32(txtRate2.Text);
            //                entity.Rate3 = Convert.ToInt32(txtRate3.Text);
            //                entity.RatedYear = GeneralUtility.ConvertMonthYearStringFormat(txtMonth.Text.Trim());
            //                entity.Createdby = entity.Createdby;
            //                entity.UpdatedBy = userEntity.ID;
            //                entity.UpdatedDate = GeneralUtility.ConvertSystemDateStringFormat(System.DateTime.Now);
            //                var business = new ProbesRate();
            //                business.Entity = entity;
            //                business.Update();
            //                MessageBox.MessageShow(this.GetType(), "Successfully Updated.", ClientScript);
            //            }
            //            else
            //            {
            //                 //string RYear=string.Empty;
            //                 //RYear = GeneralUtility.ConvertMonthYearStringFormat(txtMonth.Text.Trim());
            //                new ProbesRate
            //                {
            //                    Entity = new RateEntity
            //                    {
            //                        ID = GeneralUtility.GeneratedKey,
            //                        Rate1 = Convert.ToInt32(txtRate1.Text),
            //                        Rate2 = Convert.ToInt32(txtRate2.Text),
            //                        Rate3 = Convert.ToInt32(txtRate3.Text),
            //                        RatedYear = GeneralUtility.ConvertMonthYearStringFormat(txtMonth.Text.Trim()),
            //                        Createdby = userEntity.ID,
            //                        UpdatedBy = userEntity.ID,
            //                        UpdatedDate = GeneralUtility.ConvertSystemDateStringFormat(System.DateTime.Now)
            //                    }
            //                }.Save();
            //                MessageBox.MessageShow(this.GetType(), "Successfully Save.", ClientScript);
            //            }

            //            scope.Complete();
            //        }
            //        catch (Exception ex)
            //        {
            //            throw ex;
            //        }
            //    }
            //}

            //else
            //{
            //    MessageBox.MessageShow(this.GetType(), "Please Choose Date!.", ClientScript);
            //}
            
        }

        private void DisplayData()
        {

            var rateInfoEntity = new ProbesRate().FindRate();               

            if (rateInfoEntity != null)
            {

                this.txtRate1.Text = rateInfoEntity.Rate1.ToString();
                this.txtRate2.Text = rateInfoEntity.Rate2.ToString();
                this.txtRate3.Text = rateInfoEntity.Rate3.ToString();
                this.txtMonth.Text = GeneralUtility.ConvertDisplayMonthStringFormat(rateInfoEntity.RatedYear);
              
            }
        }

        private void BindGrid()
        {
            gvProbesRate.Columns[0].Visible = true;
            ProbesRate Pbusiness = new ProbesRate();
            var list = Pbusiness.Find();
            var reslist = from data in list
                          select new { data.ID, data.Rate1, data.Rate2, data.Rate3, RatedYear=GeneralUtility.ConvertDisplayMonthStringFormat(data.RatedYear), CreatedDate = GeneralUtility.ConvertDisplayDateStringFormat(data.CreatedDate), data.Createdby };
            gvProbesRate.DataSource = reslist.ToList();
            gvProbesRate.Columns[1].HeaderText = Pbusiness.getRangeLabel(1);
            gvProbesRate.Columns[2].HeaderText = Pbusiness.getRangeLabel(2);
            gvProbesRate.Columns[3].HeaderText = Pbusiness.getRangeLabel(3);
            gvProbesRate.DataBind();
            
            gvProbesRate.Columns[0].Visible = false;
            gvProbesRate.Columns[5].Visible = false;
            gvProbesRate.Columns[6].Visible = false;

        }

        protected void gvProbesRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            hdID.Value = gvProbesRate.SelectedRow.Cells[0].Text;
            string id = hdID.Value.ToString();
            ProbesRate business = new ProbesRate();
            var entity = business.FindDataByID(id);
            if (entity != null)
            {
                this.txtRate1.Text = entity.Rate1.ToString();
                this.txtRate2.Text = entity.Rate2.ToString();
                this.txtRate3.Text = entity.Rate3.ToString();
                this.txtMonth.Text = GeneralUtility.ConvertDisplayMonthStringFormat(entity.RatedYear);

                lblRange1.Text = business.getRangeLabel(1);
                lblRange2.Text = business.getRangeLabel(2);
                lblRange3.Text = business.getRangeLabel(3);

            }
            btnSubmit.Text = "Update";
        }
    }
}