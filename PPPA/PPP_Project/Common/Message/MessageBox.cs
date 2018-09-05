using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.UI;

namespace PPP_Project.Common.Message
{
    public  static class MessageBox 
    {

        public static void MessageShow(Type T,string message,ClientScriptManager sc)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            sc.RegisterClientScriptBlock(T, "alert", sb.ToString());
        }
    }
}