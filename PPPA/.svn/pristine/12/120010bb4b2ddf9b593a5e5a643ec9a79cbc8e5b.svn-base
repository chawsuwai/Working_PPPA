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
using PPP_Project.Criteria;

namespace PPP_Project
{
    public partial class ProjectDenominatorMonthlySetup : System.Web.UI.Page
    {
        string date;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (!IsPostBack)
                {
                    var date1 = GeneralUtility.ConvertDisplayDateStringFormat(System.DateTime.Now);
                    date = GeneralUtility.ConvertSystemDateStringFormat(txtMonth.Text);
                    txtMonth.Text = date1.Substring(3, 7).ToString();

                    divProbes.Attributes.Add("style", "");
                    divPricing.Attributes.Add("style", "");
                    divMask.Attributes.Add("style", "");

                    divRepricing.Attributes.Add("style", "");
                    divSceneRecog.Attributes.Add("style", "");
                    divScene.Attributes.Add("style", "");

                    divExpert.Attributes.Add("style", "");
                    BindGrid();
                }
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(this.txtProject.Text.Trim()))
            {
                MessageBox.MessageShow(this.GetType(), "Please type PROJECT.", ClientScript);
                this.txtProject.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(this.txtMonth.Text.Trim()))
            {
                MessageBox.MessageShow(this.GetType(), "Please choose Month.", ClientScript);
                this.txtMonth.Focus();
                return false;
            }
            //if (txtProbes.Text == "" && txtPricingProbes.Text == "" && txtMasks.Text == "" && txtRepricing.Text == "" && txtScenes.Text == "" && txtSceneRecog.Text == "" && txtCategoryExpert.Text == "")
            //{
            //    MessageBox.MessageShow(this.GetType(), "Please type Denominator.", ClientScript);
            //    txtProbes.Focus();
            //    return false;
            //} 

