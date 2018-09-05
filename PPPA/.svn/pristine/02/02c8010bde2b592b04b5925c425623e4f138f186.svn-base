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
    public partial class AccuracyPercentRateSetup : System.Web.UI.Page
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
            if (txtAccPercentRate1.Text == "")
            {
                MessageBox.MessageShow(this.GetType(), "Please Type Rate.", ClientScript);
                txtAccPercentRate1.Focus();
                return false;
            }
            if (txtAccPercentRate2.Text == "")
            {
                MessageBox.MessageShow(this.GetType(), "Please type Rate.", ClientScript);
                txtAccPercentRate2.Focus();
                return false;
            }
            if (txtAccPercentRate3.Text == "")
            {
                MessageBox.MessageShow(this.GetType(), "Please type Rate.", ClientScript);
                txtAccPercentRate3.Focus();
                return false;
            }

            if (txtAccPerMonth.Text == "")
            {
                MessageBox.MessageShow(this.GetType(), "Please Choose Month.", ClientScript);
                txtAccPerMonth.Focus();
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
                        new AccuracyPercentRate
                        {
                            Entity = new AccPerRateEntity
                            {
                                ID = GeneralUtility.GeneratedKey,
                                AccPerRate1 = Convert.ToInt32(txtAccPercentRate1.Text),
                                AccPerRate2 = Convert.ToInt32(txtAccPercentRate2.Text),
                                AccPerRate3 = Convert.ToInt32(txtAccPercentRate3.Text),
                                AccPerRatedYear = GeneralUtility.ConvertMonthYearStringFormat(txtAccPerMonth.Text.Trim()),
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
                        new AccuracyPercentRate
                        {
                            Entity = new AccPerRateEntity
                            {
                                ID = ID = hdID.Value,
                                AccPerRate1 = Convert.ToInt32(txtAccPercentRate1.Text),
                                AccPerRate2 = Convert.ToInt32(txtAccPercentRate2.Text),
                                AccPerRate3 = Convert.ToInt32(txtAccPercentRate3.Text),
                                AccPerRatedYear = GeneralUtility.ConvertMonthYearStringFormat(txtAccPerMonth.Text.Trim()),
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
            txtAccPercentRate1.Text = "";
            txtAccPercentRate2.Text = "";
            txtAccPercentRate3.Text = "";
            txtAccPerMonth.Text = "";
            BindGrid();

        

        }

        private void DisplayData()
        {

            var rateInfoEntity = new AccuracyPercentRate().FindRate();

            if (rateInfoEntity != null)
            {

                this.txtAccPercentRate1.Text = rateInfoEntity.AccPerRate1.ToString();
                this.txtAccPercentRate2.Text = rateInfoEntity.AccPerRate2.ToString();
                this.txtAccPercentRate3.Text = rateInfoEntity.AccPerRate3.ToString();
                this.txtAccPerMonth.Text = GeneralUtility.ConvertDisplayMonthStringFormat(rateInfoEntity.AccPerRatedYear);

            }
        }

        private void BindGrid()
        {
            gvAccPerRate.Columns[0].Visible = true;
            AccuracyPercentRate Pbusiness = new AccuracyPercentRate();
            var list = Pbusiness.Find();
            var reslist = from data in list
                          select new { data.ID, data.AccPerRate1, data.AccPerRate2, data.AccPerRate3, AccPerRatedYear = GeneralUtility.ConvertDisplayMonthStringFormat(data.AccPerRatedYear), CreatedDate = GeneralUtility.ConvertDisplayDateStringFormat(data.CreatedDate), data.Createdby };
            gvAccPerRate.DataSource = reslist.ToList();
            gvAccPerRate.DataBind();
            gvAccPerRate.Columns[0].Visible = false;
            gvAccPerRate.Columns[5].Visible = false;
            gvAccPerRate.Columns[6].Visible = false;

        }

        protected void gvAccPerRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            hdID.Value = gvAccPerRate.SelectedRow.Cells[0].Text;
            string id = hdID.Value.ToString();
            AccuracyPercentRate business = new AccuracyPercentRate();
            var entity = business.FindDataByID(id);
            if (entity != null)
            {
                this.txtAccPercentRate1.Text = entity.AccPerRate1.ToString();
                this.txtAccPercentRate2.Text = entity.AccPerRate2.ToString();
                this.txtAccPercentRate3.Text = entity.AccPerRate3.ToString();
                this.txtAccPerMonth.Text = GeneralUtility.ConvertDisplayMonthStringFormat(entity.AccPerRatedYear);
            }
            btnSubmit.Text = "Update";
        }
    }
}