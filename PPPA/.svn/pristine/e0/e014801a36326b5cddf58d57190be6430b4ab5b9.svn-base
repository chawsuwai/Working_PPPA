using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PPP_Project.Criteria;
using PPP_Project.Entity;
using PPP_Project.Common.Enum;
using PPP_Project.Common.BranchConfiguration;
using PPP_Project.Common.Extension;
using PPP_Project.Common.Message;
using PPP_Project.Common.Utility;
using System.Transactions;

namespace PPP_Project
{
    public partial class UserSignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<UserType> list = Enum.GetValues(typeof(UserType))
                .Cast<UserType>()
                .ToList();

                foreach (var v in list)
                {
                    ddlUserType.Items.Add(new ListItem { Value = ((int)v).ToString(), Text = ((UserType)v).GetDescription() });
                }
                btnUpdate.Visible = false;
                BindGrid();
            }
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            if (IsValid((int)RecordStatus.Save))
            {
                using (TransactionScope Scope = new TransactionScope())
                {
                    try
                    {
                        new User
                        {
                            Entity = new UserEntity
                            {
                                ID = txtUsername.Text,
                                Password = txtPassword.Text,
                                UserType = Convert.ToInt32(ddlUserType.SelectedValue),
                                BranchCode ="MW",
                            }
                        }.Save();
                        Scope.Complete();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    // Added By MMC
                    finally
                    {
                        Scope.Dispose();
                        BindGrid();
                        ClearData();
                        MessageBox.MessageShow(this.GetType(), "Saved Successful.", ClientScript);
                    }
                }
            }
        }

        private void BindGrid()
        {
            var list = new User().Finds().Select(x => new { UserName = x.ID, UserType = ((UserType)x.UserType).GetDescription() });
            var orderlist = list.OrderBy(x => x.UserType).ToList();
            gvUser.DataSource = orderlist;
            gvUser.DataBind();
        }

        private void ClearData()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPwd.Text = "";
        }

        private bool IsValid(int status)
        {
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.MessageShow(this.GetType(), "Please type user name", ClientScript);
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.MessageShow(this.GetType(), "Please type password", ClientScript);
                return false;
            }
            if (txtConfirmPwd.Text != txtPassword.Text)
            {
                MessageBox.MessageShow(this.GetType(), "Password and Confirm Password do not match.", ClientScript);
                return false;
            }

            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                if (txtConfirmPwd.Text != txtPassword.Text)
                {
                    MessageBox.MessageShow(this.GetType(), "Password and Confirm Password do not match.", ClientScript);
                    return false;
                }
            }

            if (status == (int)RecordStatus.Save)
            {
                if (new User().FindByID(txtUsername.Text.Trim()) != null)
                {
                    MessageBox.MessageShow(this.GetType(), "User name Already define", ClientScript);
                    return false;
                }
            }
            return true;

        }

        protected void gvUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = gvUser.SelectedRow.Cells[0].Text;
            var user = new User().FindByID(id);
            txtUsername.Text = user.ID;
            ddlUserType.SelectedValue = user.UserType.ToString();
            btnCreate.Visible = false;
            btnUpdate.Visible = true;
            txtUsername.Enabled = false;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsValid((int)RecordStatus.Update))
            {
                using (TransactionScope Scope = new TransactionScope())
                {
                    try
                    {
                        new User
                        {
                            Entity = new UserEntity
                            {
                                ID = txtUsername.Text,
                                Password = txtPassword.Text,
                                UserType = Convert.ToInt32(ddlUserType.SelectedValue),
                                BranchCode = "MW",
                            }
                        }.Update();
                        btnCancel_Click(sender, e);
                        Scope.Complete();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                   finally
                    {
                        Scope.Dispose();
                        BindGrid(); ClearData();
                        MessageBox.MessageShow(this.GetType(), "Updated Successful.", ClientScript);
                    }
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnCreate.Visible = true;
            txtUsername.Enabled = true;
            txtConfirmPwd.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            ddlUserType.SelectedIndex = 0;
        }

    }
}