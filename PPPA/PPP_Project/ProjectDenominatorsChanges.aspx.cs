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
using PPP_Project.Common.Feature;
using PPP_Project.Common.Enum;
using PPP_Project.Common.Extension;
using System.Globalization;

namespace PPP_Project
{
    public partial class ProjectDenominatorsChanges : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {              
                BindPROJECT();
                if (!IsPostBack)
                {
                    BindGrid();
                }
                string sPROJECT = Request.QueryString["PROJECT"];
                if(!string.IsNullOrEmpty (sPROJECT))
                {
                    hdID.Value = sPROJECT;
                    string id = hdID.Value.ToString();
                    DenoChange business = new DenoChange();
                    var entity = business.FindDataByID(id);
                    if (entity != null)
                    {
                        this.ddlPROJECT.SelectedValue = entity.PROJECT;
                        this.txtProbes.Text = entity.Probes.ToString();
                        this.txtPricingProbes.Text = entity.Pricingprobes.ToString();
                        this.txtVotes.Text = entity.Votes.ToString();
                        this.txtMasks.Text = entity.Masks.ToString();
                        this.txtRepricing.Text = entity.Repricing.ToString();
                        this.txtScenes.Text = entity.ProbesperScene.ToString();
                        this.txtSceneRecog.Text = entity.SceneRecog.ToString();
                        this.txtCategoryExpert.Text = entity.Expert.ToString();
                        this.txtExpertVoting.Text = entity.ExpertVoting.ToString();
                        this.txtDcDate.Text = GeneralUtility.ConvertDisplayDateStringFormat(entity.DCDate);
                        this.txtDcDateTo.Text = GeneralUtility.ConvertDisplayDateStringFormat(entity.DCDate);
                    }
                    btnSubmit.Text = "Update";
                }
            }
        }

        private bool ValidateForm()
        {
            if (this.ddlPROJECT.SelectedItem.Text == "Select")
            {
                MessageBox.MessageShow(this.GetType(), "Please choose PROJECT.", ClientScript);
                this.ddlPROJECT.Focus();
                return false;
            }

            if (txtProbes.Text == "" && txtPricingProbes.Text == "" && txtVotes.Text == "" && txtMasks.Text == "" && txtRepricing.Text == "" && txtScenes.Text == "" && txtSceneRecog.Text == "" && txtCategoryExpert.Text == "" && txtExpertVoting.Text == "")
            {
                MessageBox.MessageShow(this.GetType(), "Please type Denominator.", ClientScript);
                txtProbes.Focus();
                return false;
            }

            if (txtDcDate.Text == "")
            {
                MessageBox.MessageShow(this.GetType(), "Please Choose Date.", ClientScript);
                txtDcDate.Focus();
                return false;
            }

            return true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime vSetDate, vFromDate, vToDate;

            if (!ValidateForm())
                return;

            if (txtDcDate.Text != "" && txtDcDateTo.Text == "")
            {
                txtDcDateTo.Text = txtDcDate.Text;
            }

            using (TransactionScope scope = new TransactionScope())
            {
                if (btnSubmit.Text == "Submit")
                {                   
                    try
                    {
                        var userEntity = (UserEntity)Session["ID"];
                        ProjectDenominators dc = new ProjectDenominators();
                        DenoChange change = new DenoChange();
                        string projectname = ddlPROJECT.SelectedValue.ToString();
                        string multiplydate = GeneralUtility.ConvertSystemDateStringFormat(txtDcDate.Text.Trim()).Substring(0, 6);
                        string count = "";
                       System.Nullable<Decimal> probesvalue;
                       System.Nullable<Decimal> pricingprobesvalue;
                       System.Nullable<Decimal> votesvalue;
                       System.Nullable<Decimal> masksvalue;
                       System.Nullable<Decimal> repricingvalue;
                       System.Nullable<Decimal> scenerecogvalue;
                       System.Nullable<Decimal> probesperscenevalue;
                       System.Nullable<Decimal> expertvalue;
                       System.Nullable<Decimal> expertvotingvalue;

                        //vFromDate = Convert.ToDateTime(txtDcDate.Text.Trim());
                        //vToDate = Convert.ToDateTime(txtDcDateTo.Text.Trim());

                       vFromDate = DateTime.ParseExact(GeneralUtility.ConvertDisplayDateStringFormat(this.txtDcDate.Text.Trim()), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                           //Convert.ToDateTime(GeneralUtility.ConvertDisplayDateStringFormat(txtDcDate.Text.Trim()));
                       vToDate = DateTime.ParseExact(GeneralUtility.ConvertDisplayDateStringFormat(this.txtDcDateTo.Text.Trim()), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                           //Convert.ToDateTime(GeneralUtility.ConvertDisplayDateStringFormat(txtDcDateTo.Text.Trim()));

                        vSetDate = vFromDate;

                        while (vSetDate <= vToDate)
                        {
                            count = change.getCountForProject(projectname, GeneralUtility.ConvertSystemDateStringFormat(vSetDate));
                            if (count == "0")
                            {
                                if (txtProbes.Text != "" && txtProbes.Text != "0")
                                {
                                    probesvalue = Convert.ToDecimal(txtProbes.Text);
                                }

                                else
                                {
                                    probesvalue = null;
                                }

                                if (txtPricingProbes.Text != "" && txtPricingProbes.Text != "0")
                                {
                                    pricingprobesvalue = Convert.ToDecimal(txtPricingProbes.Text);
                                }

                                else
                                {
                                    pricingprobesvalue = null;
                                }

                                if (txtVotes.Text != "" && txtVotes.Text != "0")
                                {
                                    votesvalue = Convert.ToDecimal(txtVotes.Text);
                                }

                                else
                                {
                                    votesvalue = null;
                                }

                                if (txtMasks.Text != "" && txtMasks.Text != "0")
                                {
                                    masksvalue = Convert.ToDecimal(txtMasks.Text);
                                }

                                else
                                {
                                    masksvalue = null;
                                }


                                if (txtRepricing.Text != "" && txtRepricing.Text != "0")
                                {
                                    repricingvalue = Convert.ToDecimal(txtRepricing.Text);
                                }

                                else
                                {
                                    repricingvalue = null;
                                }

                                if (txtSceneRecog.Text != "" && txtSceneRecog.Text != "0")
                                {
                                    scenerecogvalue = Convert.ToDecimal(txtSceneRecog.Text);
                                }

                                else
                                {
                                    scenerecogvalue = null;
                                }

                                if (txtScenes.Text != "" && txtScenes.Text != "0")
                                {
                                    probesperscenevalue = Convert.ToDecimal(txtScenes.Text);
                                }

                                else
                                {
                                    probesperscenevalue = null;
                                }

                                if (txtCategoryExpert.Text != "" && txtCategoryExpert.Text != "0")
                                {
                                    expertvalue = Convert.ToDecimal(txtCategoryExpert.Text);
                                }

                                else
                                {
                                    expertvalue = null;
                                }

                                if (txtExpertVoting.Text != "" && txtExpertVoting.Text != "0")
                                {
                                    expertvotingvalue = Convert.ToDecimal(txtExpertVoting.Text);
                                }

                                else
                                {
                                    expertvotingvalue = null;
                                }



                                new DenoChange
                                   {
                                       Entity = new DenoChangeEntity
                                       {
                                           ID = GeneralUtility.GeneratedKey,
                                           PROJECT = ddlPROJECT.SelectedValue.ToString(),
                                           DCDate = GeneralUtility.ConvertSystemDateStringFormat(vSetDate),
                                           Probes = probesvalue,
                                           Pricingprobes = pricingprobesvalue,
                                           Votes = votesvalue,
                                           Masks = masksvalue,
                                           Repricing = repricingvalue,
                                           SceneRecog = scenerecogvalue,
                                           ProbesperScene = probesperscenevalue,
                                           Expert = expertvalue,
                                           ExpertVoting = expertvotingvalue,


                                           // Probes = Convert.ToDecimal(string.IsNullOrEmpty(txtProbes.Text) ? "0" : txtProbes.Text),                                      
                                           //Pricingprobes = Convert.ToDecimal(string.IsNullOrEmpty(txtPricingProbes.Text) ? "0" : txtPricingProbes.Text),
                                           //Votes = Convert.ToDecimal(string.IsNullOrEmpty(txtVotes.Text) ? "0" : txtVotes.Text),
                                           //Masks = Convert.ToDecimal(string.IsNullOrEmpty(txtMasks.Text) ? "0" : txtMasks.Text),
                                           //Repricing = Convert.ToDecimal(string.IsNullOrEmpty(txtRepricing.Text) ? "0" : txtRepricing.Text),
                                           //SceneRecog = Convert.ToDecimal(string.IsNullOrEmpty(txtSceneRecog.Text) ? "0" : txtSceneRecog.Text),
                                           //ProbesperScene = Convert.ToDecimal(string.IsNullOrEmpty(txtScenes.Text) ? "0" : txtScenes.Text),
                                           //Expert = Convert.ToDecimal(string.IsNullOrEmpty(txtCategoryExpert.Text) ? "0" : txtCategoryExpert.Text),
                                           //Probes = Convert.ToDecimal(dc.getDenominatorForProject(projectname, multiplydate, multiply, "Probes")),
                                           //Pricingprobes = Convert.ToDecimal(dc.getDenominatorForProject(projectname, multiplydate, multiply, "Pricingprobes")),
                                           //Masks = Convert.ToDecimal(dc.getDenominatorForProject(projectname, multiplydate, multiply, "Masks")),
                                           //Repricing = Convert.ToDecimal(dc.getDenominatorForProject(projectname, multiplydate, multiply, "Repricing")),
                                           //SceneRecog = Convert.ToDecimal(dc.getDenominatorForProject(projectname, multiplydate, multiply, "SceneRecog")),
                                           //ProbesperScene = Convert.ToDecimal(dc.getDenominatorForProject(projectname, multiplydate, multiply, "ProbesperScene")),
                                           //Expert = Convert.ToDecimal(dc.getDenominatorForProject(projectname, multiplydate, multiply, "Expert")),
                                           Createdby = userEntity.ID,
                                           UpdatedBy = userEntity.ID,
                                           UpdatedDate = GeneralUtility.ConvertSystemDateStringFormat(System.DateTime.Now),
                                       }
                                   }.Save();
                            }
                            else
                            {
                                //MessageBox.MessageShow(this.GetType(), "This Project already exits in '" + vSetDate.ToString("dd-MMM-yyyy") + "'! This date will be skipped!", ClientScript);

                                Update_Submit(vSetDate, vSetDate, vSetDate);
                            }

                            vSetDate = vSetDate.AddDays(1);
                        }

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
                        vFromDate = DateTime.ParseExact(GeneralUtility.ConvertDisplayDateStringFormat(this.txtDcDate.Text.Trim()), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            //Convert.ToDateTime(GeneralUtility.ConvertDisplayDateStringFormat(txtDcDate.Text.Trim()));
                        vToDate = DateTime.ParseExact(GeneralUtility.ConvertDisplayDateStringFormat(this.txtDcDateTo.Text.Trim()), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            //Convert.ToDateTime(GeneralUtility.ConvertDisplayDateStringFormat(txtDcDateTo.Text.Trim()));
                            //Convert.ToDateTime(txtDcDateTo.Text.Trim());

                        vSetDate = vFromDate;

                        Update_Submit(vFromDate, vToDate, vSetDate);
                     
                      //  MessageBox.MessageShow(this.GetType(), "Successfully Updated.", ClientScript);
                      //  btnSubmit.Text = "Submit";
                        string msg = "Successfully Updated.";
                        scope.Complete();

                        if (!string.IsNullOrEmpty(hdID.Value))
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(),
                              "alert",
                              "alert('" + msg + "');window.location ='ProjectDenominatorList.aspx';",
                              true);
                        }
                        else
                        {
                            MessageBox.MessageShow(this.GetType(), msg, ClientScript); 
                        } 
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
            this.hdID.Value = string.Empty;
            ddlPROJECT.SelectedValue = "Select";
            txtDcDate.Text = "";
            txtDcDateTo.Text = "";
            txtProbes.Text = "";              
            txtPricingProbes.Text="";
            txtVotes.Text = "";
            txtMasks.Text="";
            txtRepricing.Text="";
            txtScenes.Text="";
            txtSceneRecog.Text="";
            txtCategoryExpert.Text = "";
            txtExpertVoting.Text = "";
            BindGrid();

        }

        private void Update_Submit(DateTime vFromDate, DateTime vToDate, DateTime vSetDate)
        {
            try
            {
                var userEntity = (UserEntity)Session["ID"];
                ProjectDenominators dc2 = new ProjectDenominators();
                string projectname = ddlPROJECT.SelectedValue.ToString();
                string multiplydate = GeneralUtility.ConvertSystemDateStringFormat(txtDcDate.Text.Trim()).Substring(0, 6);
                //decimal multiply = Convert.ToDecimal(txtDcTimes.Text);

                DBReader<DenoChangeEntity> dr = new DBReader<DenoChangeEntity>();
                string DcID = dr.ExcuteScalar("Select ID From DenoChange Where Project = '" + projectname + "' And DCDate = '" + GeneralUtility.ConvertSystemDateStringFormat(vSetDate) + "'", null, ConnectionDAO.Client.ToConnectionString()).ToString();

                string DChangeDate = GeneralUtility.ConvertSystemDateStringFormat(txtDcDate.Text.Trim());
                System.Nullable<Decimal> probesvalue;
                System.Nullable<Decimal> pricingprobesvalue;
                System.Nullable<Decimal> votesvalue;
                System.Nullable<Decimal> masksvalue;
                System.Nullable<Decimal> repricingvalue;
                System.Nullable<Decimal> scenerecogvalue;
                System.Nullable<Decimal> probesperscenevalue;
                System.Nullable<Decimal> expertvalue;
                System.Nullable<Decimal> expertvotingvalue;
                if (txtProbes.Text != "" && txtProbes.Text != "0")
                {
                    probesvalue = Convert.ToDecimal(txtProbes.Text);
                }

                else
                {
                    probesvalue = null;
                }

                if (txtPricingProbes.Text != "" && txtPricingProbes.Text != "0")
                {
                    pricingprobesvalue = Convert.ToDecimal(txtPricingProbes.Text);
                }

                else
                {
                    pricingprobesvalue = null;
                }

                if (txtVotes.Text != "" && txtVotes.Text != "0")
                {
                    votesvalue = Convert.ToDecimal(txtVotes.Text);
                }

                else
                {
                    votesvalue = null;
                }

                if (txtMasks.Text != "" && txtMasks.Text != "0")
                {
                    masksvalue = Convert.ToDecimal(txtMasks.Text);
                }

                else
                {
                    masksvalue = null;
                }


                if (txtRepricing.Text != "" && txtRepricing.Text != "0")
                {
                    repricingvalue = Convert.ToDecimal(txtRepricing.Text);
                }

                else
                {
                    repricingvalue = null;
                }

                if (txtSceneRecog.Text != "" && txtSceneRecog.Text != "0")
                {
                    scenerecogvalue = Convert.ToDecimal(txtSceneRecog.Text);
                }

                else
                {
                    scenerecogvalue = null;
                }

                if (txtScenes.Text != "" && txtScenes.Text != "0")
                {
                    probesperscenevalue = Convert.ToDecimal(txtScenes.Text);
                }

                else
                {
                    probesperscenevalue = null;
                }

                if (txtCategoryExpert.Text != "" && txtCategoryExpert.Text != "0")
                {
                    expertvalue = Convert.ToDecimal(txtCategoryExpert.Text);
                }

                else
                {
                    expertvalue = null;
                }

                if (txtExpertVoting.Text != "" && txtExpertVoting.Text != "0")
                {
                    expertvotingvalue = Convert.ToDecimal(txtExpertVoting.Text);
                }

                else
                {
                    expertvotingvalue = null;
                }

                while (vSetDate <= vToDate)
                {
                    new DenoChange
                    {
                        Entity = new DenoChangeEntity
                        {
                            ID = DcID,
                            PROJECT = projectname,
                            DCDate = GeneralUtility.ConvertSystemDateStringFormat(vSetDate),
                            Probes = probesvalue,
                            Pricingprobes = pricingprobesvalue,
                            Votes = votesvalue,
                            Masks = masksvalue,
                            Repricing = repricingvalue,
                            SceneRecog = scenerecogvalue,
                            ProbesperScene = probesperscenevalue,
                            Expert = expertvalue,
                            ExpertVoting = expertvotingvalue,
                            //Probes = Convert.ToDecimal(string.IsNullOrEmpty(txtProbes.Text) ? "0" : txtProbes.Text),
                            //Pricingprobes = Convert.ToDecimal(string.IsNullOrEmpty(txtPricingProbes.Text) ? "0" : txtPricingProbes.Text),
                            //Votes = Convert.ToDecimal(string.IsNullOrEmpty(txtVotes.Text) ? "0" : txtVotes.Text),
                            //Masks = Convert.ToDecimal(string.IsNullOrEmpty(txtMasks.Text) ? "0" : txtMasks.Text),
                            //Repricing = Convert.ToDecimal(string.IsNullOrEmpty(txtRepricing.Text) ? "0" : txtRepricing.Text),
                            //SceneRecog = Convert.ToDecimal(string.IsNullOrEmpty(txtSceneRecog.Text) ? "0" : txtSceneRecog.Text),
                            //ProbesperScene = Convert.ToDecimal(string.IsNullOrEmpty(txtScenes.Text) ? "0" : txtScenes.Text),
                            //Expert = Convert.ToDecimal(string.IsNullOrEmpty(txtCategoryExpert.Text) ? "0" : txtCategoryExpert.Text),
                            Createdby = userEntity.ID,
                            UpdatedBy = userEntity.ID,
                            UpdatedDate = GeneralUtility.ConvertSystemDateStringFormat(System.DateTime.Now),
                        }
                    }.Update();
                    vSetDate = vSetDate.AddDays(1);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void BindGrid()
        {
            gvDenoChange.Columns[0].Visible = true;
            DenoChange Pbusiness = new DenoChange();
            var list = Pbusiness.Find();
            var reslist = from data in list
                          select new { data.ID, data.PROJECT, data.Probes, data.Pricingprobes, data.Votes, data.Masks, data.Repricing, data.SceneRecog, data.ProbesperScene, data.Expert,data.ExpertVoting, DCDate = GeneralUtility.ConvertDisplayDateStringFormat(data.DCDate),CreatedDate = GeneralUtility.ConvertDisplayDateStringFormat(data.CreatedDate), data.Createdby };
            gvDenoChange.DataSource = reslist.ToList();
            gvDenoChange.DataBind();
            gvDenoChange.Columns[0].Visible = false;
            gvDenoChange.Columns[12].Visible = false;
            gvDenoChange.Columns[13].Visible = false;

        }

        protected void gvDenoChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            hdID.Value = gvDenoChange.SelectedRow.Cells[0].Text;
            string id = hdID.Value.ToString();
            DenoChange business = new DenoChange();
            var entity = business.FindDataByID(id);
            if (entity != null)
            {
                this.ddlPROJECT.SelectedValue = entity.PROJECT;               
                this.txtProbes.Text = entity.Probes.ToString();
                this.txtPricingProbes.Text = entity.Pricingprobes.ToString();
                this.txtVotes.Text = entity.Votes.ToString();
                this.txtMasks.Text = entity.Masks.ToString();
                this.txtRepricing.Text = entity.Repricing.ToString();
                this.txtScenes.Text = entity.ProbesperScene.ToString();
                this.txtSceneRecog.Text = entity.SceneRecog.ToString();
                this.txtCategoryExpert.Text = entity.Expert.ToString();
                this.txtExpertVoting.Text = entity.ExpertVoting.ToString();
                this.txtDcDate.Text = GeneralUtility.ConvertDisplayDateStringFormat(entity.DCDate);
                this.txtDcDateTo.Text = GeneralUtility.ConvertDisplayDateStringFormat(entity.DCDate);
            }
            btnSubmit.Text = "Update";
        }    

        private void BindPROJECT()
        {
            var result = new ProjectDenominators().FindPROJECT();
            this.ddlPROJECT.Items.Clear();
            ddlPROJECT.Items.Insert(0, "Select");
            for (int i = 0; i < result.Count; i++)
            {
                ddlPROJECT.Items.Insert(i + 1, new ListItem(result[i].PROJECT, result[i].PROJECT));
            }

        }

      


    }
}