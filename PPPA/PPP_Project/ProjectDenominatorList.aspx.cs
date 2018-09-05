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
    public partial class ProjectDenominatorList : System.Web.UI.Page
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
            }
        }

        protected void gvDenoChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            hdID.Value = gvDenoChange.SelectedRow.Cells[0].Text;
            string id = hdID.Value.ToString();
            DenoChange business = new DenoChange();
            var entity = business.FindDataByID(id);
            if (entity != null)
            {
                Response.Redirect("ProjectDenominatorsChanges.aspx?PROJECT=" + id);
            }
        }

        #region +++ Codes of Private Access Methods +++

        private void BindGrid()
        {
            gvDenoChange.Columns[0].Visible = true;
            DenoChange Pbusiness = new DenoChange();
            var list = Pbusiness.Find();
            var reslist = from data in list
                          select new { data.ID, data.PROJECT, data.Probes, data.Pricingprobes, data.Votes, data.Masks, data.Repricing, data.SceneRecog, data.ProbesperScene, data.Expert, data.ExpertVoting, DCDate = GeneralUtility.ConvertDisplayDateStringFormat(data.DCDate), CreatedDate = GeneralUtility.ConvertDisplayDateStringFormat(data.CreatedDate), data.Createdby };

            reslist = this.ddlPROJECT.SelectedItem.Text == "All" ? reslist : reslist.Where(x => x.PROJECT == this.ddlPROJECT.SelectedValue).ToList();
            gvDenoChange.DataSource = reslist.ToList();
            gvDenoChange.DataBind();
            gvDenoChange.Columns[0].Visible = false;
            gvDenoChange.Columns[12].Visible = false;
            gvDenoChange.Columns[13].Visible = false;

        }

        private void BindPROJECT()
        {
            var result = new ProjectDenominators().FindPROJECT();
            this.ddlPROJECT.Items.Clear();
            ddlPROJECT.Items.Insert(0, "All");
            for (int i = 0; i < result.Count; i++)
            {
                ddlPROJECT.Items.Insert(i + 1, new ListItem(result[i].PROJECT, result[i].PROJECT));
            }

        }

        #endregion

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.MessageShow(this.GetType(), ex.Message.ToString(), ClientScript);
            }
        }
    }
}