            var entity = new ProjectDenominators().FindDataByProjectAndMonth(this.txtProject.Text.Trim(), GeneralUtility.ConvertMonthYearStringFormat(txtMonth.Text.Trim()));
            if (entity != null)
            {
                MessageBox.MessageShow(this.GetType(), "This Project already exits.", ClientScript);
                this.txtProject.Focus();
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
                if (btnSubmit.Text != "Search")
                {
                    try
                    {

                        var userEntity = (UserEntity)Session["ID"];
                        new ProjectDenominators
                        {
                            Entity = new ProjectDenominatorsEntity
                            {
                                ID = GeneralUtility.GeneratedKey,
                                PROJECT = this.txtProject.Text.Trim().ToUpper(),
                                DenoMonth = GeneralUtility.ConvertMonthYearStringFormat(txtMonth.Text.Trim()),
                                Probes = Convert.ToDecimal(string.IsNullOrEmpty(txtProbes.Text) ? "0" : txtProbes.Text),
                                Pricingprobes = Convert.ToDecimal(string.IsNullOrEmpty(txtPricingProbes.Text) ? "0" : txtPricingProbes.Text),
                                Masks = Convert.ToDecimal(string.IsNullOrEmpty(txtMasks.Text) ? "0" : txtMasks.Text),
                                Repricing = Convert.ToDecimal(string.IsNullOrEmpty(txtRepricing.Text) ? "0" : txtRepricing.Text),
                                SceneRecog = Convert.ToDecimal(string.IsNullOrEmpty(txtSceneRecog.Text) ? "0" : txtSceneRecog.Text),
                                ProbesperScene = Convert.ToDecimal(string.IsNullOrEmpty(txtScenes.Text) ? "0" : txtScenes.Text),
                                Expert = Convert.ToDecimal(string.IsNullOrEmpty(txtCategoryExpert.Text) ? "0" : txtCategoryExpert.Text),
                                Createdby = userEntity.ID,
                            }
                        }.Save();

                        MessageBox.MessageShow(this.GetType(), "Successfully Save.", ClientScript);
                        btnSubmit.Text = "Submit";
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

            this.txtProject.Text = string.Empty;
            txtProbes.Text = "";
            txtPricingProbes.Text = "";
            txtMasks.Text = "";
            txtRepricing.Text = "";
            txtScenes.Text = "";
            txtSceneRecog.Text = "";
            txtCategoryExpert.Text = "";

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            var date1 = GeneralUtility.ConvertDisplayDateStringFormat(System.DateTime.Now);
            date = GeneralUtility.ConvertSystemDateStringFormat(txtMonth.Text);
            txtMonth.Text = date1.Substring(3, 7).ToString();

            this.hdID.Value = string.Empty;
            this.hdProject.Value = string.Empty;
            this.txtProject.Text = string.Empty;
            this.txtProbes.Text = string.Empty;
            this.txtPricingProbes.Text = string.Empty;
            this.txtMasks.Text = string.Empty;
            this.txtRepricing.Text = string.Empty;
            this.txtScenes.Text = string.Empty;
            this.txtSceneRecog.Text = string.Empty;
            this.txtCategoryExpert.Text = string.Empty;
            btnSubmit.Text = "Submit";
            //divProbes.Attributes.Add("style", "display:none");
            //divPricing.Attributes.Add("style", "display:none");
            //divMask.Attributes.Add("style", "display:none");
            //divRepricing.Attributes.Add("style", "display:none");
            //divSceneRecog.Attributes.Add("style", "display:none");
            //divScene.Attributes.Add("style", "display:none");
            //divExpert.Attributes.Add("style", "display:none");
            BindGrid();

        }

        private void BindGrid()
        {
            gvDenoChange.Columns[0].Visible = true;
            ProjectDenominators Pbusiness = new ProjectDenominators();
            var list = Pbusiness.Find();
            string month = GeneralUtility.ConvertMonthYearStringFormat(txtMonth.Text.Trim());
            //if (ddlPROJECT.SelectedValue != "All")
            //{
            //    list = list.Where(x => x.DenoMonth == month && x.PROJECT == ddlPROJECT.SelectedValue).ToList();
            //}
            //else
            //{
            //    list = list.Where(x => x.DenoMonth == month).ToList();
            //}

            var reslist = from data in list
                          select new { data.ID, data.PROJECT, data.Probes, data.Pricingprobes, data.Masks, data.Repricing, data.SceneRecog, data.ProbesperScene, data.Expert, DenoMonth = GeneralUtility.ConvertDisplayMonthStringFormat(data.DenoMonth), CreatedDate = GeneralUtility.ConvertDisplayDateStringFormat(data.CreatedDate), data.Createdby };
            gvDenoChange.DataSource = reslist.ToList();
            gvDenoChange.DataBind();
            gvDenoChange.Columns[0].Visible = false;
            gvDenoChange.Columns[10].Visible = false;
            gvDenoChange.Columns[11].Visible = false;

        }

        protected void gvDenoChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            hdID.Value = gvDenoChange.SelectedRow.Cells[0].Text;
            hdProject.Value = gvDenoChange.SelectedRow.Cells[1].Text;
            string id = hdID.Value.ToString();
            ProjectDenominators business = new ProjectDenominators();
            var entity = business.FindDataByID(id);
            if (entity != null)
            {
                this.txtProject.Text = entity.PROJECT;
                this.txtProbes.Text = entity.Probes.ToString();
                this.txtPricingProbes.Text = entity.Pricingprobes.ToString();
                this.txtMasks.Text = entity.Masks.ToString();
                this.txtRepricing.Text = entity.Repricing.ToString();
                this.txtScenes.Text = entity.ProbesperScene.ToString();
                this.txtSceneRecog.Text = entity.SceneRecog.ToString();
                this.txtCategoryExpert.Text = entity.Expert.ToString();
                this.txtMonth.Text = GeneralUtility.ConvertDisplayMonthStringFormat(entity.DenoMonth);
            }
            divProbes.Attributes.Add("style", "");
            divPricing.Attributes.Add("style", "");
            divMask.Attributes.Add("style", "");

            divRepricing.Attributes.Add("style", "");
            divSceneRecog.Attributes.Add("style", "");
            divScene.Attributes.Add("style", "");

            divExpert.Attributes.Add("style", "");
            btnSubmit.Text = "Update";
        }
    }
}