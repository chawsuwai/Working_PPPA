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
    public partial class ProbesQtySetup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DisplayData();
            }
        }


        private bool ValidateForm()
        {
            if (txtQty.Text == "")
            {
                MessageBox.MessageShow(this.GetType(), "Please Type Probes Qty.", ClientScript);
                txtQty.Focus();
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
                var probesqtyInfoEntity = new ProbesQty().FindQty();

                if (probesqtyInfoEntity != null)
                    {
                    try
                    {
                        var userEntity = (UserEntity)Session["ID"];
                        new ProbesQty
                        {
                            Entity = new PQuantityEntity
                            {
                                ID = probesqtyInfoEntity.ID,
                                Qty = Convert.ToInt32(txtQty.Text),                                 
                                Createdby = userEntity.ID,
                              
                            }
                        }.Update();
                        MessageBox.MessageShow(this.GetType(), "Successfully Updated.", ClientScript);
                        btnSubmit.Text = "Update";
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
                        new ProbesQty
                        {
                            Entity = new PQuantityEntity
                            {
                                ID = GeneralUtility.GeneratedKey,
                                Qty = Convert.ToInt32(txtQty.Text),
                                Createdby = userEntity.ID,

                            }
                        }.Save();
                        MessageBox.MessageShow(this.GetType(), "Successfully Save.", ClientScript);
                        btnSubmit.Text = "Update";
                        scope.Complete();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }



            }
           // txtQty.Text = "";

          
         

          

        }

        private void DisplayData()
        {

            var probesqtyInfoEntity = new ProbesQty().FindQty();

            if (probesqtyInfoEntity != null)
            {

                this.txtQty.Text = probesqtyInfoEntity.Qty.ToString();
                btnSubmit.Text = "Update";
               

            }
        }

     

        
    }
}