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
    public partial class ProbesRangeSetup : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRangeInfo();
            }
        }



        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string msg;

            if (!ValidateForm())
                return;

            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    var userEntity = (UserEntity)Session["ID"];
                    var business = new ProbesRange();
                    var entity = business.FindRangeInfo();
                    var range_list = new List<ProbesRangeEntity>();
                    if (entity.Count() != 0)
                    {
                        if (entity != null)
                        {

                            if ((txtFromRange1.Text != "" && txtToRange1.Text != "") || this.hdID1.Value != string.Empty)
                            {
                                var rangeEntity = new ProbesRangeEntity();
                                if (this.hdID1.Value != string.Empty)
                                {
                                    rangeEntity.ID = Convert.ToInt16(this.hdID1.Value);
                                }
                                else
                                {
                                    rangeEntity.ID = 1;
                                }


                                rangeEntity.FromRange = Convert.ToInt32(txtFromRange1.Text);
                                rangeEntity.ToRange = Convert.ToInt32(txtToRange1.Text);     
                                range_list.Add(rangeEntity);
                            }

                            if ((txtFromRange2.Text != "" && txtToRange2.Text != "") || this.hdID2.Value != string.Empty)
                            {
                                var rangeEntity = new ProbesRangeEntity();
                                if (this.hdID2.Value != string.Empty)
                                {
                                    rangeEntity.ID = Convert.ToInt16(this.hdID2.Value);
                                }
                                else
                                {
                                    rangeEntity.ID = 2;
                                }


                                rangeEntity.FromRange = Convert.ToInt32(txtFromRange2.Text);
                                rangeEntity.ToRange = Convert.ToInt32(txtToRange2.Text);     
                                range_list.Add(rangeEntity);
                            }

                            if ((txtFromRange3.Text != "" ) || this.hdID3.Value != string.Empty)
                            {
                                var rangeEntity = new ProbesRangeEntity();
                                if (this.hdID3.Value != string.Empty)
                                {
                                    rangeEntity.ID = Convert.ToInt16(this.hdID3.Value);                                   
                                }
                                else
                                {
                                    rangeEntity.ID = 3;
                                }

                                rangeEntity.FromRange = Convert.ToInt32(txtFromRange3.Text);                              
                                range_list.Add(rangeEntity);
                            }

                           

                        }
                        #region Update Range Info

                        ProbesRange itemBusiness = new ProbesRange();

                        try
                        {

                            foreach (var v in range_list)
                            {

                                if (itemBusiness.FindByID(v.ID) == null)
                                {
                                    itemBusiness.Entity = v;
                                    itemBusiness.Save();
                                }

                                else
                                {
                                    itemBusiness.Entity = v;
                                    itemBusiness.UpdateRangeInfo(v);
                                }



                            }
                          
                            MessageBox.MessageShow(this.GetType(), "Update Successfully!.", ClientScript);
                        }
                        catch (Exception ex)
                        {
                            Response.Redirect("error.aspx");
                            throw ex;
                        }

                        #endregion

                    }
                    else
                    {
                        var rangelist = new List<ProbesRangeEntity>();
                        RangeInfoBindList(rangelist);
                        #region Save Range Info

                        ProbesRange itemBusiness = new ProbesRange();

                        try
                        {

                            foreach (var v in rangelist)
                            {
                                itemBusiness.Entity = v;
                                itemBusiness.Save();

                            }
                            MessageBox.MessageShow(this.GetType(), "Save Successfully!.", ClientScript);
                        }
                        catch (Exception ex)
                        {
                            Response.Redirect("error.aspx");
                            throw ex;
                        }
                        #endregion
                    }

                    scope.Complete();
                }
                catch (Exception ex)
                {
                    msg = ex.Message.ToString();
                    MessageBox.MessageShow(this.GetType(), ex.Message.ToString(), ClientScript);
                }

            }
            LoadRangeInfo();
         

        }


        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(this.txtFromRange1.Text.Trim()))
            {
                MessageBox.MessageShow(this.GetType(), "Please Type Range1.", ClientScript);
                txtFromRange1.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtToRange1.Text.Trim()))
            {
                MessageBox.MessageShow(this.GetType(), "Please Type Range1.", ClientScript);
                txtToRange1.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtFromRange2.Text.Trim()))          
            {
                MessageBox.MessageShow(this.GetType(), "Please Type Range2.", ClientScript);
                txtFromRange2.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtToRange2.Text.Trim()))
            {
                MessageBox.MessageShow(this.GetType(), "Please Type Range2.", ClientScript);
                txtToRange2.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(this.txtFromRange3.Text.Trim()))  
            {
                MessageBox.MessageShow(this.GetType(), "Please Type Range3.", ClientScript);
                txtFromRange3.Focus();
                return false;
            }

            return true;
        }


        private void RangeInfoBindList(List<ProbesRangeEntity> rangelist)
        {

            if (txtFromRange1.Text != "" && txtToRange1.Text != "")
            {
                var rangeEntity = new ProbesRangeEntity();
                rangeEntity.ID = 1;
                rangeEntity.FromRange = Convert.ToInt32(txtFromRange1.Text);
                rangeEntity.ToRange = Convert.ToInt32(txtToRange1.Text);     
                rangelist.Add(rangeEntity);
            }
            if (txtFromRange2.Text != "" && txtToRange2.Text != "")
            {
                var rangeEntity = new ProbesRangeEntity();
                rangeEntity.ID = 2;
                rangeEntity.FromRange = Convert.ToInt32(txtFromRange2.Text);
                rangeEntity.ToRange = Convert.ToInt32(txtToRange2.Text);     
                rangelist.Add(rangeEntity);
            }

            if (txtFromRange3.Text != "" )
            {
                var rangeEntity = new ProbesRangeEntity();
                rangeEntity.ID = 3;
                rangeEntity.FromRange = Convert.ToInt32(txtFromRange3.Text);                
                rangelist.Add(rangeEntity);
            }


        }


        private void LoadRangeInfo()
        {
         
            this.hdID1.Value = string.Empty;  //RangeID
            this.hdID2.Value = string.Empty;
            this.hdID3.Value = string.Empty;
          
                var business = new ProbesRange();
                var entity = business.FindRangeInfo();
                if (entity.Count != 0)
                {
                    for (int i = 0; i < entity.Count; i++)
                    {
                        if (i == 0)
                        {
                            this.hdID1.Value = entity[i].ID.ToString();
                            txtFromRange1.Text = entity[i].FromRange.ToString();
                            txtToRange1.Text = entity[i].ToRange.ToString();
                            lblRange1.Text = entity[i].Range;
                        }


                        if (i == 1)
                        {
                            this.hdID2.Value = entity[i].ID.ToString();
                            txtFromRange2.Text = entity[i].FromRange.ToString();
                            txtToRange2.Text = entity[i].ToRange.ToString();
                            lblRange2.Text = entity[i].Range;
                        }

                        if (i == 2)
                        {
                            this.hdID3.Value = entity[i].ID.ToString();
                            txtFromRange3.Text = entity[i].FromRange.ToString();
                            lblRange3.Text = entity[i].Range;
                        }

                    }
                }
    
        }
    }
}