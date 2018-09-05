using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PPP_Project.Base;
using PPP_Project.Entity;
using PPP_Project.DAO;
using PPP_Project.Common;
using PPP_Project.CommonAttributes;
using PPP_Project.Common.Extension;
using PPP_Project.Common.Enum;

namespace PPP_Project
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"] == null)
            {
                //lnkbtnLogut.Visible = true;
                //var userEntity = (UserEntity)Session["ID"];
                //lblUserName.Text = userEntity.ID.ToString();
                Response.Redirect("Login.aspx");
            }
        }

        protected void lnkbtnLogut_Click(object sender, EventArgs e)
        {
            Session["UserType"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}