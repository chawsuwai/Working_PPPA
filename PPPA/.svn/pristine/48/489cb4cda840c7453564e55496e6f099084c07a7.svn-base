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

namespace PPP_Project
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var userEntity = new User().FindByIDandPasswordandBranchCode(TextBox1.Text, TextBox2.Text, "MW"); //BranchSection.Instance.name
            if (userEntity == null)
            {
                MessageBox.MessageShow(this.GetType(), "User Name and Password not match.", ClientScript);
                return;
            }
            Session["UserType"] = userEntity;
            Session["ID"] = userEntity;

            Response.Redirect("SingleSheet_Excel_Import.aspx");//ImportExcel.aspx
        }
    }
}